using Grandia.Sdk;

namespace GrandiaRedux.Items;

/// <summary>
/// WINDT sec3 rows from id 384 that differ between HD Remaster
/// FIELD/WINDT.BIN and Redux 0.4.9. Unlisted fields stay vanilla.
/// Names / leftover sec3 bytes apply through OnItem (TEXT1 + WINDT).
/// </summary>
internal static class Ids384
{
    internal static readonly ItemEdit[] All =
    [
        new()
        {
            Id = Item.ManaEgg,
            Note = "Mana Egg",
            Cost = 8000, // vanilla 3000
        },
        new()
        {
            Id = Item.HolyFire,
            Note = "Holy Fire",
            Effect = Skill.Burn, // vanilla Skill.Howl
        },
        new()
        {
            Id = Item.LaunchFireworks,
            Note = "Launch Fireworks",
            Cost = 500, // vanilla 1200
        },
        new()
        {
            Id = Item.GaleScroll,
            Note = "Gale Scroll",
            Cost = 350, // vanilla 480
        },
        new()
        {
            Id = Item.OverflowingWalnut,
            Note = "Overflowing Walnut",
            Cost = 600, // vanilla 3000
            EffectValue = 3, // vanilla 2
            Description = "+3 attack level for 1 friend", // vanilla "+2 attack level for 1 friend"
        },
        new()
        {
            Id = Item.RestraintWalnut,
            Note = "Restraint Walnut",
            Cost = 600, // vanilla 2800
            EffectValue = 1, // vanilla 2
            Description = "+1 def level for whole party ", // vanilla "+2 defense level for entire party"
        },
        new()
        {
            Id = Item.SonicWalnut,
            Note = "Sonic Walnut",
            Cost = 600, // vanilla 1400
            EffectValue = 1, // vanilla 2
            Description = "+1 action level for 1 friend", // vanilla "+2 action level for 1 friend"
        },
        new()
        {
            Id = Item.RunningWalnut,
            Note = "Walnut of Mist",
            Cost = 600, // vanilla 700
            EffectValue = 4, // vanilla 2
            ShortName = "MST NUT", // vanilla "RUN NUT"
            Name = "Walnut of Mist", // vanilla "Running Walnut"
            Description = "Warp effect for friends in range", // vanilla "+2 move for one and +1 move for some"
        },
        new()
        {
            Id = Item.TrudgeWeed,
            Note = "Trudge Weed",
            Cost = 1500, // vanilla 150
            Effect = Skill.Cold, // vanilla Skill.Freeze
            Description = "-3 to action level of 1 enemy    ", // vanilla "-2 to move level of all enemies"
        },
        new()
        {
            Id = Item.FreesiaFlowers,
            Note = "Freesia Flowers",
            Cost = 300, // vanilla 500
            UseStatus = 49408, // vanilla 57600
            EffectValue = 18, // vanilla 8
            Description = "Restores 20 lv 3 MP  Combat only ", // vanilla "Restores 8 level 3 MP to 1 friend"
        },
        new()
        {
            Id = Item.ConeOfLight,
            Note = "Cone of Light",
            Cost = 12000, // vanilla 4000
        },
        new()
        {
            Id = Item.MikeromaScroll,
            Note = "Mikeroma Scroll",
            Cost = 280, // vanilla 450
        },
        new()
        {
            Id = Item.MiracleDrink,
            Note = "Miracle Drink",
            EffectValue = 10, // vanilla 5
            Description = "Restores 10 MP(all levels) to party", // vanilla "Restores 5 MP (all levels) to party"
        },
        new()
        {
            Id = Item.PrettyJewel,
            Note = "Pretty Jewel",
            Icon = 62, // vanilla 46
        },
        new()
        {
            Id = Item.PrettyJewel435,
            Note = "Pretty Jewel",
            Icon = 62, // vanilla 46
        },
        new()
        {
            Id = Item.PrettyJewel436,
            Note = "Pretty Jewel",
            Icon = 62, // vanilla 46
        },
        new()
        {
            Id = Item.ResurrectPotion441,
            Note = "Resurrect Potion",
            Cost = 1200, // vanilla 3000
        },
        new()
        {
            Id = Item.ExpensiveJewel,
            Note = "Expensive Jewel",
            Description = "Very valuable jewel", // vanilla "Very valuable jewel  No effects"
        },
        new()
        {
            Id = Item.SmokedSalmon,
            Note = "Smoked Salmon",
            EffectValue = 150, // vanilla 75
            Description = "Restores 150 HP  Laine's delicacy", // vanilla "Restores 75 HP to 1 friend  Tasty"
        },
        new()
        {
            Id = Item.PrimeRib,
            Note = "Superb   ",
            Cost = 600, // vanilla 1000
            Icon = 50, // vanilla 52
            EffectValue = 200, // vanilla 150
            ShortName = "SUPERB  ", // vanilla "PRIMERIB"
            Name = "Superb   ", // vanilla "Prime Rib"
            Description = "Restores 200 HP  Super Herb", // vanilla "Restores 150 HP to 1 friend  Tasty"
        },
        new()
        {
            Id = Item.RescueSet,
            Note = "Rescue Set",
            EffectValue = 80, // vanilla 120
            Description = "Restores 80 HP to entire party ", // vanilla "Restores 120 HP to entire party"
        },
        new()
        {
            Id = Item.BlackNailPolish,
            Note = "Black Nail Polish",
            Cost = 1500, // vanilla 800
            EffectValue = 5, // vanilla 7
            Description = "+5 attack level for 1 friend", // vanilla "+3 attack level for 1 friend"
        },
        new()
        {
            Id = Item.SpiritWhip,
            Note = "Spirit Whip",
            Cost = 50000, // vanilla 0
            Icon = 31, // vanilla 0
            UseStatus = 34929, // vanilla 0
            Unknown7 = 2, // vanilla 0
            Unknown8 = 5, // vanilla 0
            Unknown27 = 7, // vanilla 0
            Para2 = 3, // vanilla 0
            Para3 = 19, // vanilla 0
            Para1Post = 12809, // vanilla 0
            Para2Post = 1024, // vanilla 0
            Para4Post = 5122, // vanilla 0
            ShortName = "SPT WHIP", // vanilla "PROHIBIT"
            Name = "Spirit Whip", // vanilla "Prohibited"
            Description = "+50 action  +4 magic  Blessed", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.ThorsFury,
            Note = "Thors Fury",
            Name = "Thors Fury", // vanilla "Thor's Fury"
        },
        new()
        {
            Id = Item.MagicLipstick,
            Note = "Magic Lipstick",
            Cost = 4000, // vanilla 800
            EffectValue = 5, // vanilla 7
            Description = "+5 action level for 1 friend", // vanilla "+3 action level for 1 friend"
        },
        new()
        {
            Id = Item.EliteBadge,
            Note = "Elite Badge",
            Cost = 13000, // vanilla 15000
            Para1Post = 8960, // vanilla 8448
            Description = "+35 action  Has two stars", // vanilla "+33 action  Has two stars"
        },
        new()
        {
            Id = Item.RingOfRage,
            Note = "Ring of Rage",
            Para1Post = 1280, // vanilla 768
            Description = "Restores +5 SP with damage  ", // vanilla "Restores many SP with damage"
        },
        new()
        {
            Id = Item.HolyRing,
            Note = "Holy Ring",
            Unknown7 = 128, // vanilla 255
            Unknown13 = 22, // vanilla 0
            Para2 = 0, // vanilla 2
            Para3 = 0, // vanilla 33
            Para1Post = 0, // vanilla 2560
            Para2Post = 0, // vanilla 512
            Description = "Doubles magic EXP  Liete's guidance ", // vanilla "+10 defense  +2 all magic resistance"
        },
        new()
        {
            Id = Item.MysteriousVeil,
            Note = "Mysterious Veil",
            Cost = 20000, // vanilla 10000
        },
        new()
        {
            Id = Item.BlizzardScroll,
            Note = "Blizzard Scroll",
            Cost = 2000, // vanilla 1600
            EffectValue = 215, // vanilla 24
            Unknown11 = 0, // vanilla 1
            Description = "220 HP blizzard attack on all enemies", // vanilla "280 HP blizzard attack on all enemies"
        },
        new()
        {
            Id = Item.EnergyCharm,
            Note = "Energy Charm",
            Unknown14 = 65, // vanilla 50
            Description = "Lowers SP cost by one third", // vanilla "Halves SP usage"
        },
        new()
        {
            Id = Item.DevilsAnklet,
            Note = "Ancient Tablet",
            Icon = 47, // vanilla 46
            Unknown7 = 128, // vanilla 255
            Unknown13 = 28, // vanilla 0
            Unknown14 = 25, // vanilla 0
            Para3 = 2, // vanilla 0
            Para4 = 36, // vanilla 0
            Para1Post = 256, // vanilla 1792
            Para2Post = 2560, // vanilla 0
            Para3Post = 256, // vanilla 0
            ShortName = "TABLET   ", // vanilla "DEVIL ANK"
            Name = "Ancient Tablet", // vanilla "Devil's Anklet"
            Description = "+1 magic  +10 defense  Dated", // vanilla "+7 magic power level"
        },
        new()
        {
            Id = Item.AstralMiracle,
            Note = "Astral Miracle",
            Icon = 46, // vanilla 62
            Description = "Doubles weapon EXP  Golden", // vanilla "Doubles weapon skill exp. points"
        },
        new()
        {
            Id = Item.EtherealMiracle,
            Note = "Ethereal Miracle",
            Icon = 46, // vanilla 62
            Description = "Doubles magic EXP  Silver ", // vanilla "Doubles magic skill exp. points"
        },
        new()
        {
            Id = Item.MiraculousScales,
            Note = "Miraculous Scales",
            Cost = 30000, // vanilla 60000
        },
        new()
        {
            Id = Item.GeneralsStaff,
            Note = "General's Staff",
            Para1Post = 14857, // vanilla 14089
            Description = "+58 attack  Restores HP in attacks", // vanilla "+55 attack  Restores HP in attacks"
        },
        new()
        {
            Id = Item.EmperorsWhip,
            Note = "Emperor's Whip",
            Para1Post = 15625, // vanilla 13577
            Description = "+61 attack  +2 skill power      ", // vanilla "+53 attack  +2 moves power level"
        }
    ];
}
