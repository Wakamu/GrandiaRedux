"""Diff vanilla vs Redux WINDT.BIN magic tables and emit OnMagic patches."""
from __future__ import annotations

import re
import struct
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
OUT = ROOT / "Magic"
VANILLA = Path(r"C:\Program Files (x86)\Steam\steamapps\common\GRANDIA HD Remaster\content\FIELD\WINDT.BIN")
REDUX = Path(r"C:\ProgramData\Archipelago\Grandia\native\redux_content\FIELD\WINDT.BIN")
SKILL_CS = Path(r"C:\Users\User\Projects\GrandiaFieldPatch\sdk\Skill.cs")

KIND = {
    1: "Dagger",
    2: "Sword",
    3: "Mace",
    4: "Ax",
    5: "Whip",
    6: "Bow",
    8: "Fire",
    9: "Water",
    10: "Wind",
    11: "Earth",
}
KIND_TO_ELEM = {8: "Fire", 9: "Water", 10: "Wind", 11: "Earth"}
ELEM_FLAG = {
    0x00: "None",
    0x10: "Fire",
    0x20: "Water",
    0x40: "Wind",
    0x80: "Earth",
    0x50: "Thunder",
    0x60: "Ice",
    0x90: "Explosion",
    0xA0: "Forest",
}
EFFECT = {
    0: "Heal",
    3: "Damage",
    4: "ProbDamage",
    5: "Status",
    6: "ClearStatus",
    7: "PowerUpDown",
    8: "Drain",
    9: "Special",
    10: "MonsterSpecial",
}


def u16(data: bytes, off: int) -> int:
    return struct.unpack_from("<H", data, off)[0]


def i16(data: bytes, off: int) -> int:
    return struct.unpack_from("<h", data, off)[0]


def combat_off(data: bytes) -> int:
    return struct.unpack_from("<I", data, 28)[0]


def learn_off(data: bytes) -> int:
    return struct.unpack_from("<I", data, 32)[0]


def parse_combat(data: bytes, table: int, skill_id: int) -> dict:
    rec = table + (skill_id - 1) * 24
    return {
        "cost": u16(data, rec + 2),
        "speed": u16(data, rec + 4),
        "knock": u16(data, rec + 6),
        "power": i16(data, rec + 8),
        "exp": data[rec + 12],
        "radius": data[rec + 13],
        "flags": data[rec + 14],
        "crit": data[rec + 17],
        "distance": data[rec + 23],
        "effect": data[rec + 18],
        "mode": data[rec + 19],
        "raw": data[rec : rec + 24],
    }


def parse_learn(data: bytes, table: int, skill_id: int) -> dict:
    rec = table + skill_id * 7
    reqs = []
    for p in range(3):
        kind = data[rec + p * 2]
        level = data[rec + p * 2 + 1]
        if kind == 0:
            break
        reqs.append((kind, level))
    return {"reqs": reqs, "mask": data[rec + 6], "raw": data[rec : rec + 7]}


def load_skills() -> tuple[dict[int, str], dict[int, str]]:
    text = SKILL_CS.read_text(encoding="utf-8")
    enum: dict[int, str] = {}
    display: dict[int, str] = {}
    for m in re.finditer(
        r"/// <summary>([^<(]+)\s*\(<c>(\d+)</c>\)\.</summary>\s+(\w+)\s*=",
        text,
    ):
        sid = int(m.group(2))
        display[sid] = m.group(1).strip()
        enum[sid] = m.group(3)
    return enum, display


def skill_cs(sid: int, enum: dict[int, str]) -> str:
    if sid in enum:
        return f"Skill.{enum[sid]}"
    return f"(Skill){sid}"


def elem_cs(flags: int) -> str:
    if flags in ELEM_FLAG:
        return f"CombatElement.{ELEM_FLAG[flags]}"
    return f"(CombatElement){flags}"


def effect_cs(value: int) -> str:
    if value in EFFECT:
        return f"EffectType.{EFFECT[value]}"
    return f"(EffectType){value}"


def magic_elem_from(learn: dict, flags: int) -> str:
    for kind, _ in learn["reqs"]:
        if kind in KIND_TO_ELEM:
            return KIND_TO_ELEM[kind]
    if flags & 0x10:
        return "Fire"
    if flags & 0x20:
        return "Water"
    if flags & 0x40:
        return "Wind"
    if flags & 0x80:
        return "Earth"
    return "None"


def emit(sid: int, vc: dict, rc: dict, vl: dict, rl: dict, enum: dict[int, str], display: dict[int, str]) -> str:
    lines = ["        new()\n        {\n"]
    lines.append(f"            Id = {skill_cs(sid, enum)},\n")
    note = display.get(sid, f"Skill {sid}")
    lines.append(f'            Note = "{note.replace(chr(34), "")}",\n')

    def put(field: str, a, b, fmt=None) -> None:
        if a == b:
            return
        rhs = fmt(b) if fmt else str(b)
        old = fmt(a) if fmt else str(a)
        lines.append(f"            {field} = {rhs}, // vanilla {old}\n")

    put("Power", vc["power"], rc["power"])
    put("Cost", vc["cost"], rc["cost"])
    put("Speed", vc["speed"], rc["speed"])
    put("IpKnockback", vc["knock"], rc["knock"])
    put("Exp", vc["exp"], rc["exp"])
    put("Radius", vc["radius"], rc["radius"])
    put("Distance", vc["distance"], rc["distance"])
    put("CancelChance", vc["crit"], rc["crit"])
    put("CharacterMask", vl["mask"], rl["mask"], lambda x: f"0x{x:02X}")
    put("Combat", vc["flags"], rc["flags"], elem_cs)
    ve = magic_elem_from(vl, vc["flags"])
    re = magic_elem_from(rl, rc["flags"])
    if ve != re:
        lines.append(f"            Element = MagicElement.{re}, // vanilla {ve}\n")
    put("Effect", vc["effect"], rc["effect"], effect_cs)
    put("Mode", vc["mode"], rc["mode"])
    if vl["reqs"] != rl["reqs"]:
        if rl["reqs"]:
            lines.append("            Requirements =\n            [\n")
            for kind, level in rl["reqs"]:
                kn = KIND.get(kind, None)
                if kn:
                    lines.append(f"                new(LearnKind.{kn}, {level}),\n")
                else:
                    lines.append(f"                new((LearnKind){kind}, {level}),\n")
            lines.append("            ],\n")
        else:
            lines.append("            Requirements = [],\n")
    lines.append("        }")
    body = "".join(lines)
    if not any(
        x in body
        for x in (
            "Power =",
            "Cost =",
            "Speed =",
            "IpKnockback",
            "Exp =",
            "Radius =",
            "Distance =",
            "Cancel",
            "CharacterMask",
            "Combat =",
            "Element =",
            "Effect =",
            "Mode =",
            "Requirements =",
        )
    ):
        return ""
    return body


def main() -> None:
    vanilla = VANILLA.read_bytes()
    redux = REDUX.read_bytes()
    vc0, vl0 = combat_off(vanilla), learn_off(vanilla)
    rc0, rl0 = combat_off(redux), learn_off(redux)
    enum, display = load_skills()
    magic, moves = [], []
    for sid in range(1, 128):
        vc = parse_combat(vanilla, vc0, sid)
        rc = parse_combat(redux, rc0, sid)
        vl = parse_learn(vanilla, vl0, sid)
        rl = parse_learn(redux, rl0, sid)
        if vc["raw"] == bytes(24) and vl["raw"] == bytes(7) and rc["raw"] == bytes(24) and rl["raw"] == bytes(7):
            continue
        text = emit(sid, vc, rc, vl, rl, enum, display)
        if not text:
            continue
        (magic if sid < 50 else moves).append((sid, text))
        if sid in (5, 12, 50, 52):
            print(
                f"id {sid} {display.get(sid)} power {vc['power']}->{rc['power']} "
                f"cost {vc['cost']}->{rc['cost']} speed {vc['speed']}->{rc['speed']}"
            )

    OUT.mkdir(exist_ok=True)

    def write_file(fname: str, cls: str, rows: list) -> None:
        items = ",\n".join(t for _, t in rows)
        src = f"""using Grandia.Sdk;

namespace GrandiaRedux.Magic;

/// <summary>
/// Values that differ between HD Remaster <c>FIELD/WINDT.BIN</c> sec7/sec8
/// and Redux 0.4.9. Unlisted fields stay vanilla.
/// </summary>
internal static class {cls}
{{
    internal static readonly MagicEdit[] All =
    [
{items}
    ];
}}
"""
        (OUT / fname).write_text(src, encoding="utf-8")

    write_file("01_Spells.cs", "Spells", magic)
    write_file("02_Moves.cs", "Moves", moves)
    print(f"spells {len(magic)} moves {len(moves)}")


if __name__ == "__main__":
    main()
