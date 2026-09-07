using Grandia.Sdk;

namespace GrandiaRedux.Magic;

/// <summary>
/// Applies the Redux WINDT spell / move delta. Re-run on every
/// <see cref="MagicEvent"/> — the game recopies vanilla tables each load.
/// 0.4.9 WINDT is disc 2; disc 1 uses <see cref="Disc1"/> while flag 289
/// (last story flag before the PS1 CD2 swap) is clear.
/// </summary>
internal static class MagicBook
{
    /// <summary>PS1 “about to enter disc 2” story flag.</summary>
    internal const uint Disc2Flag = 289;

    private static readonly MagicEdit[] All =
    [
        ..Spells.All,
        ..Moves.All,
    ];

    private static bool? _lastDisc2;

    internal static bool IsDisc2 => Game.Flags.IsSet(Disc2Flag);

    public static void Apply(MagicEvent e)
    {
        var disc2 = IsDisc2;
        if (_lastDisc2 != disc2)
        {
            _lastDisc2 = disc2;
            Game.Log.Info(disc2 ? "Magic disc 2 (flag 289 set)" : "Magic disc 1 (flag 289 clear)");
        }

        foreach (var edit in All)
        {
            if (edit.Matches(e))
            {
                edit.Apply(e);
                break;
            }
        }

        if (IsDisc2)
        {
            return;
        }

        foreach (var edit in Disc1.All)
        {
            if (edit.Matches(e))
            {
                edit.Apply(e);
                return;
            }
        }
    }
}
