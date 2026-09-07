using Grandia.Sdk;
using GrandiaRedux.Enemies;
using GrandiaRedux.Items;
using GrandiaRedux.Magic;
using GrandiaRedux.Shops;

[Mod("GrandiaRedux", "1.0.0", Description = "Grandia Redux for Grandia HD Remaster")]
public sealed class Plugin
{
    [Init]
    public void Init(ModContext ctx)
    {
    }

    [OnEnemyLoaded]
    public void OnEnemyLoaded(EnemyLoadedEvent e)
    {
        EnemyBook.Apply(e);
    }

    [OnMagic]
    public void OnMagic(MagicEvent e)
    {
        MagicBook.Apply(e);
    }

    [OnShopOpen]
    public void OnShopOpen(ShopOpenEvent e)
    {
        ShopBook.Apply(e);
    }

    [OnItem]
    public void OnItem(ItemEvent e)
    {
        ItemBook.Apply(e);
    }

    [OnScriptExecute]
    public void OnScript(ScriptExecuteEvent e)
    {
        if (e.Map.Value == 0x2C00 && e.ScriptId == 0xE000)
        {
            Game.Log.Info(e.Script.ToAsm());
            e.Script.Replace("""
                say type1
                  [menu]* * Save Game * *
                  * *  Recover  * *
                  * *   Redux   * *
                  * *  Cancel   * *[wait]
                flag_ctx_begin
                branch word=0x4C40 arg=0x4000 extra=0000
                flag_ctx_end
                jump L0000
                save_menu
                yield
                label L0000
                flag_ctx_begin
                branch word=0x4C40 arg=0x4000 extra=0100
                flag_ctx_end
                jump L0001
                restore
                sfx recover
                wait 23
                yield
                label L0001
                flag_ctx_begin
                branch word=0x4C40 arg=0x4000 extra=0200
                flag_ctx_end
                jump L0002
                say type1
                        * *   Grandia Redux   * *[wait][clear]This is the port of the original
                  Grandia Redux mod for Grandia HD
                  Remaster[wait][clear]Please report any feedback to the
                  Mod's Github page.[wait][clear]Enjoy your playthrough![wait]
                yield
                label L0002
                yield
                """);
        }
    }
}
