using Grandia.Sdk;

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
