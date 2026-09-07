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
}
