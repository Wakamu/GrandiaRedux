using Grandia.Sdk;
using GrandiaRedux.Items;

namespace GrandiaRedux.Shops;

/// <summary>
/// Applies the Redux MDP sec[10] shop-stock delta. Re-run on every
/// <see cref="ShopOpenEvent"/> — the live field-params copy is vanilla
/// until this writes it back.
/// </summary>
internal static class ShopBook
{
    private static readonly ShopEdit[] All = Stock.All;

    public static void Apply(ShopOpenEvent e)
    {
        if (e.Kind != ShopKind.Buy)
        {
            return;
        }

        foreach (var edit in All)
        {
            if (edit.Matches(e))
            {
                edit.Apply(e);
                break;
            }
        }

        // Session gold must be set here. OnShopOpen runs before WINDT
        // finalize / OnItem, and the host used to treat a missing price
        // as 0 — first Parm open sold Rusty Knife (Lump of Coal) for 0.
        ApplyPrices(e);
    }

    private static void ApplyPrices(ShopOpenEvent e)
    {
        ApplyPage(e, e.Weapons);
        ApplyPage(e, e.Armor);
        ApplyPage(e, e.Goods);
    }

    private static void ApplyPage(ShopOpenEvent e, List<Item> page)
    {
        foreach (var item in page)
        {
            if (ItemBook.TryCost(item, out var gold))
            {
                e.SetPrice(item, gold);
            }
        }
    }
}
