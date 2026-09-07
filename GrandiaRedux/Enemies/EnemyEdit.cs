using Grandia.Sdk;

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
    public Item? DropItem0 { get; init; }
    public int? DropRate0 { get; init; }
    public Item? DropItem1 { get; init; }
    public int? DropRate1 { get; init; }

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

        if (DropItem0 is Item drop0)
        {
            e.Drops[0].Item = drop0;
        }

        if (DropRate0 is int rate0)
        {
            e.Drops[0].Rate = rate0;
        }

        if (DropItem1 is Item drop1)
        {
            e.Drops[1].Item = drop1;
        }

        if (DropRate1 is int rate1)
        {
            e.Drops[1].Rate = rate1;
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
    public EffectType? Effect { get; init; }
    public int? Mode { get; init; }
    public StatusAilment? AddAilment { get; init; }
    public int? Chance { get; init; }
    public int? AddLevel { get; init; }

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

        if (Effect is EffectType effect)
        {
            skill.Effect = effect;
        }

        if (Mode is int mode)
        {
            skill.Mode = mode;
        }

        if (AddAilment is StatusAilment add)
        {
            skill.AddAilment = add;
        }

        if (Chance is int chance)
        {
            skill.Chance = chance;
        }

        if (AddLevel is int addLevel)
        {
            skill.AddLevel = addLevel;
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
