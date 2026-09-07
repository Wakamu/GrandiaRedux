"""Diff vanilla vs Redux M_DAT.BIN and emit per-enemy C# patches."""
from __future__ import annotations

import re
import struct
from collections import defaultdict
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
OUT = ROOT / "Enemies"
VANILLA = Path(r"C:\Program Files (x86)\Steam\steamapps\common\GRANDIA HD Remaster\content\BATLE\M_DAT.BIN")
REDUX = Path(r"C:\ProgramData\Archipelago\Grandia\native\redux_content\BATLE\M_DAT.BIN")
SPECIES_CS = Path(r"C:\Users\User\Projects\GrandiaFieldPatch\sdk\Species.cs")
ITEM_CS = Path(r"C:\Users\User\Projects\GrandiaFieldPatch\sdk\Item.cs")

ELEM = {
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
STAT = {0: "Attack", 1: "Defense", 2: "Speed", 3: "Move", 4: "MaxHp", 5: "All"}
DAMAGE = {0: "Physical", 1: "Magic", 2: "WeaponElement"}
STATUS = {
    0: "None",
    1: "Confuse",
    2: "Sleep",
    3: "Paralyze",
    4: "Poison",
    5: "Plague",
    6: "Stop",
    7: "Silence",
}
HEAL = {0: "Hp", 1: "Revive", 3: "Sp", 4: "MpLv1", 5: "MpLv2", 6: "MpLv3", 7: "Special", 8: "AllMp"}
CLEAR = {1: "Wake", 2: "Blind", 3: "Paralyze", 4: "Poison", 5: "Plague", 6: "Stop", 7: "Silence", 8: "All"}


def load_enum(path: Path, skip_prefix: tuple[str, ...] = ()) -> dict[int, str]:
    text = path.read_text(encoding="utf-8")
    out: dict[int, str] = {}
    for m in re.finditer(r"^\s+(\w+)\s*=\s*(\d+)", text, re.M):
        name, val = m.group(1), int(m.group(2))
        if name.startswith(skip_prefix):
            continue
        out[val] = name
    return out


def load_display_names(path: Path) -> dict[int, str]:
    text = path.read_text(encoding="utf-8")
    out: dict[int, str] = {}
    for m in re.finditer(
        r"/// <summary>([^<(]+).*?</summary>\s+(\w+)\s*=\s*(\d+)",
        text,
        re.S,
    ):
        out[int(m.group(3))] = m.group(1).strip()
    return out


def u16(data: bytes, off: int) -> int:
    return struct.unpack_from("<H", data, off)[0]


def i16(data: bytes, off: int) -> int:
    return struct.unpack_from("<h", data, off)[0]


def plausible(data: bytes, off: int, *, loose: bool = False) -> bool:
    if off + 0x2E > len(data):
        return False
    if data[off] == 0:
        return False
    if not (1 <= data[off + 1] <= 99):
        return False
    cap_hp = 32000 if loose else 12000
    cap_stat = 4000 if loose else 999
    hp = u16(data, off + 2)
    if not (1 <= hp <= cap_hp):
        return False
    for o in (4, 6, 8, 10):
        if u16(data, off + o) > cap_stat:
            return False
    for o in (14, 16):
        if u16(data, off + o) > 65535:
            return False
    if data[off + 0x22] > 8 or data[off + 0x23] > 80:
        return False
    if u16(data, off + 0x14) > 511 or u16(data, off + 0x16) > 511:
        return False
    if data[off + 0x18] > 100 or data[off + 0x19] > 100:
        return False
    return True


def parse_header(data: bytes, off: int) -> dict:
    return {
        "id": data[off],
        "level": data[off + 1],
        "hp": u16(data, off + 2),
        "str": u16(data, off + 4),
        "vit": u16(data, off + 6),
        "wit": u16(data, off + 8),
        "agi": u16(data, off + 10),
        "exp": u16(data, off + 14),
        "gold": u16(data, off + 16),
        "drop0": u16(data, off + 0x14),
        "drop1": u16(data, off + 0x16),
        "rate0": data[off + 0x18],
        "rate1": data[off + 0x19],
        "attacks": data[off + 0x22],
        "range": data[off + 0x23],
        "fire": data[off + 0x2C] >> 4,
        "water": data[off + 0x2C] & 0xF,
        "wind": data[off + 0x2D] >> 4,
        "earth": data[off + 0x2D] & 0xF,
    }


def parse_skills(data: bytes, off: int) -> list[dict]:
    skills = []
    p = off + 0x5C
    end = min(len(data), off + 0x400)
    for _ in range(8):
        if p + 22 > end:
            break
        if data[p + 1] != 1:
            break
        power = i16(data, p + 6)
        flags = u16(data, p + 8)
        strength = (flags & 1) == 0
        element = data[p + 0xA]
        effect = data[p + 0xD]
        mode = data[p + 0xE]
        add = data[p + 0xF]
        chance = data[p + 0x10]
        add_level = data[p + 0x11]
        speed = data[p + 0x13]
        q = p + 22
        while q < end and data[q] != 0:
            q += 1
        if q >= end:
            break
        q += 1
        while q < end and data[q] == 0:
            q += 1
        name = ""
        if q < end and data[q] == 3:
            q += 1
            n0 = q
            while q < end and data[q] != 0:
                q += 1
            name = data[n0:q].decode("ascii", "replace")
            if q < end and data[q] == 0:
                q += 1
        skills.append(
            {
                "name": name,
                "power": power,
                "strength": strength,
                "element": element,
                "effect": effect,
                "mode": mode,
                "add": add,
                "chance": chance,
                "add_level": add_level,
                "speed": speed,
            }
        )
        p = q
        while p < end and data[p] == 0:
            p += 1
    return skills


def find_models(vanilla: bytes, redux: bytes) -> dict[int, list[int]]:
    hits: dict[int, list[int]] = defaultdict(list)
    n = len(vanilla) - 0x30
    for off in range(n):
        if not plausible(vanilla, off):
            continue
        sid = vanilla[off]
        if redux[off] != sid or not plausible(redux, off, loose=True):
            continue
        hits[sid].append(off)
    chosen: dict[int, list[int]] = {}
    for sid, offs in hits.items():
        def score(o: int) -> int:
            s = 0
            if vanilla[o : o + 0x30] != redux[o : o + 0x30]:
                s += 20
            sk = parse_skills(vanilla, o)
            if sk != parse_skills(redux, o):
                s += 10
            if o + 0x5D < len(vanilla) and vanilla[o + 0x5D] == 1:
                s += 8
            if sk and any(c.isalpha() for c in sk[0]["name"]):
                s += 12
            return s

        ranked = sorted(offs, key=score, reverse=True)
        best = score(ranked[0])
        pool = [o for o in ranked if score(o) == best and best > 0] or ranked[:1]
        uniq: list[int] = []
        for o in pool:
            if uniq and o - uniq[-1] < 0x80:
                continue
            uniq.append(o)
        chosen[sid] = uniq
    return chosen


def item_cs(item_id: int, items: dict[int, str]) -> str:
    if item_id in items:
        return f"Item.{items[item_id]}"
    return f"(Item){item_id}"


def elem_cs(value: int) -> str:
    if value in ELEM:
        return f"CombatElement.{ELEM[value]}"
    return f"(CombatElement){value}"


def effect_cs(value: int) -> str:
    if value in EFFECT:
        return f"EffectType.{EFFECT[value]}"
    return f"(EffectType){value}"


def mode_cs(effect: int, mode: int) -> str:
    table = {
        0: HEAL,
        3: DAMAGE,
        5: STATUS,
        6: CLEAR,
        7: STAT,
    }.get(effect, {})
    prefix = {
        0: "HealMode",
        3: "DamageKind",
        5: "StatusAilment",
        6: "ClearAilment",
        7: "StatMod",
    }.get(effect)
    if prefix and mode in table:
        return f"(int){prefix}.{table[mode]}"
    return str(mode)


def add_cs(value: int) -> str:
    if value in STATUS:
        return f"StatusAilment.{STATUS[value]}"
    return f"(StatusAilment){value}"


def emit_edit(
    sid: int,
    off: int,
    van: dict,
    red: dict,
    vskills: list[dict],
    rskills: list[dict],
    species: dict[int, str],
    items: dict[int, str],
    displays: dict[int, str],
    when: str | None,
) -> str:
    name = species.get(sid, f"Id{sid}")
    lines = ["        new()\n        {\n"]
    lines.append(f"            Species = Species.{name},\n")
    note = displays.get(sid, name)
    if when:
        note += f" (vanilla HP {van['hp']})"
        lines.append(f'            Note = "{note}",\n')
        lines.append(f"            When = {when},\n")
    else:
        lines.append(f'            Note = "{note}",\n')

    def put(field: str, key: str) -> None:
        if van[key] != red[key]:
            lines.append(f"            {field} = {red[key]}, // vanilla {van[key]}\n")

    put("Level", "level")
    put("MaxHp", "hp")
    put("Str", "str")
    put("Vit", "vit")
    put("Wit", "wit")
    put("Agi", "agi")
    put("Exp", "exp")
    put("Gold", "gold")
    put("AttackCount", "attacks")
    put("AttackRange", "range")
    put("FireResist", "fire")
    put("WaterResist", "water")
    put("WindResist", "wind")
    put("EarthResist", "earth")
    if van["drop0"] != red["drop0"]:
        lines.append(
            f"            DropItem0 = {item_cs(red['drop0'], items)}, // vanilla {item_cs(van['drop0'], items)}\n"
        )
    if van["rate0"] != red["rate0"]:
        lines.append(f"            DropRate0 = {red['rate0']}, // vanilla {van['rate0']}\n")
    if van["drop1"] != red["drop1"]:
        lines.append(
            f"            DropItem1 = {item_cs(red['drop1'], items)}, // vanilla {item_cs(van['drop1'], items)}\n"
        )
    if van["rate1"] != red["rate1"]:
        lines.append(f"            DropRate1 = {red['rate1']}, // vanilla {van['rate1']}\n")

    skill_blocks = []
    for i, rs in enumerate(rskills):
        vs = vskills[i] if i < len(vskills) else None
        if vs is None:
            continue
        parts = []
        if vs["power"] != rs["power"]:
            parts.append(f"                    Power = {rs['power']}, // vanilla {vs['power']}")
        if vs["speed"] != rs["speed"]:
            parts.append(f"                    Speed = {rs['speed']}, // vanilla {vs['speed']}")
        if vs["strength"] != rs["strength"]:
            parts.append(
                f"                    Strength = {str(rs['strength']).lower()}, // vanilla {vs['strength']}"
            )
        if vs["element"] != rs["element"]:
            parts.append(
                f"                    Element = {elem_cs(rs['element'])}, // vanilla {elem_cs(vs['element'])}"
            )
        if vs["effect"] != rs["effect"]:
            parts.append(
                f"                    Effect = {effect_cs(rs['effect'])}, // vanilla {effect_cs(vs['effect'])}"
            )
        if vs["mode"] != rs["mode"]:
            parts.append(
                f"                    Mode = {mode_cs(rs['effect'], rs['mode'])}, // vanilla {mode_cs(vs['effect'], vs['mode'])}"
            )
        if vs["add"] != rs["add"]:
            parts.append(
                f"                    AddAilment = {add_cs(rs['add'])}, // vanilla {add_cs(vs['add'])}"
            )
        if vs["chance"] != rs["chance"]:
            parts.append(
                f"                    Chance = {rs['chance']}, // vanilla {vs['chance']}"
            )
        if vs["add_level"] != rs["add_level"]:
            parts.append(
                f"                    AddLevel = {rs['add_level']}, // vanilla {vs['add_level']}"
            )
        if not parts:
            continue
        name = (vs["name"] or rs["name"] or f"slot{i}").replace('"', '\\"')
        skill_blocks.append(
            "                new SkillChange\n"
            "                {\n"
            f'                    Name = "{name}",\n'
            + "\n".join(parts)
            + "\n                }"
        )
    if skill_blocks:
        lines.append("            Skills =\n            [\n")
        lines.append(",\n".join(skill_blocks))
        lines.append("\n            ],\n")
    lines.append("        }")
    body = "".join(lines)
    if "MaxHp" not in body and "Level =" not in body and "Str =" not in body and "Vit =" not in body \
            and "Wit =" not in body and "Agi =" not in body and "Exp =" not in body \
            and "Gold =" not in body and "Attack" not in body and "Resist" not in body \
            and "Drop" not in body and "Skills =" not in body:
        return ""
    return body


FILE_SPLITS = [
    ("01_Ids001.cs", "Ids001", 1, 64),
    ("02_Ids064.cs", "Ids064", 64, 128),
    ("03_Ids128.cs", "Ids128", 128, 192),
    ("04_Ids192.cs", "Ids192", 192, 256),
]


def main() -> None:
    vanilla = VANILLA.read_bytes()
    redux = REDUX.read_bytes()
    if len(vanilla) != len(redux):
        raise SystemExit(f"size mismatch {len(vanilla)} vs {len(redux)}")
    species = load_enum(SPECIES_CS, skip_prefix=("Skip",))
    displays = load_display_names(SPECIES_CS)
    items = load_enum(ITEM_CS)
    models = find_models(vanilla, redux)
    models = {sid: offs for sid, offs in models.items() if sid in species}
    print(f"species with a model: {len(models)}")
    missing = [i for i in species if i and i not in models]
    print(f"enum ids without header: {missing}")

    edits = []
    extra_skills = []
    for sid in sorted(models):
        offs = models[sid]
        for off in offs:
            van = parse_header(vanilla, off)
            red = parse_header(redux, off)
            vsk = parse_skills(vanilla, off)
            rsk = parse_skills(redux, off)
            if len(rsk) > len(vsk):
                extra_skills.append((sid, off, len(vsk), len(rsk)))
            when = None
            if len(offs) > 1:
                when = f"e => e.MaxHp == {van['hp']} && e.Level == {van['level']}"
            text = emit_edit(sid, off, van, red, vsk, rsk, species, items, displays, when)
            if text:
                edits.append((sid, off, van, red, text))

    print(f"patches: {len(edits)}")
    if extra_skills:
        print("redux added skill slots (cannot apply at runtime):")
        for row in extra_skills:
            print(" ", row)

    OUT.mkdir(exist_ok=True)
    for old in OUT.glob("0*.cs"):
        old.unlink()
    for fname, cls, lo, hi in FILE_SPLITS:
        chunk = [e for e in edits if lo <= e[0] < hi]
        if not chunk:
            continue
        items_cs = ",\n".join(t for *_, t in chunk)
        src = f"""using Grandia.Sdk;

namespace GrandiaRedux.Enemies;

/// <summary>
/// Values that differ between HD Remaster <c>BATLE/M_DAT.BIN</c> and
/// Redux 0.4.9 <c>redux_content/BATLE/M_DAT.BIN</c>. Unlisted fields stay vanilla.
/// </summary>
internal static class {cls}
{{
    internal static readonly EnemyEdit[] All =
    [
{items_cs}
    ];
}}
"""
        (OUT / fname).write_text(src, encoding="utf-8")

    book = """using Grandia.Sdk;

namespace GrandiaRedux.Enemies;

/// <summary>
/// Applies the Redux <c>M_DAT.BIN</c> delta for the loaded species.
/// Rematches that share a form-row are distinguished by vanilla HP/level
/// via <see cref="EnemyEdit.When"/>.
/// </summary>
internal static class EnemyBook
{
    private static readonly EnemyEdit[] All =
    [
        ..Ids001.All,
        ..Ids064.All,
        ..Ids128.All,
        ..Ids192.All,
    ];

    public static void Apply(EnemyLoadedEvent e)
    {
        foreach (var edit in All)
        {
            if (edit.Matches(e))
            {
                edit.Apply(e);
                return;
            }
        }
    }
}
"""
    (OUT / "EnemyBook.cs").write_text(book, encoding="utf-8")

    # sanity: Marna / Centipede / Slime
    for want, label in ((75, "Marna"), (105, "Centipede"), (126, "Slime")):
        row = next((e for e in edits if e[0] == want), None)
        print(label, "off", hex(row[1]) if row else None)
        if row:
            print(" ", {k: (row[2][k], row[3][k]) for k in ("hp", "str", "wit", "agi", "drop0", "rate0")})


if __name__ == "__main__":
    main()
