using Grandia.Sdk;

namespace GrandiaRedux.Shops;

/// <summary>
/// Shop pages that differ between HD Remaster MDP sec[10] and
/// Redux 0.4.9. Unlisted pages stay vanilla.
/// </summary>
internal static class Stock
{
    internal static readonly ShopEdit[] All =
    [
        new()
        {
            Map = 0x204C,
            Note = "Parm General Store",
            Goods =
            [
                Item.WouldSalve, // Wound Salve
                Item.Herbs,
                Item.RustyKnife, // Lump of Coal
            ], // vanilla Would Salve, Herbs
        },
        new()
        {
            Map = 0x3C08,
            Note = "Adventurers Store",
            Weapons =
            [
                Item.ParingKnife,
                Item.HuntersKnife,
                Item.GreatSword,
                Item.CeramicSword,
                Item.BigHatchet,
                Item.IronMace,
                Item.BasicWand,
                Item.ThornyWhip,
                Item.MagicRope,
                Item.HuntersBow, // Poison Bow  
            ], // vanilla Paring Knife, Hunter's Knife, Great Sword, Ceramic Sword, Big Hatchet, Iron Mace, Thorny Whip, Hunter's Bow
            Goods =
            [
                Item.SnakeEarrings,
                Item.CrescentJade,
                Item.DriedFish,
                Item.BambooShoots, // Bamboo
                Item.BeefJerky,
                Item.PoisonAntidote367,
                Item.FirstAidKit,
                Item.SmarnaWeed,
                Item.RoachBomb,
                Item.CampingTent,
                Item.ResurrectPotion,
                Item.ChollaFlowers,
            ], // vanilla Snake Earrings, Dried Fish, Bamboo Shoots, Beef Jerky, Poison Antidote, First Aid Kit, Smarna Weed, Roach Bomb, Dream Truffle
        },
        new()
        {
            Map = 0x5414,
            Note = "Weapons Store",
            Armor =
            [
                Item.FairyRobe,
                Item.EscargotShield,
                Item.ClimbingHat,
                Item.AgileHat,
                Item.CuriousClogs,
                Item.AgileShoes,
            ], // vanilla Fairy Robe, Escargot Shield, Climbing Hat, Curious Clogs
            Goods =
            [
                Item.TreeGodAmulet,
                Item.Bandage,
                Item.FirstAidKit,
                Item.SpellBreaker, // Spell Break  
                Item.CampingTent,
                Item.ParalysisOintment,
                Item.ResurrectPotion,
                Item.BaobabFruit,
                Item.SmarnaWeed,
                Item.FirewoodSparks,
                Item.ChollaFlowers,
                Item.ManaEgg,
            ], // vanilla Tree God Amulet, Bandage, Move Breaker, Spell Breaker, Smelling Salts, Paralysis Ointment, Resurrect Potion, Baobab Fruit, Smarna Weed, Firewood Sparks, Snooze Scroll, Zap! Book
        },
        new()
        {
            Map = 0x6808,
            Note = "Weapons Store",
            Weapons =
            [
                Item.SwordfishSword,
                Item.DragonBoneAx,
                Item.FireRod,
                Item.ReduxWand,
                Item.GaleWhip,
                Item.FlyingFishBow,
                Item.ThiefCutter,
            ], // vanilla Swordfish Sword, Dragon Bone Ax, Fire Rod, Gale Whip, Flying Fish Bow
            Goods =
            [
                Item.DiseaseCharm,
                Item.ChollaFlowers,
                Item.BamoFruit,
                Item.SquidGuts,
                Item.MoveMushroom, // Warp Mushroom
                Item.PowerMushroom,
                Item.CampingTent,
                Item.ResurrectPotion,
                Item.Panacea,
                Item.Vaccine,
                Item.MikeromaScroll,
                Item.Dynamite,
            ], // vanilla Disease Charm, Cholla Flowers, Bamo Fruit, Squid Guts, Move Mushroom, Power Mushroom, Poison Antidote, Resurrect Potion, Panacea, Vaccine, Mikeroma Scroll, Dynamite
        },
        new()
        {
            Map = 0x9408,
            Note = "Weapons Store",
            Goods =
            [
                Item.ConfusionCharm,
                Item.IridescentAmulet,
                Item.BlackBelt,
                Item.ChocolateCookies,
                Item.Honey,
                Item.CampingTent,
                Item.ResurrectPotion441,
                Item.PoisonAntidote,
                Item.HowlerScroll,
                Item.TremorScroll,
                Item.GaleScroll,
                Item.ZapBook,
            ], // vanilla Confusion Charm, Iridescent Amulet, Black Belt, Chocolate Cookies, Honey, Torte's Whistle, Resurrect Potion, Poison Antidote, Howler Scroll, Tremor Scroll, Gale Scroll, Zap! Book
        },
        new()
        {
            Map = 0xA010,
            Note = "General Store",
            Weapons =
            [
                Item.AssassinsDagger,
                Item.GilSword,
                Item.HolySwordLorenzo,
                Item.LassicHammer,
                Item.ExorcisingBow,
                Item.FireDarts,
                Item.Discus,
                Item.EnchantedWhip,
            ], // vanilla Assassin's Dagger, Gil Sword, Holy Sword Lorenzo, Lassic Hammer, Exorcising Bow, Fire Darts, Discus
            Goods =
            [
                Item.Scarab,
                Item.TitansRing,
                Item.MysteriousVeil,
                Item.AnkhOfTemptation, // Magical Icon      
                Item.ManaEgg,
                Item.ResurrectPotion441,
                Item.MagicLamp,
                Item.CrimsonPotion,
                Item.BlueMedicine,
                Item.DeepBluePotion,
                Item.GoldenPotion,
                Item.CampingTent,
            ], // vanilla Scarab, Titan's Ring, Talisman, Root of Confusion, Trudge Weed, Resurrect Potion, Magic Lamp, Crimson Potion, Deep Blue Potion, Golden Potion
        },
        new()
        {
            Map = 0xA03A,
            Note = "Room of Teleportation",
            Goods =
            [
                Item.FireCharm,
                Item.WaterCharm,
                Item.WindCharm,
                Item.EarthCharm,
                Item.PhantomSilk,
                Item.MetalFrog,
                Item.MiraculousScales,
                Item.AmuletOfRelief,
                Item.DevilsAnklet, // Ancient Tablet
                Item.MagicLamp,
                Item.TearJewel,
                Item.ConeOfLight,
            ], // vanilla Fire Charm, Water Charm, Wind Charm, Earth Charm, Tree God Amulet, Metal Frog, Hurricane Belt, Secret Move Ring, Miraculous Scales, Cone of Light
        },
        new()
        {
            Map = 0xA202,
            Note = "Town of Zil Padon",
            Goods =
            [
                Item.HurricaneBelt, // Icarian Idol  
                Item.Telescope,
                Item.BlackNailPolish,
                Item.MagicLipstick,
                Item.LaunchFireworks,
                Item.ThorsFury, // Thors Fury
                Item.BOOMScroll,
                Item.VacuumScroll,
                Item.TremorScroll,
                Item.GaleScroll,
                Item.BlackOnyx,
                Item.OrbOfSilence,
            ], // vanilla Telescope, Freesia Flowers, Magic Lipstick, Black Nail Polish, Launch Fireworks, Thor's Fury, BOOM! Scroll, Vacuum Scroll, Tremor Scroll, Gale Scroll
        },
        new()
        {
            Map = 0xA203,
            Note = "Town of Zil Padon",
            Goods =
            [
                Item.HurricaneBelt, // Icarian Idol  
                Item.Telescope,
                Item.BlackNailPolish,
                Item.MagicLipstick,
                Item.LaunchFireworks,
                Item.ThorsFury, // Thors Fury
                Item.BOOMScroll,
                Item.VacuumScroll,
                Item.TremorScroll,
                Item.GaleScroll,
                Item.BlackOnyx,
                Item.OrbOfSilence,
            ], // vanilla Telescope, Freesia Flowers, Magic Lipstick, Black Nail Polish, Launch Fireworks, Thor's Fury, BOOM! Scroll, Vacuum Scroll, Tremor Scroll, Gale Scroll
        },
        new()
        {
            Map = 0xA244,
            Note = "Mogay Shop",
            Weapons =
            [
                Item.HolySwordLorenzo,
                Item.BusterAx,
                Item.LassicHammer,
                Item.Discus,
                Item.IceBoomerang,
                Item.EnchantedWhip,
            ], // vanilla Holy Sword Lorenzo, Buster Ax, War Hammer, Discus
            Armor =
            [
                Item.DevilsRobe,
                Item.AuraArmor,
                Item.MoonlightShield,
                Item.LafaFlowerShield,
                Item.MysticMask,
                Item.HeavyBoots,
                Item.QueenHeels,
                Item.GlassSlippers,
            ], // vanilla Devil's Robe, Aura Armor, Moonlight Shield, Lafa Flower Shield, Mystic Mask, Heavy Boots, Queen Heels
            Goods =
            [
                Item.Scarab,
                Item.WindBelt,
                Item.MysteriousVeil,
                Item.RedMedicine,
                Item.CrimsonPotion,
                Item.ResurrectPotion441,
                Item.Panacea,
                Item.YellowMedicine,
                Item.GoldenPotion,
                Item.BlueMedicine,
                Item.DeepBluePotion,
                Item.CampingTent,
            ], // vanilla Scarab, Titan's Ring, Talisman, Resurrect Potion, Panacea, Magic Lamp, Crimson Potion, Deep Blue Potion, Golden Potion
        },
        new()
        {
            Map = 0xD40C,
            Note = "Field Base (PX)",
            Goods =
            [
                Item.AmuletOfRelief,
                Item.CombatAnklet,
                Item.EliteBadge,
                Item.RedMedicine,
                Item.CrimsonPotion,
                Item.YellowMedicine,
                Item.GoldenPotion,
                Item.BlueMedicine,
                Item.DeepBluePotion,
                Item.ResurrectPotion441,
            ], // vanilla Amulet of Relief, Combat Anklet, Elite Badge, Rescue Set, Eye Drops, Smelling Salts, Paralysis Ointment, Culture Medium, Lightning Scroll, Hand Grenade
        }
    ];
}
