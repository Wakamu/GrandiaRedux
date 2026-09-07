using Grandia.Sdk;

namespace GrandiaRedux.Magic;

/// <summary>
/// One party spell or weapon move. Leave a field null to keep vanilla.
/// </summary>
internal sealed class MagicEdit
{
    public required Skill Id { get; init; }

    public string Note { get; init; } = "";

    public int? Power { get; init; }
    public int? Cost { get; init; }
    public int? Speed { get; init; }
    public int? IpCost { get; init; }
    public int? IpKnockback { get; init; }
    public int? Exp { get; init; }
    public int? Range { get; init; }
    public int? Radius { get; init; }
    public int? Distance { get; init; }
    public int? CancelChance { get; init; }
    public int? CriticalChance { get; init; }
    public int? CharacterMask { get; init; }
    public CombatElement? Combat { get; init; }
    public MagicElement? Element { get; init; }
    public EffectType? Effect { get; init; }
    public int? Mode { get; init; }
    public LearnRequirement[]? Requirements { get; init; }

    public bool Matches(MagicEvent e) => e.Id == Id;

    public void Apply(MagicEvent e)
    {
        if (Power is int power)
        {
            e.Power = power;
        }

        if (Cost is int cost)
        {
            e.Cost = cost;
        }

        if (Speed is int speed)
        {
            e.Speed = speed;
        }
        else if (IpCost is int ipCost)
        {
            e.Speed = ipCost;
        }

        if (IpKnockback is int knockback)
        {
            e.IpKnockback = knockback;
        }

        if (Exp is int exp)
        {
            e.Exp = exp;
        }
        else if (Range is int range)
        {
            e.Exp = range;
        }

        if (Radius is int radius)
        {
            e.Radius = radius;
        }

        if (Distance is int distance)
        {
            e.Distance = distance;
        }

        if (CancelChance is int cancel)
        {
            e.CancelChance = cancel;
        }
        else if (CriticalChance is int crit)
        {
            e.CancelChance = crit;
        }

        if (CharacterMask is int mask)
        {
            e.CharacterMask = mask;
        }

        if (Combat is CombatElement combat)
        {
            e.Combat = combat;
        }

        if (Element is MagicElement element)
        {
            e.Element = element;
        }

        if (Effect is EffectType effect)
        {
            e.Effect = effect;
        }

        if (Mode is int mode)
        {
            e.Mode = mode;
        }

        if (Requirements is { } reqs)
        {
            e.Requirements.Clear();
            e.Requirements.AddRange(reqs);
        }
    }
}
