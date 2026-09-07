using Grandia.Sdk;

namespace GrandiaRedux.Shops;

/// <summary>
/// One map's shop stock. Leave a page null to keep vanilla.
/// Applied on <see cref="ShopKind.Buy"/> only.
/// </summary>
internal sealed class ShopEdit
{
    public required ushort Map { get; init; }

    public string Note { get; init; } = "";

    public Item[]? Weapons { get; init; }
    public Item[]? Armor { get; init; }
    public Item[]? Goods { get; init; }

    public bool Matches(ShopOpenEvent e) =>
        e.Kind == ShopKind.Buy && e.Map.Value == Map;

    public void Apply(ShopOpenEvent e)
    {
        Replace(e.Weapons, Weapons);
        Replace(e.Armor, Armor);
        Replace(e.Goods, Goods);
    }

    private static void Replace(List<Item> dest, Item[]? src)
    {
        if (src is null)
        {
            return;
        }

        dest.Clear();
        dest.AddRange(src);
    }
}
