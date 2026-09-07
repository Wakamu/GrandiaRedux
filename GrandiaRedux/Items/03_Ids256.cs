using Grandia.Sdk;

namespace GrandiaRedux.Items;

/// <summary>
/// WINDT sec3 rows from id 256 that differ between HD Remaster
/// FIELD/WINDT.BIN and Redux 0.4.9. Unlisted fields stay vanilla.
/// Names / leftover sec3 bytes apply through OnItem (TEXT1 + WINDT).
/// </summary>
internal static class Ids256
{
    internal static readonly ItemEdit[] All =
    [
        new()
        {
            Id = Item.DragonBoots,
            Note = "Dragon Boots",
            Unknown7 = 127, // vanilla 255
        },
        new()
        {
            Id = Item.NinjaSandals,
            Note = "Ninja Sandals",
            Cost = 2400, // vanilla 700
            Para2Post = 12800, // vanilla 5120
            Description = "+5 defense  +50 move  ", // vanilla "+5 defense +20 move"
        },
        new()
        {
            Id = Item.Mach1Boots,
            Note = "Mach 1 Boots",
            Unknown7 = 127, // vanilla 255
        },
        new()
        {
            Id = Item.HeavyBoots,
            Note = "Heavy Boots",
            Cost = 3500, // vanilla 2000
            Para2Post = 62976, // vanilla 60416
            Description = "+10 defense  -10 move  Sturdy  ", // vanilla "+10 defense -20 move Sturdy"
        },
        new()
        {
            Id = Item.QueenHeels,
            Note = "Queen Heels",
            Cost = 9000, // vanilla 5000
        },
        new()
        {
            Id = Item.IronClogs,
            Note = "Iron Clogs",
            Cost = 4500, // vanilla 1500
        },
        new()
        {
            Id = Item.OgreBoots,
            Note = "Ogre Boots",
            Cost = 1500, // vanilla 2000
            Unknown7 = 127, // vanilla 255
            Description = "+8 defense  Demon shoes", // vanilla "+8 defense  Demon Shoes"
        },
        new()
        {
            Id = Item.RabbitShoes,
            Note = "Rabbit Shoes",
            Description = "+5 defense  +30 move   Mogay shoes", // vanilla "+5 defense +30 move Mogay shoes"
        },
        new()
        {
            Id = Item.WolfBoots,
            Note = "Wolf Boots",
            Unknown7 = 127, // vanilla 255
            Para2Post = 10240, // vanilla 2560
            Description = "+10 defense  +40 movement  Warm", // vanilla "+10 defense  +10 movement  Warm"
        },
        new()
        {
            Id = Item.LionBoots,
            Note = "Lion Boots",
            Unknown7 = 127, // vanilla 255
            Para1Post = 4608, // vanilla 6656
            Para2Post = 7680, // vanilla 4608
            Description = "+18 defense  +30 movement  A king's", // vanilla "+26 defense  +18 movement  A king's"
        },
        new()
        {
            Id = Item.BattleBoots,
            Note = "Battle Boots",
            Cost = 8000, // vanilla 4800
            Unknown7 = 127, // vanilla 255
            Para1Post = 4096, // vanilla 5120
            Description = "+16 defense  Prevents sudden death", // vanilla "+20 defense  Prevents sudden death"
        },
        new()
        {
            Id = Item.SpiritShoes,
            Note = "Spirit Shoes",
            Unknown7 = 127, // vanilla 255
            Para1Post = 5120, // vanilla 7680
            Para2Post = 10240, // vanilla 7680
            Description = "+20 defense  +40 movement  Best shoes", // vanilla "+30 defense  +30 movement  Best shoes"
        },
        new()
        {
            Id = Item.GlassSlippers,
            Note = "Glass Slippers",
            Para1Post = 5120, // vanilla 7680
            Description = "+20 action  +20 movement", // vanilla "+30 action  +20 movement  For women"
        },
        new()
        {
            Id = Item.WarpShoes,
            Note = "Warp Shoes",
            Para2 = 3, // vanilla 2
            Para1Post = 4096, // vanilla 0
            Description = "+16 action  Warp during attacks", // vanilla "Warps during attacks"
        },
        new()
        {
            Id = Item.Crampons,
            Note = "Crampons",
            Para1Post = 3584, // vanilla 4608
            Description = "+14 defense  +10 move  For walks", // vanilla "+18 defense  +10 move  For walks"
        },
        new()
        {
            Id = Item.DianasAmulet,
            Note = "Diana's Amulet",
            Effect = Skill.UnblockMagic, // vanilla (Skill)27
            Description = "Prevents move/magic blocks [Unblock]", // vanilla "Prevents move/magic blocks [Refresh]"
        },
        new()
        {
            Id = Item.HerosBadge,
            Note = "Hero's Badge",
            Para1Post = 768, // vanilla 512
            Description = "+3 action  Badge worn by Dad", // vanilla "+2 action  Badge worn by Dad"
        },
        new()
        {
            Id = Item.DemonSwordAmulet,
            Note = "Demon Sword Amulet",
            Unknown7 = 127, // vanilla 255
        },
        new()
        {
            Id = Item.BlackBelt,
            Note = "Black Belt",
            Cost = 4000, // vanilla 2400
            Para3 = 2, // vanilla 0
            Para1Post = 256, // vanilla 512
            Para2Post = 1280, // vanilla 0
            Description = "+1 skill power  +5 defense  Sturdy", // vanilla "+2 move power level  Gets stronger"
        },
        new()
        {
            Id = Item.ChainEarrings,
            Note = "Chain Earrings",
            Para1Post = 3840, // vanilla 2560
            Description = "+15 attack  +3 move block resistance", // vanilla "+10 attack  +3 move block resistance"
        },
        new()
        {
            Id = Item.TitansRing,
            Note = "Titan's Ring",
            Para1Post = 3840, // vanilla 1280
            Description = "+15 attack Has a curious design", // vanilla "+5 attack  Has a curious design"
        },
        new()
        {
            Id = Item.FireproofCape,
            Note = "Fireproof Cape",
            Cost = 3000, // vanilla 1000
            Unknown7 = 127, // vanilla 255
            Para1Post = 1024, // vanilla 512
            Description = "+4 fire resistance  Inexpensive", // vanilla "+2 fire resistance  Inexpensive"
        },
        new()
        {
            Id = Item.FireCharm,
            Note = "Fire Charm",
            Unknown7 = 127, // vanilla 255
            Para1Post = 768, // vanilla 1024
            Description = "+3 fire resistance", // vanilla "+4 fire resistance"
        },
        new()
        {
            Id = Item.WaterCharm,
            Note = "Water Charm",
            Unknown7 = 127, // vanilla 255
            Para1Post = 768, // vanilla 1024
            Description = "+3 water resistance", // vanilla "+4 water resistance"
        },
        new()
        {
            Id = Item.WindCharm,
            Note = "Wind Charm",
            Unknown7 = 127, // vanilla 255
            Para1Post = 768, // vanilla 1024
            Description = "+3 wind resistance", // vanilla "+4 wind resistance"
        },
        new()
        {
            Id = Item.EarthCharm,
            Note = "Earth Charm",
            Unknown7 = 127, // vanilla 255
            Para1Post = 768, // vanilla 1024
            Description = "+3 earth resistance", // vanilla "+4 earth resistance"
        },
        new()
        {
            Id = Item.CounterRing,
            Note = "Medic's Tool",
            Cost = 10000, // vanilla 5000
            Icon = 22, // vanilla 46
            UseStatus = 34929, // vanilla 34934
            Unknown7 = 64, // vanilla 255
            Unknown8 = 1, // vanilla 0
            Unknown13 = 0, // vanilla 30
            Unknown14 = 0, // vanilla 20
            Para1Pre = 0, // vanilla 75
            Para2 = 1, // vanilla 0
            Para3 = 10, // vanilla 0
            Para4 = 36, // vanilla 0
            Para1Post = 13577, // vanilla 0
            Para2Post = 256, // vanilla 0
            Para3Post = 512, // vanilla 0
            Para4Post = 768, // vanilla 512
            ShortName = "MEDICTOOL", // vanilla "CNTR RING"
            Name = "Medic's Tool", // vanilla "Counter Ring"
            Description = "+53 attack  +2 skill power", // vanilla "May return normal attacks"
        },
        new()
        {
            Id = Item.SecretMoveRing,
            Note = "Secret Move Ring",
            Cost = 11000, // vanilla 15000
            Para1Post = 512, // vanilla 768
            Description = "GONE              ", // vanilla "+3 move power level"
        },
        new()
        {
            Id = Item.HurricaneBelt,
            Note = "Icarian Idol  ",
            Cost = 45000, // vanilla 10000
            Icon = 47, // vanilla 46
            Unknown7 = 2, // vanilla 255
            Para3 = 4, // vanilla 0
            Para4 = 34, // vanilla 0
            Para1Post = 17920, // vanilla 12800
            Para2Post = 7680, // vanilla 0
            Para3Post = 512, // vanilla 0
            ShortName = "ICAR IDOL", // vanilla "HURC BELT"
            Name = "Icarian Idol  ", // vanilla "Hurricane Belt"
            Description = "+70 action +30 move  From Angelou", // vanilla "+50 action  Gives you storm speed"
        },
        new()
        {
            Id = Item.JadeCharm,
            Note = "Jade Charm",
            Para1Post = 1280, // vanilla 512
            Description = "+5 attack  Jade necklace", // vanilla "+2 attack  Jade necklace"
        },
        new()
        {
            Id = Item.LightGodAmulet,
            Note = "Light God Amulet",
            Unknown7 = 127, // vanilla 255
        },
        new()
        {
            Id = Item.IridescentAmulet,
            Note = "Iridescent Amulet",
            Para1Post = 2048, // vanilla 2560
            Description = "+8 defense   Rainbow colored, pretty", // vanilla "+10 defense  Rainbow colored, pretty"
        },
        new()
        {
            Id = Item.MedalOfYore,
            Note = "Medal of Yore",
            Para1Post = 768, // vanilla 256
            Description = "Res +3 SP during attacks  ", // vanilla "Restores SP during attacks"
        },
        new()
        {
            Id = Item.SpiritCharm,
            Note = "Spirit Charm",
            Para2 = 18, // vanilla 33
            Para3 = 34, // vanilla 2
            Para4 = 16, // vanilla 0
            Para1Post = 1792, // vanilla 512
            Para2Post = 768, // vanilla 5120
            Para3Post = 512, // vanilla 0
            Description = "Prevents critical hits and knockdown", // vanilla "+20 defense  +2 all magic resistance"
        },
        new()
        {
            Id = Item.PhantomSilk,
            Note = "Phantom Silk",
            Unknown7 = 127, // vanilla 255
            Para1Post = 768, // vanilla 1024
            Para2Post = 768, // vanilla 1024
            Description = "+3 blizzard (water+wind) resistance", // vanilla "+4 blizzard (water+wind) resistance"
        },
        new()
        {
            Id = Item.LightningCharm,
            Note = "Lightning Charm",
            Unknown7 = 127, // vanilla 255
        },
        new()
        {
            Id = Item.ForestCharm,
            Note = "Forest Charm",
            Unknown7 = 127, // vanilla 255
        },
        new()
        {
            Id = Item.ExplosionCharm,
            Note = "Explosion Charm",
            Unknown7 = 127, // vanilla 255
        },
        new()
        {
            Id = Item.BlizzardCharm,
            Note = "Blizzard Charm",
            Unknown7 = 127, // vanilla 255
        },
        new()
        {
            Id = Item.WindBelt,
            Note = "Wind Belt",
            Cost = 13000, // vanilla 6000
        },
        new()
        {
            Id = Item.SonicBelt,
            Note = "Sonic Belt",
            Para1Post = 15360, // vanilla 17920
            Description = "+60 action  Gives speed of sound", // vanilla "+70 action  Gives speed of sound"
        },
        new()
        {
            Id = Item.RevivalStone,
            Note = "Revival Stone",
            Icon = 49, // vanilla 46
        },
        new()
        {
            Id = Item.AnkhOfTemptation,
            Note = "Magical Icon      ",
            Cost = 11000, // vanilla 2000
            ShortName = "MAG ICON ", // vanilla "TEMPT ANK"
            Name = "Magical Icon      ", // vanilla "Ankh of Temptation"
            Description = "+1 magic  Mysterious", // vanilla "+1 magic power level"
        },
        new()
        {
            Id = Item.Anklet,
            Note = "Anklet",
            Para1Post = 12800, // vanilla 7680
            Description = "+50 move  Longer move range", // vanilla "+30 move  Longer move range"
        },
        new()
        {
            Id = Item.EnergyRing,
            Note = "Energy Ring",
            Para1Post = 1280, // vanilla 768
            Description = "Restores +5 SP during attacks   ", // vanilla "Restores SP a lot during attacks"
        },
        new()
        {
            Id = Item.DiseaseCharm,
            Note = "Disease Charm",
            Para1Post = 1024, // vanilla 768
            Description = "+4 plague resistance", // vanilla "+3 plague resistance"
        },
        new()
        {
            Id = Item.CombatAnklet,
            Note = "Combat Anklet",
            Cost = 7500, // vanilla 4000
            Para1Post = 7680, // vanilla 5120
            Description = "+30 attack  Effuses power", // vanilla "+20 attack  Effuses power"
        },
        new()
        {
            Id = Item.SatisfactionGem,
            Note = "Ancestor's Sword",
            Cost = 2800, // vanilla 30000
            Icon = 23, // vanilla 46
            UseStatus = 34929, // vanilla 34934
            Unknown7 = 24, // vanilla 255
            Unknown8 = 2, // vanilla 0
            Unknown27 = 2, // vanilla 0
            Para2 = 1, // vanilla 11
            Para3 = 19, // vanilla 0
            Para1Post = 6665, // vanilla 256
            Para2Post = 512, // vanilla 0
            Para4Post = 1282, // vanilla 512
            ShortName = "ANC SWORD", // vanilla "SATIS GEM"
            Name = "Ancestor's Sword", // vanilla "Satisfaction Gem"
            Description = "+26 attack  +2 magic     ", // vanilla "+1 critical attack chance"
        },
        new()
        {
            Id = Item.TearJewel,
            Note = "Tear Jewel",
            Cost = 12000, // vanilla 3000
            EffectValue = 20, // vanilla 3
            Description = "Restores 20 SP  Lasting    ", // vanilla "Restores 3 SP to one friend"
        },
        new()
        {
            Id = Item.BaobabFruit,
            Note = "Baobab Fruit",
            EffectValue = 15, // vanilla 10
            Description = "Restores 15 SP to 1 friend", // vanilla "Restores 10 SP to 1 friend"
        },
        new()
        {
            Id = Item.BoiledCoconut,
            Note = "Boiled Coconut",
            Cost = 150, // vanilla 240
        },
        new()
        {
            Id = Item.ChocolateCookies,
            Note = "Chocolate Cookies",
            Cost = 300, // vanilla 400
        },
        new()
        {
            Id = Item.Honey,
            Note = "Honey",
            Cost = 400, // vanilla 500
            EffectValue = 120, // vanilla 100
            Description = "Restores 120 HP to 1 friend  Fresh", // vanilla "Restores 100 HP to 1 friend  Fresh"
        },
        new()
        {
            Id = Item.Weeds,
            Note = "Spirit Herb ",
            Cost = 500, // vanilla 2
            EffectValue = 44, // vanilla 1
            Unknown11 = 1, // vanilla 0
            ShortName = "SPT HERB ", // vanilla "WEEDS"
            Name = "Spirit Herb ", // vanilla "Weeds"
            Description = "Restores 300 HP  Extremely Rare     ", // vanilla "Restores 1 HP to 1 friend Just grass"
        },
        new()
        {
            Id = Item.DriedFish,
            Note = "Dried Fish",
            ShortName = "FISH", // vanilla "DRY FISH"
        },
        new()
        {
            Id = Item.BambooShoots,
            Note = "Bamboo",
            Name = "Bamboo", // vanilla "Bamboo Shoots"
        },
        new()
        {
            Id = Item.SmarnaWeed,
            Note = "Smarna Weed",
            EffectValue = 252, // vanilla 255
            Description = "-4 defense for all enemies", // vanilla "-1 defense for all enemies"
        },
        new()
        {
            Id = Item.ChollaFlowers,
            Note = "Cholla Flowers",
            Cost = 200, // vanilla 400
            EffectValue = 20, // vanilla 3
            Description = "Restores 20 lv 1 MP              ", // vanilla "Restores 3 level 1 MP to 1 friend"
        },
        new()
        {
            Id = Item.BamoFruit,
            Note = "Bamo Fruit",
            Cost = 250, // vanilla 600
            EffectValue = 20, // vanilla 4
            Description = "Restores 20 lv 2 MP  Combat only ", // vanilla "Restores 4 level 2 MP to 1 friend"
        },
        new()
        {
            Id = Item.MoveMushroom,
            Note = "Warp Mushroom",
            Cost = 500, // vanilla 200
            ShortName = "WARP SHRM", // vanilla "MOVE SHRM"
            Name = "Warp Mushroom", // vanilla "Move Mushroom"
            Description = "Warp effect for friends in range", // vanilla "+3 move for one and +2 move for some"
        },
        new()
        {
            Id = Item.PowerMushroom,
            Note = "Power Mushroom",
            EffectValue = 2, // vanilla 3
            Description = "+2 attack level for 1 friend", // vanilla "+3 attack level for 1 friend"
        },
        new()
        {
            Id = Item.PoisonAntidote,
            Note = "Poison Antidote",
            Cost = 80, // vanilla 100
        },
        new()
        {
            Id = Item.Bandage,
            Note = "Bandage",
            EffectValue = 60, // vanilla 50
            Description = "Restores 60 HP to 1 friend", // vanilla "Restores 50 HP to 1 friend"
        },
        new()
        {
            Id = Item.FirstAidKit,
            Note = "First Aid Kit",
            Cost = 200, // vanilla 180
            EffectValue = 40, // vanilla 60
            Description = "Restores 40 HP to party", // vanilla "Restores 60 HP to party"
        },
        new()
        {
            Id = Item.RedMedicine,
            Note = "Red Medicine",
            Cost = 1000, // vanilla 400
            EffectValue = 250, // vanilla 200
            Description = "Restores 250 HP to 1 friend", // vanilla "Restores 200 HP to 1 friend"
        },
        new()
        {
            Id = Item.YellowMedicine,
            Note = "Yellow Medicine",
            Cost = 1000, // vanilla 800
        },
        new()
        {
            Id = Item.CrimsonPotion,
            Note = "Crimson Potion",
            Cost = 2000, // vanilla 1500
        },
        new()
        {
            Id = Item.DeepBluePotion,
            Note = "Deep Blue Potion",
            Cost = 8500, // vanilla 5000
        },
        new()
        {
            Id = Item.GoldenPotion,
            Note = "Golden Potion",
            Cost = 6000, // vanilla 3000
        },
        new()
        {
            Id = Item.MagicLamp,
            Note = "Magic Lamp",
            Cost = 18000, // vanilla 7500
            Icon = 49, // vanilla 46
            EffectValue = 20, // vanilla 2
            Description = "Restores 20 MP (all levels)  Lasting", // vanilla "Restores 2 MP (all levels) Breakable"
        },
        new()
        {
            Id = Item.PoisonAntidote367,
            Note = "Poison Antidote",
            Cost = 80, // vanilla 100
        },
        new()
        {
            Id = Item.EyeDrops,
            Note = "Eye Drops",
            Cost = 50, // vanilla 600
        },
        new()
        {
            Id = Item.SpellBreaker,
            Note = "Spell Break  ",
            Cost = 150, // vanilla 200
            Name = "Spell Break  ", // vanilla "Spell Breaker"
        },
        new()
        {
            Id = Item.MoveBreaker,
            Note = "Spell Break ",
            Cost = 150, // vanilla 200
            Effect = Skill.UnblockMagic, // vanilla (Skill)27
            ShortName = "SPL BREAK", // vanilla "MOV BREAK"
            Name = "Spell Break ", // vanilla "Move Breaker"
            Description = "Unblocks magic of 1 friend", // vanilla "Unblocks moves of 1 friend"
        },
        new()
        {
            Id = Item.ResurrectPotion,
            Note = "Resurrect Potion",
            Cost = 600, // vanilla 1000
        },
        new()
        {
            Id = Item.Panacea,
            Note = "Panacea",
            Cost = 300, // vanilla 800
            Effect = (Skill)27, // vanilla Skill.Halvah
        }
    ];
}
