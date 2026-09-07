"""Diff vanilla vs Redux shop stock and WINDT sec3, emit OnShopOpen / OnItem patches."""
from __future__ import annotations

import json
import re
import struct
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
OUT_SHOPS = ROOT / "Shops"
OUT_ITEMS = ROOT / "Items"
VANILLA = Path(r"C:\Program Files (x86)\Steam\steamapps\common\GRANDIA HD Remaster\content")
REDUX = Path(r"C:\ProgramData\Archipelago\Grandia\native\redux_content")
ITEM_CS = Path(r"C:\Users\User\Projects\GrandiaFieldPatch\sdk\Item.cs")
SKILL_CS = Path(r"C:\Users\User\Projects\GrandiaFieldPatch\sdk\Skill.cs")
MAP_NAMES = Path(r"C:\Users\User\Projects\Grandipelago\Grandipelago\data\map_names.json")
TEXT1 = REDUX / "TEXT" / "EN" / "TEXT1.BIN"
TEXT1_VAN = VANILLA / "TEXT" / "EN" / "TEXT1.BIN"

PAGE_OFFS = (0x188, 0x1A8, 0x1C8)
PAGE_NAMES = ("Weapons", "Armor", "Goods")


def u16(data: bytes, off: int) -> int:
    return struct.unpack_from("<H", data, off)[0]


def load_enum(path: Path) -> dict[int, str]:
    text = path.read_text(encoding="utf-8")
    out: dict[int, str] = {}
    for m in re.finditer(r"^\s+(\w+)\s*=\s*(\d+)", text, re.M):
        out[int(m.group(2))] = m.group(1)
    return out


def load_display(path: Path) -> dict[int, str]:
    text = path.read_text(encoding="utf-8")
    out: dict[int, str] = {}
    for m in re.finditer(
        r"/// <summary>([^<(]+).*?</summary>\s+(\w+)\s*=\s*(\d+)",
        text,
        re.S,
    ):
        out[int(m.group(3))] = m.group(1).strip()
    return out


def text1_section(data: bytes, index: int, strip: bool) -> dict[int, str]:
    start = struct.unpack_from("<I", data, index * 4)[0]
    end = struct.unpack_from("<I", data, (index + 1) * 4)[0]
    blob = data[start:end]
    names: dict[int, str] = {}
    i = 0
    idx = 0
    while i < len(blob) and idx < 511:
        if blob[i] == 0:
            i += 1
            continue
        j = i
        while j < len(blob) and blob[j] != 0:
            j += 1
        raw = blob[i:j]
        if strip and raw.startswith(b"\x03"):
            raw = raw[1:]
        names[idx + 1] = raw.decode("ascii", "ignore")
        idx += 1
        i = j + 1
    return names


def text1_names(data: bytes) -> dict[int, str]:
    return text1_section(data, 6, strip=True)


def text1_rows(data: bytes) -> dict[int, tuple[str, str, str]]:
    shorts = text1_section(data, 5, strip=False)
    names = text1_section(data, 6, strip=True)
    descs = text1_section(data, 7, strip=True)
    out: dict[int, tuple[str, str, str]] = {}
    for iid in range(1, 512):
        out[iid] = (shorts.get(iid, ""), names.get(iid, ""), descs.get(iid, ""))
    return out


def sections(data: bytes):
    return [struct.unpack_from("<II", data, i * 8) for i in range(64)]


def sec(data: bytes, i: int) -> bytes:
    ptr, sz = sections(data)[i]
    if sz == 0 or ptr + sz > len(data):
        return b""
    return data[ptr : ptr + sz]


def page(blob: bytes, off: int) -> list[int]:
    ids: list[int] = []
    for i in range(16):
        if off + i * 2 + 2 > len(blob):
            break
        v = u16(blob, off + i * 2)
        if v == 0 or not (1 <= v <= 511):
            break
        ids.append(v)
    return ids


def shop_of(path: Path) -> tuple[list[int], list[int], list[int]] | None:
    blob = sec(path.read_bytes(), 10)
    if len(blob) < 0x1C8 + 2:
        return None
    rows = [page(blob, off) for off in PAGE_OFFS]
    if sum(len(r) for r in rows) == 0:
        return None
    return rows[0], rows[1], rows[2]


def mdp_index(root: Path) -> dict[str, Path]:
    out: dict[str, Path] = {}
    field = root / "FIELD"
    for p in list(field.glob("*.MDP")) + list(field.glob("*.mdp")):
        out[p.stem.upper()] = p
    return out


def windt_sec3(data: bytes) -> int:
    return struct.unpack_from("<I", data, 12)[0]


def parse_item(data: bytes, table: int, item_id: int) -> dict | None:
    rec = table + (item_id - 1) * 28
    if rec < 0 or rec + 28 > len(data):
        return None
    return {
        "use": u16(data, rec + 2),
        "cost": u16(data, rec + 4),
        "icon": data[rec + 6],
        "u7": data[rec + 7],
        "effect": data[rec + 9],
        "eval": data[rec + 10],
        "p1pre": data[rec + 15],
        "p2": data[rec + 16],
        "p3": data[rec + 17],
        "p4": data[rec + 18],
        "p1post": u16(data, rec + 19),
        "p2post": u16(data, rec + 21),
        "p3post": u16(data, rec + 23),
        "p4post": u16(data, rec + 25),
        "u8": data[rec + 8],
        "u11": data[rec + 11],
        "u12": data[rec + 12],
        "u13": data[rec + 13],
        "u14": data[rec + 14],
        "u27": data[rec + 27],
        "raw": data[rec : rec + 28],
    }


def item_cs(iid: int, enum: dict[int, str]) -> str:
    if iid in enum:
        return f"Item.{enum[iid]}"
    return f"(Item){iid}"


def skill_cs(sid: int, enum: dict[int, str]) -> str:
    if sid in enum:
        return f"Skill.{enum[sid]}"
    return f"(Skill){sid}"


def csharp_str(s: str) -> str:
    return s.replace("\\", "\\\\").replace('"', '\\"')


def list_preview(ids: list[int], names: dict[int, str]) -> str:
    if not ids:
        return "(empty)"
    return ", ".join(names.get(i, f"item_{i}") for i in ids)


def emit_shop(
    stem: str,
    area: str,
    van: tuple[list[int], list[int], list[int]],
    red: tuple[list[int], list[int], list[int]],
    enum: dict[int, str],
    vanilla_names: dict[int, str],
    redux_names: dict[int, str],
) -> str:
    lines = ["        new()\n        {\n"]
    lines.append(f"            Map = 0x{int(stem, 16):04X},\n")
    lines.append(f'            Note = "{csharp_str(area)}",\n')
    for field, a, b in zip(PAGE_NAMES, van, red):
        if a == b:
            continue
        lines.append(f"            {field} =\n            [\n")
        for iid in b:
            extra = ""
            red_nm = redux_names.get(iid, "")
            van_nm = vanilla_names.get(iid, "")
            if iid not in enum and red_nm:
                extra = f" // {red_nm}"
            elif red_nm and van_nm and red_nm != van_nm:
                extra = f" // {red_nm}"
            lines.append(f"                {item_cs(iid, enum)},{extra}\n")
        lines.append(f"            ], // vanilla {list_preview(a, vanilla_names)}\n")
    lines.append("        }")
    return "".join(lines)


def emit_item(
    iid: int,
    van: dict,
    red: dict,
    enum: dict[int, str],
    skills: dict[int, str],
    names: dict[int, str],
    van_text: dict[int, tuple[str, str, str]],
    red_text: dict[int, tuple[str, str, str]],
) -> str:
    vt = van_text.get(iid, ("", "", ""))
    rt = red_text.get(iid, ("", "", ""))
    if van["raw"] == red["raw"] and vt == rt:
        return ""

    lines = ["        new()\n        {\n"]
    extra = ""
    if iid not in enum:
        extra = f" // {names.get(iid, f'item_{iid}')}"
    lines.append(f"            Id = {item_cs(iid, enum)},{extra}\n")
    note = names.get(iid, f"Item {iid}")
    lines.append(f'            Note = "{csharp_str(note)}",\n')

    def put(field: str, a, b, fmt=None) -> None:
        if a == b:
            return
        rhs = fmt(b) if fmt else str(b)
        old = fmt(a) if fmt else str(a)
        lines.append(f"            {field} = {rhs}, // vanilla {old}\n")

    def junk_text(s: str) -> bool:
        t = s.strip().lower()
        return t in {
            "",
            "p",
            "d",
            "h",
            "ohibited",
            "prohibit",
            "prohibi",
            "prohibited",
        }

    def put_str(field: str, a: str, b: str) -> None:
        if a == b:
            return
        # Redux TEXT1 grew names in place and sliced unused Prohibited
        # slots. The SDK rebuild can grow the file, so skip that junk.
        if junk_text(b) and junk_text(a):
            return
        lines.append(f'            {field} = "{csharp_str(b)}", // vanilla "{csharp_str(a)}"\n')

    put("Cost", van["cost"], red["cost"])
    put("Icon", van["icon"], red["icon"])
    put("UseStatus", van["use"], red["use"])
    put("Effect", van["effect"], red["effect"], lambda x: skill_cs(x, skills))
    put("EffectValue", van["eval"], red["eval"])
    put("Unknown7", van["u7"], red["u7"])
    put("Unknown8", van["u8"], red["u8"])
    put("Unknown11", van["u11"], red["u11"])
    put("Unknown12", van["u12"], red["u12"])
    put("Unknown13", van["u13"], red["u13"])
    put("Unknown14", van["u14"], red["u14"])
    put("Unknown27", van["u27"], red["u27"])
    put("Para1Pre", van["p1pre"], red["p1pre"])
    put("Para2", van["p2"], red["p2"])
    put("Para3", van["p3"], red["p3"])
    put("Para4", van["p4"], red["p4"])
    put("Para1Post", van["p1post"], red["p1post"])
    put("Para2Post", van["p2post"], red["p2post"])
    put("Para3Post", van["p3post"], red["p3post"])
    put("Para4Post", van["p4post"], red["p4post"])
    put_str("ShortName", vt[0], rt[0])
    put_str("Name", vt[1], rt[1])
    put_str("Description", vt[2], rt[2])

    body = "".join(lines) + "        }"
    if not any(
        x in body
        for x in (
            "Cost =",
            "Icon =",
            "UseStatus",
            "Effect =",
            "EffectValue",
            "Unknown",
            "Para",
            "Name =",
            "ShortName",
            "Description",
        )
    ):
        return ""
    return body


def main() -> None:
    item_enum = load_enum(ITEM_CS)
    skill_enum = load_enum(SKILL_CS)
    vanilla_names = load_display(ITEM_CS)
    redux_names = dict(vanilla_names)
    van_text = text1_rows(TEXT1_VAN.read_bytes()) if TEXT1_VAN.exists() else {}
    red_text = text1_rows(TEXT1.read_bytes()) if TEXT1.exists() else {}
    if TEXT1.exists():
        redux_names.update(
            {
                k: v
                for k, v in text1_names(TEXT1.read_bytes()).items()
                if v and v.lower() != "prohibited"
            }
        )
    maps = json.loads(MAP_NAMES.read_text(encoding="utf-8")) if MAP_NAMES.exists() else {}

    van_mdps = mdp_index(VANILLA)
    red_mdps = mdp_index(REDUX)
    shops: list[str] = []
    for stem, path in sorted(red_mdps.items()):
        red = shop_of(path)
        if not red:
            continue
        van_path = van_mdps.get(stem)
        van = shop_of(van_path) if van_path else None
        van = van or ([], [], [])
        if van == red:
            continue
        info = maps.get(stem, {})
        area = info.get("area_name", stem) if isinstance(info, dict) else stem
        shops.append(emit_shop(stem, area, van, red, item_enum, vanilla_names, redux_names))
        print(f"{stem} {area} pages {[len(x) for x in red]}")

    van_w = (VANILLA / "FIELD" / "WINDT.BIN").read_bytes()
    red_w = (REDUX / "FIELD" / "WINDT.BIN").read_bytes()
    vt, rt = windt_sec3(van_w), windt_sec3(red_w)
    buckets: dict[str, list[str]] = {
        "Ids001": [],
        "Ids128": [],
        "Ids256": [],
        "Ids384": [],
    }
    for iid in range(1, 512):
        a = parse_item(van_w, vt, iid)
        b = parse_item(red_w, rt, iid)
        if not a or not b:
            continue
        text = emit_item(iid, a, b, item_enum, skill_enum, redux_names, van_text, red_text)
        if not text:
            continue
        if iid < 128:
            buckets["Ids001"].append(text)
        elif iid < 256:
            buckets["Ids128"].append(text)
        elif iid < 384:
            buckets["Ids256"].append(text)
        else:
            buckets["Ids384"].append(text)

    OUT_SHOPS.mkdir(exist_ok=True)
    OUT_ITEMS.mkdir(exist_ok=True)
    shop_items = ",\n".join(shops)
    stock_src = f"""using Grandia.Sdk;

namespace GrandiaRedux.Shops;

/// <summary>
/// Shop pages that differ between HD Remaster MDP sec[10] and
/// Redux 0.4.9. Unlisted pages stay vanilla.
/// </summary>
internal static class Stock
{{
    internal static readonly ShopEdit[] All =
    [
{shop_items}
    ];
}}
"""
    (OUT_SHOPS / "01_Stock.cs").write_text(stock_src, encoding="utf-8")

    files = (
        ("01_Ids001.cs", "Ids001", 1),
        ("02_Ids128.cs", "Ids128", 128),
        ("03_Ids256.cs", "Ids256", 256),
        ("04_Ids384.cs", "Ids384", 384),
    )
    for fname, cls, start in files:
        items = ",\n".join(buckets[cls])
        src = f"""using Grandia.Sdk;

namespace GrandiaRedux.Items;

/// <summary>
/// WINDT sec3 rows from id {start} that differ between HD Remaster
/// FIELD/WINDT.BIN and Redux 0.4.9. Unlisted fields stay vanilla.
/// Names / leftover sec3 bytes apply through OnItem (TEXT1 + WINDT).
/// </summary>
internal static class {cls}
{{
    internal static readonly ItemEdit[] All =
    [
{items}
    ];
}}
"""
        (OUT_ITEMS / fname).write_text(src, encoding="utf-8")

    n = sum(len(v) for v in buckets.values())
    print(
        f"shops {len(shops)} items {n} "
        + " ".join(f"{k}={len(v)}" for k, v in buckets.items())
    )


if __name__ == "__main__":
    main()
