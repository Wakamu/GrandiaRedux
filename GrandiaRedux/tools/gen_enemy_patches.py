"""Parse ReDux enemy-info blog text and emit per-enemy C# patches."""
from __future__ import annotations

import re
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
BLOG = Path(
    r"C:\Users\User\.cursor\projects\c-Users-User-Projects-Grandipelago-Grandipelago"
    r"\agent-tools\d89be397-5747-490c-9a30-72d5463cc305.txt"
)
SPECIES_CS = Path(r"C:\Users\User\Projects\GrandiaFieldPatch\sdk\Species.cs")
OUT = ROOT / "Enemies"

NAME_JUNK = {
    "stats", "lv", "level", "hp", "str", "vit", "wit", "agi", "unknown", "exp",
    "gp", "drops", "skills", "skillsz", "spells", "resistances", "range",
    "attacks", "note", "size", "yes", "no", "speed", "element",
    "strength", "reduce", "def", "lvl", "n/a", "na", "none",
}

# Blog title / qualifier -> Species enum. First match wins for unique names;
# rematches and parts use the qualifier.
MANUAL: dict[tuple[str, str], str] = {
    ("giant centipede", ""): "GiantCentipede",
    ("sour moth", ""): "DizzyMoth",
    ("scissorlock", ""): "Scissorlock",
    ("desert lord", ""): "Scissorlock",
    ("sad head", ""): "PerilHead",
    ("gaia minion", ""): "GigaGaia",
    ("will-o'-wisp", ""): "WillOWisp",
    ("great susano-o", ""): "GreatSusanoO",
    ("gaia ape", ""): "GaiaApe",
    ("oopa-loopa", ""): "OopaLoopa",
    ("lord's ghost", ""): "LordsGhost190",
    ("ganymede", "boss"): "Ganymede156",
    ("ganymede", "head"): "Ganymede157",
    ("ganymede", "head boss"): "Ganymede157",
    ("saki", "1st fight"): "Saki209",
    ("saki", "1st fight boss"): "Saki209",
    ("saki", "2nd fight"): "Saki210",
    ("saki", "2nd fight boss"): "Saki210",
    ("nana", "1st fight"): "Nana213",
    ("nana", "1st fight boss"): "Nana213",
    ("nana", "2nd fight"): "Nana214",
    ("nana", "2nd fight boss"): "Nana214",
    ("mio", "1st fight"): "Mio211",
    ("mio", "1st fight boss"): "Mio211",
    ("mio", "2nd fight"): "Mio212",
    ("mio", "2nd fight boss"): "Mio212",
    ("gadwin", "1st fight"): "Gadwin205",
    ("gadwin", "2nd fight"): "Gadwin206",
    ("gadwin", "2nd fight boss"): "Gadwin206",
    ("massacre machine", "1st fight"): "MassacreMachine170",
    ("massacre machine", "1st fight boss"): "MassacreMachine170",
    ("massacre machine", "2nd fight"): "MassacreMachine172",
    ("massacre machine", "2nd fight boss"): "MassacreMachine172",
    ("eye", "massacre machine"): "Eye171",
    ("eye", "massacre machine boss"): "Eye171",
    ("eye", "massacre machine 2nd fight"): "Eye173",
    ("eye", "massacre machine 2nd fight boss"): "Eye173",
    ("left tentacle", "squid king"): "LeftTentacle152",
    ("right tentacle", "squid king"): "RightTentacle151",
    ("left tentacle", "leviathan"): "LeftTentacle252",
    ("right tentacle", "leviathan"): "RightTentacle251",
    ("left tentacle", "baal"): "GaiaTentacle223",
    ("left tentacle", "baal gaia tentacle"): "GaiaTentacle223",
    ("right tentacle", "baal"): "GaiaTentacle224",
    ("hot head", "serpent"): "HotHead176",
    ("hot head", "serpent boss"): "HotHead176",
    ("nice head", "serpent"): "NiceHead177",
    ("nice head", "serpent boss"): "NiceHead177",
    ("hot head", "hydra"): "HotHead181",
    ("nice head", "hydra"): "NiceHead182",
    ("madragon", "boss body"): "Madragon164",
    ("madragon", "body"): "Madragon164",
    ("madragon", "boss head"): "Madragon165",
    ("madragon", "head"): "Madragon165",
    ("lure", "grinwhale"): "Lure216",
    ("lure", "slug fish"): "Lure218",
    ("flower", "trent"): "Flower186",
    ("arm", "trent"): "Arm185",
    ("flower", "gaia trent"): "Flower189",
    ("arm", "gaia trent"): "Arm188",
    ("gaia battler", "boss"): "GaiaBattler225",
    ("gaia battler", ""): "GaiaBattler225",
    ("gaia battler", "2nd fight"): "GaiaBattler228",
    ("gaia battler", "2nd fight boss"): "GaiaBattler228",
    ("gaia battler", "3rd fight"): "GaiaBattler231",
    ("gaia battler", "3rd fight boss"): "GaiaBattler231",
    ("gaia battler", "4th fight"): "GaiaBattler234",
    ("gaia battler", "4th fight boss"): "GaiaBattler234",
    ("right hand", "gaia battler"): "RightHand226",
    ("left hand", "gaia battler"): "LeftHand227",
    ("right hand", "gaia battler 2nd fight"): "RightHand229",
    ("left hand", "gaia battler 2nd fight"): "LeftHand230",
    ("wand", "lord's ghost"): "Wand192",
    ("wand", "mage king"): "Wand195",
    ("ax", "ruin guard"): "Ax197",
    ("ax", "great susano-o"): "Ax201",
    ("baal", "1st fight"): "Baal219",
    ("baal", "1st fight boss"): "Baal219",
    ("baal", "2nd fight"): "Baal220",
    ("baal", "2nd fight boss"): "Baal220",
    ("baal", "3rd fight"): "Baal222",
    ("baal", "3rd fight boss"): "Baal222",
    ("gaia tentacle", "baal"): "GaiaTentacle221",
    ("gargoyle", "boss shell"): "Gargoyle162",
    ("gargoyle", "shell"): "Gargoyle162",
    ("gargoyle", "boss head"): "Gargoyle163",
    ("gargoyle", "head"): "Gargoyle163",
    ("phantom dragon", "boss"): "PhantomDragon167",
    ("gaia core", "boss"): "GaiaCore237",
    ("gaia core", ""): "GaiaCore237",
    ("mega gaia", "gaia core"): "MegaGaia",
    ("lord's ghost", "boss"): "LordsGhost190",
}


def norm(s: str) -> str:
    return re.sub(r"[^a-z0-9]+", "", s.lower())


def load_species() -> dict[str, str]:
    text = SPECIES_CS.read_text(encoding="utf-8")
    out: dict[str, str] = {}
    for m in re.finditer(
        r"/// <summary>([^<(]+).*?</summary>\s+(\w+)\s*=",
        text,
        re.S,
    ):
        display = m.group(1).strip()
        enum = m.group(2)
        if enum.startswith("Skip"):
            continue
        out[norm(display)] = enum
    return out


def parse_starred(token: str) -> tuple[int, int | None] | None:
    """Return (redux, vanilla_or_none) if token is a starred change."""
    t = token.strip().rstrip(".,;a")
    t = t.replace("?", "")
    if "*" not in t:
        return None
    # *10(30)
    m = re.fullmatch(r"\*\s*(\d+)\s*\(\s*(\d+)\s*\)", t)
    if m:
        return int(m.group(1)), int(m.group(2))
    # 48*(32)
    m = re.fullmatch(r"(\d+)\s*\*\s*\(\s*(\d+)\s*\)", t)
    if m:
        return int(m.group(1)), int(m.group(2))
    # 6(*5)
    m = re.fullmatch(r"(\d+)\s*\(\s*\*\s*(\d+)\s*\)", t)
    if m:
        return int(m.group(1)), int(m.group(2))
    # (0)*2000  -> redux 0, vanilla 2000
    m = re.fullmatch(r"\(\s*(\d+)\s*\)\s*\*\s*(\d+)", t)
    if m:
        return int(m.group(1)), int(m.group(2))
    # 163*145)  typo
    m = re.fullmatch(r"(\d+)\s*\*\s*(\d+)\)?", t)
    if m:
        return int(m.group(1)), int(m.group(2))
    # 2*
    m = re.fullmatch(r"(\d+)\s*\*", t)
    if m:
        return int(m.group(1)), None
    # *(32)
    m = re.fullmatch(r"\*\s*\(\s*(\d+)\s*\)", t)
    if m:
        return None
    return None


def parse_starred_word(token: str) -> tuple[str, str | None] | None:
    t = token.strip().rstrip(".,;")
    if "*" not in t:
        return None
    m = re.fullmatch(r"([A-Za-z/]+)\s*\*\s*\(\s*([A-Za-z/]+)\s*\)", t)
    if m:
        return m.group(1), m.group(2)
    m = re.fullmatch(r"([A-Za-z/]+)\s*\*", t)
    if m:
        return m.group(1), None
    return None


def starred_after(label: str, block: str) -> tuple[int, int | None] | None:
    # Allow optional colon and junk before the value token
    m = re.search(
        rf"(?:^|[\s\[]){label}\s*:?\s*(\S+)",
        block,
        re.I,
    )
    if not m:
        return None
    return parse_starred(m.group(1))


def element_of(token: str) -> str | None:
    t = token.strip().rstrip(".,;").lower()
    t = t.replace("*", "")
    t = re.sub(r"\(.*", "", t).strip()
    return {
        "n/a": "None",
        "na": "None",
        "none": "None",
        "fire": "Fire",
        "water": "Water",
        "wind": "Wind",
        "earth": "Earth",
        "lightning": "Thunder",
        "thunder": "Thunder",
        "ice": "Ice",
        "explosion": "Explosion",
        "forest": "Forest",
    }.get(t)


def strength_of(token: str) -> bool | None:
    t = token.strip().split("*")[0].strip().rstrip(".,;").lower()
    if t == "yes":
        return True
    if t == "no":
        return False
    return None


def split_blocks(text: str) -> list[tuple[str, str, str]]:
    """[(title, qualifier, body), ...]"""
    # Drop the page title line prefix
    text = re.sub(r"^ReDux 3\.0: Enemy Info\s*", "", text)
    parts = re.split(r"\[([^\]]+)\]", text)
    out = []
    for i in range(1, len(parts), 2):
        title = parts[i].strip()
        rest = parts[i + 1] if i + 1 < len(parts) else ""
        quals = []
        while True:
            m = re.match(r"\(([^)]+)\)", rest.lstrip())
            if not m:
                break
            quals.append(m.group(1).strip())
            rest = rest.lstrip()[m.end() :]
        # body until next [ is already split
        body = rest
        # cut at ---- separators leftover
        body = re.split(r"-{10,}", body, maxsplit=1)[0]
        out.append((title, " ".join(quals), body.strip()))
    return out


def clean_skill_name(raw: str) -> str:
    raw = raw.strip()
    if ">" in raw:
        raw = raw.split(">")[0].strip()
    raw = re.sub(r"^.*\bNote:\s*", "", raw, flags=re.I)
    words = re.findall(r"[A-Za-z0-9][A-Za-z0-9'./!\-]*", raw)
    kept: list[str] = []
    for w in words:
        if w.isdigit() or w.lower() in NAME_JUNK:
            kept = []
            continue
        kept.append(w)
    return re.sub(r"\s+", " ", " ".join(kept)).strip()


def skill_chunks(block: str) -> list[dict]:
    skills = []
    for m in re.finditer(
        r"Power:\s*(\S+)\s+Element:\s*(\S+)\s+Strength:\s*(\S+)\s+Speed:\s*(\S+)",
        block,
        re.I,
    ):
        before = block[max(0, m.start() - 60) : m.start()]
        name = clean_skill_name(before)
        if not name or name.lower() in NAME_JUNK:
            continue
        skills.append(
            {
                "name": name,
                "power": parse_starred(m.group(1)),
                "element": parse_starred_word(m.group(2)),
                "strength": parse_starred_word(m.group(3)),
                "speed": parse_starred(m.group(4)),
            }
        )
    return skills


def resolve_species(title: str, qual: str, species_by_name: dict[str, str]) -> str | None:
    qn = re.sub(r"\s+", " ", qual.lower())
    qn = qn.replace("peril head", "").replace("?", "").strip()
    key = (title.lower(), qn)
    if key in MANUAL:
        return MANUAL[key]
    # try stripping boss
    q2 = qn.replace("boss", "").strip()
    if (title.lower(), q2) in MANUAL:
        return MANUAL[(title.lower(), q2)]
    # unique display name
    n = norm(title)
    if n in species_by_name:
        return species_by_name[n]
    aliases = {
        "healthweed": None,
        "sourmoth": "DizzyMoth",
        "desertlord": "Scissorlock",
        "sadhead": "PerilHead",
        "gaiaminion": "GigaGaia",
        "greatsusanoo": "GreatSusanoO",
        "lordsghost": "LordsGhost190",
        "willowisp": "WillOWisp",
    }
    if n in aliases and aliases[n]:
        return aliases[n]
    # Gaia Battler 3rd/4th hands: qualifier is just "Gaia Battler" after first
    # Already handled if 2nd fight is in qual.
    return None


def csharp_int(field: str, pair: tuple[int, int | None] | None, indent: str) -> str:
    if pair is None:
        return ""
    val, vanilla = pair
    comment = f" // vanilla {vanilla}" if vanilla is not None else ""
    return f"{indent}{field} = {val},{comment}\n"


def csharp_skill(sk: dict, indent: str) -> str:
    parts = []
    if sk["power"]:
        v, vanilla = sk["power"]
        c = f" // vanilla {vanilla}" if vanilla is not None else ""
        parts.append(f"{indent}    Power = {v},{c}")
    if sk["speed"]:
        v, vanilla = sk["speed"]
        c = f" // vanilla {vanilla}" if vanilla is not None else ""
        parts.append(f"{indent}    Speed = {v},{c}")
    if sk["strength"]:
        word, vanilla = sk["strength"]
        b = strength_of(word)
        if b is not None:
            c = f" // vanilla {vanilla}" if vanilla else ""
            parts.append(f"{indent}    Strength = {str(b).lower()},{c}")
    if sk["element"]:
        word, vanilla = sk["element"]
        el = element_of(word)
        if el:
            c = f" // vanilla {vanilla}" if vanilla else ""
            parts.append(f"{indent}    Element = CombatElement.{el},{c}")
    if not parts:
        return ""
    name = sk["name"].replace('"', '\\"')
    inner = "\n".join(parts)
    return (
        f"{indent}new SkillChange\n"
        f"{indent}{{\n"
        f'{indent}    Name = "{name}",\n'
        f"{inner}\n"
        f"{indent}}}"
    )


FILE_SPLITS = [
    ("01_Early.cs", "Early", 0, 45),
    ("02_Mid.cs", "Mid", 45, 90),
    ("03_Late.cs", "Late", 90, 140),
    ("04_Gaia.cs", "Gaia", 140, 999),
]


def emit_edit(e: dict) -> str:
    lines = ["        new()\n        {\n"]
    lines.append(f"            Species = Species.{e['species']},\n")
    note = e["title"]
    if e["qual"]:
        note += f" ({e['qual']})"
    lines.append(f'            Note = "{note.replace(chr(34), "")}",\n')
    if e.get("when"):
        lines.append(f"            When = {e['when']},\n")
    body = e["body"]
    mapping = [
        ("Level", ["LV", "Level"]),
        ("MaxHp", ["HP"]),
        ("Str", ["Str"]),
        ("Vit", ["Vit"]),
        ("Wit", ["Wit"]),
        ("Agi", ["Agi"]),
        ("Exp", ["Exp"]),
        ("Gold", ["GP"]),
        ("AttackCount", [r"# of Attacks", "Attacks"]),
        ("AttackRange", ["Range"]),
        ("FireResist", ["Fire"]),
        ("WaterResist", ["Water"]),
        ("WindResist", ["Wind"]),
        ("EarthResist", ["Earth"]),
    ]
    # Resist labels appear twice (skill element + resist). Prefer the Resistances section.
    resist_src = body
    rm = re.search(r"Resistances?:?\s*(.*)$", body, re.I | re.S)
    # Also some late entries omit the word Resistances and just list Fire:
    for field, labels in mapping:
        src = body
        if field.endswith("Resist"):
            val = None
            for lab in labels:
                # Colon required so "Fire Time" is not read as a resist.
                found = list(re.finditer(rf"(?:^|[\s:]){lab}\s*:\s*(\S+)", body, re.I))
                if found:
                    val = parse_starred(found[-1].group(1))
            lines.append(csharp_int(field, val, "            "))
            continue
        val = None
        for lab in labels:
            val = starred_after(lab, src)
            if val:
                break
        lines.append(csharp_int(field, val, "            "))

    skill_cs = []
    for sk in skill_chunks(body):
        chunk = csharp_skill(sk, "                ")
        if chunk:
            skill_cs.append(chunk)
    if skill_cs:
        lines.append("            Skills =\n            [\n")
        lines.append(",\n".join(skill_cs))
        lines.append("\n            ],\n")
    lines.append("        }")
    return "".join(lines)


def has_changes(text: str) -> bool:
    return "new()" in text and any(
        x in text
        for x in (
            "MaxHp",
            "Level =",
            "Str =",
            "Vit =",
            "Wit =",
            "Agi =",
            "Exp =",
            "Gold =",
            "Attack",
            "Resist",
            "Skills =",
        )
    )


def main() -> None:
    species = load_species()
    raw = BLOG.read_text(encoding="utf-8")
    # flatten to one line already
    blocks = split_blocks(raw)
    edits = []
    unmatched = []
    seen = set()
    gaia_hands = {"right hand": 0, "left hand": 0}
    gaia_hand_ids = {
        "right hand": {1: "RightHand226", 2: "RightHand232", 3: "RightHand235"},
        "left hand": {1: "LeftHand227", 2: "LeftHand233", 3: "LeftHand236"},
    }
    for title, qual, body in blocks:
        if title.lower() in {"redux 3.0: enemy info"}:
            continue
        tl = title.lower()
        ql = qual.lower()
        if tl in gaia_hands and "gaia battler" in ql and "2nd" not in ql:
            gaia_hands[tl] += 1
            sp = gaia_hand_ids[tl].get(gaia_hands[tl])
        else:
            sp = resolve_species(title, qual, species)
        if not sp:
            unmatched.append((title, qual))
            continue
        key = (sp, qual.lower(), title.lower())
        # Gaia Brain is listed twice (Lv 80 and Lv 99) under the same heading.
        if key in seen and sp != "GaiaBrain":
            continue
        seen.add(key)
        rec = {
            "species": sp,
            "title": title,
            "qual": qual,
            "body": body,
        }
        # Gaia Brain appears twice (Lv 80 / 99)
        if sp == "GaiaBrain":
            if re.search(r"Level\s+99", body):
                rec["when"] = "e => e.Level >= 90"
            elif re.search(r"Level\s+80", body):
                rec["when"] = "e => e.Level <= 85"
        edits.append(rec)

    OUT.mkdir(exist_ok=True)
    rendered = [emit_edit(e) for e in edits]
    kept = []
    for e, text in zip(edits, rendered):
        if has_changes(text):
            kept.append((e, text))

    # write helper + book + split files
    (OUT / "EnemyEdit.cs").write_text(ENEMY_EDIT_CS, encoding="utf-8")

    for fname, cls, a, b in FILE_SPLITS:
        chunk = kept[a:b]
        if not chunk:
            continue
        items = ",\n".join(t for _, t in chunk)
        src = f"""using Grandia.Sdk;

namespace GrandiaRedux.Enemies;

/// <summary>
/// Starred ReDux 3.0 values from
/// https://grandiaredux.blogspot.com/p/enemy-info.html
/// Only fields marked * on that page are set; everything else stays vanilla.
/// </summary>
internal static class {cls}
{{
    internal static readonly EnemyEdit[] All =
    [
{items}
    ];
}}
"""
        (OUT / fname).write_text(src, encoding="utf-8")

    book = """using Grandia.Sdk;

namespace GrandiaRedux.Enemies;

/// <summary>
/// Looks up the ReDux patch for the loaded species and applies it.
/// Rematches (Saki 1st/2nd, Gaia Battler 1–4, …) use distinct <see cref="Species"/> ids.
/// Gaia Brain has two pages (Lv 80 / 99) distinguished by <see cref="EnemyEdit.When"/>.
/// </summary>
internal static class EnemyBook
{
    private static readonly EnemyEdit[] All =
    [
        ..Early.All,
        ..Mid.All,
        ..Late.All,
        ..Gaia.All,
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

    print(f"kept {len(kept)} / parsed {len(edits)}")
    print("unmatched:")
    for t, q in unmatched:
        print(f"  [{t}] ({q})")


ENEMY_EDIT_CS = r'''using Grandia.Sdk;

namespace GrandiaRedux.Enemies;

/// <summary>
/// One enemy's ReDux changes. Leave a field null to keep the vanilla value.
/// </summary>
internal sealed class EnemyEdit
{
    public required Species Species { get; init; }

    /// <summary>Blog heading, for searching the file.</summary>
    public string Note { get; init; } = "";

    /// <summary>
    /// Optional extra match (vanilla values, before this patch writes).
    /// Used when two blog rows share a <see cref="Species"/>.
    /// </summary>
    public Func<EnemyLoadedEvent, bool>? When { get; init; }

    public int? Level { get; init; }
    public int? MaxHp { get; init; }
    public int? Str { get; init; }
    public int? Vit { get; init; }
    public int? Wit { get; init; }
    public int? Agi { get; init; }
    public int? Exp { get; init; }
    public int? Gold { get; init; }
    public int? AttackCount { get; init; }
    public int? AttackRange { get; init; }
    public int? FireResist { get; init; }
    public int? WaterResist { get; init; }
    public int? WindResist { get; init; }
    public int? EarthResist { get; init; }

    public SkillChange[] Skills { get; init; } = [];

    public bool Matches(EnemyLoadedEvent e)
    {
        if (e.Species != Species)
        {
            return false;
        }

        return When is null || When(e);
    }

    public void Apply(EnemyLoadedEvent e)
    {
        if (Level is int level)
        {
            e.Level = level;
        }

        if (MaxHp is int hp)
        {
            e.MaxHp = hp;
            e.Hp = hp;
        }

        if (Str is int str)
        {
            e.Str = str;
        }

        if (Vit is int vit)
        {
            e.Vit = vit;
        }

        if (Wit is int wit)
        {
            e.Wit = wit;
        }

        if (Agi is int agi)
        {
            e.Agi = agi;
        }

        if (Exp is int exp)
        {
            e.Exp = exp;
        }

        if (Gold is int gold)
        {
            e.Gold = gold;
        }

        if (AttackCount is int attacks)
        {
            e.AttackCount = attacks;
        }

        if (AttackRange is int range)
        {
            e.AttackRange = range;
        }

        if (FireResist is int fire)
        {
            e.FireResist = fire;
        }

        if (WaterResist is int water)
        {
            e.WaterResist = water;
        }

        if (WindResist is int wind)
        {
            e.WindResist = wind;
        }

        if (EarthResist is int earth)
        {
            e.EarthResist = earth;
        }

        foreach (var change in Skills)
        {
            change.Apply(e);
        }
    }
}

/// <summary>
/// Edits an existing skill by name. New skill slots are ignored by the runtime.
/// </summary>
internal sealed class SkillChange
{
    public required string Name { get; init; }
    public int? Power { get; init; }
    public int? Speed { get; init; }
    public bool? Strength { get; init; }
    public CombatElement? Element { get; init; }

    public void Apply(EnemyLoadedEvent e)
    {
        var skill = Find(e);
        if (skill is null)
        {
            return;
        }

        if (Power is int power)
        {
            skill.Power = power;
        }

        if (Speed is int speed)
        {
            skill.Speed = speed;
        }

        if (Strength is bool strength)
        {
            skill.Strength = strength;
        }

        if (Element is CombatElement element)
        {
            skill.Combat = element;
        }
    }

    private EnemySkill? Find(EnemyLoadedEvent e)
    {
        var want = Norm(Name);
        foreach (var skill in e.Skills)
        {
            if (Norm(skill.Name) == want)
            {
                return skill;
            }
        }

        foreach (var skill in e.Skills)
        {
            var have = Norm(skill.Name);
            if (want.Length >= 4 && have.Length >= 4 && (have.Contains(want) || want.Contains(have)))
            {
                return skill;
            }
        }

        return null;
    }

    private static string Norm(string name)
    {
        return string.Concat(name.Where(char.IsLetterOrDigit)).ToLowerInvariant();
    }
}
'''


if __name__ == "__main__":
    main()
