using Grandia.Sdk;

namespace GrandiaRedux.Items;

/// <summary>
/// Applies the Redux WINDT sec3 catalog delta. Re-run on every
/// <see cref="ItemEvent"/> — the game recopies vanilla WINDT each
/// status / shop / stash load.
/// </summary>
internal static class ItemBook
{
    private static readonly ItemEdit[] All =
    [
        ..Ids001.All,
        ..Ids128.All,
        ..Ids256.All,
        ..Ids384.All,
    ];

    public static void Apply(ItemEvent e)
    {
        foreach (var edit in All)
        {
            if (edit.Matches(e))
            {
                edit.Apply(e);
                if (e.Id == Item.RustyKnife && Game.Flags.IsSet(289))
                {
                    e.Cost = 50000;
                    e.SellPrice = 25000;
                }
                return;
            }
        }
    }

    public static bool TryCost(Item id, out int cost)
    {
        foreach (var edit in All)
        {
            if (edit.Id == id && edit.Cost is int gold)
            {
                cost = gold;
                return true;
            }
        }

        cost = 0;
        return false;
    }
}
