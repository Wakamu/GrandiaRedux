using Grandia.Sdk;

namespace GrandiaRedux.Items;

/// <summary>
/// One WINDT sec3 catalog row. Leave a field null to keep vanilla.
/// Buy gold is <see cref="Cost"/>; sell follows Cost/2 unless
/// <see cref="SellPrice"/> is set.
/// </summary>
internal sealed class ItemEdit
{
    public required Item Id { get; init; }

    public string Note { get; init; } = "";

    public int? Cost { get; init; }
    public int? SellPrice { get; init; }
    public int? Icon { get; init; }
    public int? UseStatus { get; init; }
    public Skill? Effect { get; init; }
    public int? EffectValue { get; init; }
    public int? Unknown7 { get; init; }
    public int? Para1Pre { get; init; }
    public int? Para2 { get; init; }
    public int? Para3 { get; init; }
    public int? Para4 { get; init; }
    public int? Para1Post { get; init; }
    public int? Para2Post { get; init; }
    public int? Para3Post { get; init; }
    public int? Para4Post { get; init; }
    public int? Unknown8 { get; init; }
    public int? Unknown11 { get; init; }
    public int? Unknown12 { get; init; }
    public int? Unknown13 { get; init; }
    public int? Unknown14 { get; init; }
    public int? Unknown27 { get; init; }
    public string? Name { get; init; }
    public string? ShortName { get; init; }
    public string? Description { get; init; }

    public bool Matches(ItemEvent e) => e.Id == Id;

    public void Apply(ItemEvent e)
    {
        if (Cost is int cost)
        {
            e.Cost = cost;
        }

        if (SellPrice is int sell)
        {
            e.SellPrice = sell;
        }

        if (Icon is int icon)
        {
            e.Icon = icon;
        }

        if (UseStatus is int use)
        {
            e.UseStatus = use;
        }

        if (Effect is Skill effect)
        {
            e.Effect = effect;
        }

        if (EffectValue is int value)
        {
            e.EffectValue = value;
        }

        if (Unknown7 is int unknown7)
        {
            e.Unknown7 = unknown7;
        }

        if (Para1Pre is int p1pre)
        {
            e.Para1Pre = p1pre;
        }

        if (Para2 is int p2)
        {
            e.Para2 = p2;
        }

        if (Para3 is int p3)
        {
            e.Para3 = p3;
        }

        if (Para4 is int p4)
        {
            e.Para4 = p4;
        }

        if (Para1Post is int p1post)
        {
            e.Para1Post = p1post;
        }

        if (Para2Post is int p2post)
        {
            e.Para2Post = p2post;
        }

        if (Para3Post is int p3post)
        {
            e.Para3Post = p3post;
        }

        if (Para4Post is int p4post)
        {
            e.Para4Post = p4post;
        }

        if (Unknown8 is int u8)
        {
            e.Unknown8 = u8;
        }

        if (Unknown11 is int u11)
        {
            e.Unknown11 = u11;
        }

        if (Unknown12 is int u12)
        {
            e.Unknown12 = u12;
        }

        if (Unknown13 is int u13)
        {
            e.Unknown13 = u13;
        }

        if (Unknown14 is int u14)
        {
            e.Unknown14 = u14;
        }

        if (Unknown27 is int u27)
        {
            e.Unknown27 = u27;
        }

        if (Name is { } name)
        {
            e.Name = name;
        }

        if (ShortName is { } shortName)
        {
            e.ShortName = shortName;
        }

        if (Description is { } description)
        {
            e.Description = description;
        }
    }
}
