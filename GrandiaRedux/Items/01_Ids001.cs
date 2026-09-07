using Grandia.Sdk;

namespace GrandiaRedux.Items;

/// <summary>
/// WINDT sec3 rows from id 1 that differ between HD Remaster
/// FIELD/WINDT.BIN and Redux 0.4.9. Unlisted fields stay vanilla.
/// Names / leftover sec3 bytes apply through OnItem (TEXT1 + WINDT).
/// </summary>
internal static class Ids001
{
    internal static readonly ItemEdit[] All =
    [
        new()
        {
            Id = Item.LifeJewel,
            Note = "Life Jewel",
            Cost = 10000, // vanilla 0
            Icon = 46, // vanilla 0
            UseStatus = 34934, // vanilla 0
            Unknown7 = 255, // vanilla 0
            Unknown13 = 7, // vanilla 0
            Unknown14 = 20, // vanilla 0
            Para4Post = 512, // vanilla 0
            ShortName = "LIF JEWL", // vanilla "PROHIBIT"
            Name = "Life Jewel", // vanilla "Prohibited"
            Description = "20HP w att", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.MageHat,
            Note = "Mage Hat",
            Cost = 8000, // vanilla 0
            Icon = 41, // vanilla 0
            UseStatus = 34931, // vanilla 0
            Unknown7 = 166, // vanilla 0
            Para2 = 2, // vanilla 0
            Para3 = 3, // vanilla 0
            Para1Post = 3840, // vanilla 0
            Para2Post = 3072, // vanilla 0
            Para4Post = 6656, // vanilla 0
            ShortName = "MAGE HAT", // vanilla "PROHIBIT"
            Name = "Mage Hat", // vanilla "Prohibited"
            Description = "+15 defense  +12 action  Pink         ", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.Yoyo,
            Note = "Yoyo",
            Cost = 40, // vanilla 0
            Icon = 31, // vanilla 0
            UseStatus = 34929, // vanilla 0
            Unknown7 = 2, // vanilla 0
            Unknown8 = 5, // vanilla 0
            Unknown13 = 1, // vanilla 0
            Unknown14 = 50, // vanilla 0
            Unknown27 = 7, // vanilla 0
            Para2 = 3, // vanilla 0
            Para1Post = 3849, // vanilla 0
            Para2Post = 768, // vanilla 0
            Para4Post = 5122, // vanilla 0
            ShortName = "YOYO", // vanilla "PROHIBIT"
            Name = "Yoyo", // vanilla "Prohibited"
            Description = "+15 action  Speeds spell casting          ", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.BasicWand,
            Note = "Basic Wand",
            Cost = 950, // vanilla 0
            Icon = 27, // vanilla 0
            UseStatus = 34929, // vanilla 0
            Unknown7 = 165, // vanilla 0
            Unknown8 = 3, // vanilla 0
            Unknown12 = 11, // vanilla 0
            Unknown27 = 5, // vanilla 0
            Para2 = 1, // vanilla 0
            Para3 = 19, // vanilla 0
            Para1Post = 2313, // vanilla 0
            Para2Post = 256, // vanilla 0
            Para4Post = 2561, // vanilla 0
            ShortName = "BSC WAND", // vanilla "PROHIBIT"
            Name = "Basic Wand", // vanilla "Prohibited"
            Description = "+9 attack  +1 magic  Shiny", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.ReduxWand,
            Note = "ReDux Wand",
            Cost = 4000, // vanilla 0
            Icon = 27, // vanilla 0
            UseStatus = 34929, // vanilla 0
            Unknown7 = 165, // vanilla 0
            Unknown8 = 3, // vanilla 0
            Unknown12 = 11, // vanilla 0
            Unknown27 = 5, // vanilla 0
            Para2 = 1, // vanilla 0
            Para3 = 19, // vanilla 0
            Para1Post = 3337, // vanilla 0
            Para2Post = 512, // vanilla 0
            Para4Post = 2561, // vanilla 0
            ShortName = "RDX WAND", // vanilla "PROHIBIT"
            Name = "ReDux Wand", // vanilla "Prohibited"
            Description = "+13 attack +2 magic  All patched up", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.LordsWand,
            Note = "Lord's Wand ",
            Cost = 12500, // vanilla 0
            Icon = 26, // vanilla 0
            UseStatus = 34929, // vanilla 0
            Unknown7 = 133, // vanilla 0
            Unknown8 = 3, // vanilla 0
            Unknown12 = 11, // vanilla 0
            Unknown27 = 5, // vanilla 0
            Para2 = 1, // vanilla 0
            Para3 = 19, // vanilla 0
            Para1Post = 9737, // vanilla 0
            Para2Post = 512, // vanilla 0
            Para4Post = 2561, // vanilla 0
            ShortName = "LORD WAND", // vanilla "PROHIBIT"
            Name = "Lord's Wand ", // vanilla "Prohibited"
            Description = "+38 attack  +2 magic", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.MagicRope,
            Note = "Magic Rope",
            Cost = 1140, // vanilla 0
            Icon = 31, // vanilla 0
            UseStatus = 34929, // vanilla 0
            Unknown7 = 2, // vanilla 0
            Unknown8 = 5, // vanilla 0
            Unknown27 = 7, // vanilla 0
            Para2 = 3, // vanilla 0
            Para3 = 19, // vanilla 0
            Para1Post = 3337, // vanilla 0
            Para2Post = 256, // vanilla 0
            Para4Post = 5122, // vanilla 0
            ShortName = "MAGE ROPE", // vanilla "PROHIBIT"
            Name = "Magic Rope", // vanilla "Prohibited"
            Description = "+13 action  +1 magic  Very long", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.LuresHeart,
            Note = "Lure's Heart",
            Cost = 2000, // vanilla 0
            Icon = 31, // vanilla 0
            UseStatus = 34929, // vanilla 0
            Unknown7 = 2, // vanilla 0
            Unknown8 = 5, // vanilla 0
            Unknown27 = 7, // vanilla 0
            Para2 = 3, // vanilla 0
            Para3 = 19, // vanilla 0
            Para1Post = 5129, // vanilla 0
            Para2Post = 512, // vanilla 0
            Para4Post = 5122, // vanilla 0
            ShortName = "LURE HART", // vanilla "PROHIBIT"
            Name = "Lure's Heart", // vanilla "Prohibited"
            Description = "+20 action  +2 magic  Soft", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.EnchantedWhip,
            Note = "Enchanted Whip",
            Cost = 30000, // vanilla 0
            Icon = 31, // vanilla 0
            UseStatus = 34929, // vanilla 0
            Unknown7 = 2, // vanilla 0
            Unknown8 = 5, // vanilla 0
            Unknown27 = 7, // vanilla 0
            Para2 = 3, // vanilla 0
            Para3 = 19, // vanilla 0
            Para1Post = 8201, // vanilla 0
            Para2Post = 768, // vanilla 0
            Para4Post = 5122, // vanilla 0
            ShortName = "CHANTWHIP", // vanilla "PROHIBIT"
            Name = "Enchanted Whip", // vanilla "Prohibited"
            Description = "+32 action  +3 magic  Fascinating  ", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.SpiritStone,
            Note = "Spirit Stone",
            EffectValue = 2, // vanilla 1
            Description = "Memento of Dad", // vanilla "Justin's treasured memento of Dad"
        },
        new()
        {
            Id = Item.HerosArmband,
            Note = "Hero's Armband",
            Description = "Deleted .Unused.", // vanilla "Deleted. Unused."
        },
        new()
        {
            Id = Item.HornOfKnowledge,
            Note = "Horn of Knowledge",
            Description = "Dorlin's Horn", // vanilla "Dorlin's horn"
        },
        new()
        {
            Id = Item.MedalOfKnowledge,
            Note = "Medal of Knowledge",
            Description = "Key to Alent", // vanilla "Medal for getting to Alent"
        },
        new()
        {
            Id = Item.GantzsKey,
            Note = "Gantz's Key",
            Description = "Gantz's chest key", // vanilla "The key to Gantz's treasure chest"
        },
        new()
        {
            Id = Item.IntroLetter,
            Note = "Intro Letter",
            Description = "From Curator. Intro to Sult Ruins.", // vanilla "From Curator. Gets into Sult Ruins."
        },
        new()
        {
            Id = Item.KeyToTheCaf,
            Note = "Key to the Cafe",
            Description = "Key to the cafe", // vanilla "Key to the cafe in Parm"
        },
        new()
        {
            Id = Item.JavasWallet,
            Note = "Java's Wallet",
            Description = "Java's wallet.", // vanilla "Take his forgotten wallet back."
        },
        new()
        {
            Id = Item.SteamerPass,
            Note = "Steamer Pass",
            Description = "Ticket for the Elencia ship ", // vanilla "Ticket to the ship to Elencia"
        },
        new()
        {
            Id = Item.LillysLetter,
            Note = "Lilly's Letter",
            Description = "Letter from Mom", // vanilla "Letter from Justin's Mom"
        },
        new()
        {
            Id = Item.CabinKey,
            Note = "Cabin Key",
            Description = "Key to cabin", // vanilla "Key to first-class cabin"
        },
        new()
        {
            Id = Item.SulfaWeed,
            Note = "Sulfa Weed",
            Description = "Can cure Rem's disease", // vanilla "Herb that can cure Rem's disease"
        },
        new()
        {
            Id = Item.JailKey,
            Note = "Jail Key",
            Description = "Opens the jail cells", // vanilla "Key to the military base jail cell"
        },
        new()
        {
            Id = Item.MasterKey,
            Note = "Master Key",
            Description = "Opens all locked doors", // vanilla "Master key to the military base"
        },
        new()
        {
            Id = Item.NectarOfTheGods,
            Note = "Nectar of the Gods",
            Description = "Give to the chief", // vanilla "Nectar to give to the chief of Luc"
        },
        new()
        {
            Id = Item.MistClearingNut,
            Note = "Mist-Clearing Nut",
            Description = "Clears the forest mist", // vanilla "Clears mist from the Misty Forest"
        },
        new()
        {
            Id = Item.SuesShoes,
            Note = "Sue's Shoes",
            Description = "Sue's shoes", // vanilla "Shoes that Sue was wearing"
        },
        new()
        {
            Id = Item.SpiritSword,
            Note = "Spirit Sword",
            Para1Post = 23049, // vanilla 17929
            Description = "+90 attack  Restores HP in attacks", // vanilla "+70 attack  Restores SP in attacks"
        },
        new()
        {
            Id = Item.MariesPin,
            Note = "Marie's Pin",
            Icon = 62, // vanilla 46
        },
        new()
        {
            Id = Item.RingOfProtection,
            Note = "Eye of Friendship ",
            Cost = 0, // vanilla 10000
            Icon = 8, // vanilla 46
            UseStatus = 49504, // vanilla 34934
            Effect = Skill.Alhealer, // vanilla (Skill)0
            EffectValue = 200, // vanilla 0
            Unknown13 = 0, // vanilla 25
            Unknown14 = 0, // vanilla 20
            Para2 = 0, // vanilla 2
            Para1Post = 0, // vanilla 2560
            ShortName = "EYE FRND ", // vanilla "PROT RING"
            Name = "Eye of Friendship ", // vanilla "Ring of Protection"
            Description = "Heals when used  It's your friend!  ", // vanilla "+10 defense Prevents damage below 20"
        },
        new()
        {
            Id = Item.FrostHerb,
            Note = "Magus Fang",
            Cost = 2000, // vanilla 600
            Icon = 22, // vanilla 50
            UseStatus = 34929, // vanilla 49408
            Effect = (Skill)0, // vanilla Skill.Cold
            EffectValue = 0, // vanilla 251
            Unknown7 = 82, // vanilla 255
            Unknown8 = 1, // vanilla 0
            Unknown11 = 0, // vanilla 255
            Unknown12 = 0, // vanilla 96
            Para2 = 1, // vanilla 0
            Para3 = 19, // vanilla 0
            Para4 = 10, // vanilla 0
            Para1Post = 18185, // vanilla 0
            Para2Post = 512, // vanilla 0
            Para3Post = 256, // vanilla 0
            Para4Post = 768, // vanilla 0
            ShortName = "MAGUSFANG", // vanilla "FROSTHERB"
            Name = "Magus Fang", // vanilla "Frost Herb"
            Description = "+71 attack  +2 magic  Enhanced    ", // vanilla "Freezes 1 enemy to -5 action level"
        },
        new()
        {
            Id = Item.AmuletOfRelief,
            Note = "Amulet of Relief",
            Cost = 15000, // vanilla 7000
            Description = "+15 defense  Regens HP over time  ", // vanilla "+15 defense  Restores HP in combat"
        },
        new()
        {
            Id = Item.GaiaWand,
            Note = "Gaia Wand ",
            Cost = 23000, // vanilla 0
            Icon = 27, // vanilla 0
            UseStatus = 34929, // vanilla 0
            Unknown7 = 128, // vanilla 0
            Unknown8 = 3, // vanilla 0
            Unknown27 = 5, // vanilla 0
            Para2 = 2, // vanilla 0
            Para3 = 19, // vanilla 0
            Para1Post = 2569, // vanilla 0
            Para2Post = 1024, // vanilla 0
            Para4Post = 2561, // vanilla 0
            ShortName = "GAIA WAND", // vanilla "PROHIBIT"
            Name = "Gaia Wand ", // vanilla "Prohibited"
            Description = "+10 defense  +4 magic  Corrupted", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.AgileShoes,
            Note = "Agile Shoes",
            Cost = 1200, // vanilla 0
            Icon = 45, // vanilla 0
            UseStatus = 34933, // vanilla 0
            Unknown7 = 255, // vanilla 0
            Para2 = 3, // vanilla 0
            Para3 = 4, // vanilla 0
            Para1Post = 1280, // vanilla 0
            Para2Post = 10240, // vanilla 0
            Para4Post = 6912, // vanilla 0
            ShortName = "AGL SHOES", // vanilla "PROHIBIT"
            Name = "Agile Shoes", // vanilla "Prohibited"
            Description = "+40 move  +5 action", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.AgileHat,
            Note = "Agile Hat",
            Cost = 700, // vanilla 0
            Icon = 41, // vanilla 0
            UseStatus = 34931, // vanilla 0
            Unknown7 = 255, // vanilla 0
            Unknown12 = 16, // vanilla 0
            Para2 = 2, // vanilla 0
            Para3 = 3, // vanilla 0
            Para1Post = 1024, // vanilla 0
            Para2Post = 1280, // vanilla 0
            Para4Post = 6656, // vanilla 0
            ShortName = "AGL HAT", // vanilla "PROHIBIT"
            Name = "Agile Hat", // vanilla "Prohibited"
            Description = "+4 defense  +5 action", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.CampingTent,
            Note = "Camping Tent",
            Cost = 250, // vanilla 0
            Icon = 62, // vanilla 0
            UseStatus = 57631, // vanilla 0
            Effect = (Skill)48, // vanilla (Skill)0
            EffectValue = 1, // vanilla 0
            Unknown7 = 255, // vanilla 0
            ShortName = "TENT   ", // vanilla "PROHIBIT"
            Name = "Camping Tent", // vanilla "Prohibited"
            Description = "Restores all HP and status to party", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.AdventureBow,
            Note = "Adventure Bow      ",
            Cost = 6000, // vanilla 0
            Icon = 34, // vanilla 0
            UseStatus = 34929, // vanilla 0
            Unknown7 = 68, // vanilla 0
            Unknown8 = 6, // vanilla 0
            Unknown27 = 88, // vanilla 0
            Para2 = 1, // vanilla 0
            Para3 = 36, // vanilla 0
            Para1Post = 8713, // vanilla 0
            Para2Post = 256, // vanilla 0
            Para4Post = 3348, // vanilla 0
            ShortName = "ADVEN BOW", // vanilla "PROHIBIT"
            Name = "Adventure Bow      ", // vanilla "Prohibited"
            Description = "+34 attack  +1 skill power  ", // vanilla "Prohibited"
        },
        new()
        {
            Id = Item.KnifeOfJudgment,
            Note = "Gladius         ",
            Cost = 400, // vanilla 10000
            Para3 = 10, // vanilla 0
            Para1Post = 5641, // vanilla 9737
            Para2Post = 256, // vanilla 0
            ShortName = "GLADIUS  ", // vanilla "JUD KNIFE"
            Name = "Gladius         ", // vanilla "Knife of Judgment"
            Description = "+22 attack  Effective on ghosts", // vanilla "+38 attack  Effective on ghosts"
        },
        new()
        {
            Id = Item.RustyKnife,
            Note = "Lump of Coal",
            Cost = 250, // vanilla 1000
            Icon = 62, // vanilla 21
            UseStatus = 34934, // vanilla 34929
            Unknown7 = 128, // vanilla 82
            Unknown8 = 0, // vanilla 1
            Unknown13 = 0, // vanilla 7
            Unknown14 = 0, // vanilla 1
            Para2 = 10, // vanilla 1
            Para3 = 36, // vanilla 0
            Para4 = 11, // vanilla 0
            Para1Post = 2048, // vanilla 3849
            Para2Post = 512, // vanilla 0
            Para3Post = 512, // vanilla 0
            Para4Post = 0, // vanilla 768
            ShortName = "LUMP COAL", // vanilla "RST KNIFE"
            Name = "Lump of Coal", // vanilla "Rusty Knife"
            Description = "A mineral that is rarer than diamond", // vanilla "+15 attack  Rusty and not very sharp"
        },
        new()
        {
            Id = Item.ParingKnife,
            Note = "Paring Knife",
            Para3 = 10, // vanilla 0
            Para2Post = 256, // vanilla 0
        },
        new()
        {
            Id = Item.HuntersKnife,
            Note = "Hunter's Knife",
            Para3 = 10, // vanilla 0
            Para1Post = 5129, // vanilla 4617
            Para2Post = 256, // vanilla 0
            Description = "+20 attack  Light and easy to use", // vanilla "+18 attack  Light and easy to use"
        },
        new()
        {
            Id = Item.FlintKnife,
            Note = "Flint Knife",
            Para3 = 10, // vanilla 0
            Para1Post = 6665, // vanilla 5129
            Para2Post = 256, // vanilla 0
            Description = "+26 attack  An obsidian knife", // vanilla "+20 attack  An obsidian knife"
        },
        new()
        {
            Id = Item.AzureKnife,
            Note = "Azure Knife",
            UseStatus = 51569, // vanilla 34929
            Effect = Skill.Heal, // vanilla (Skill)0
            EffectValue = 30, // vanilla 0
            Para3 = 10, // vanilla 0
            Para1Post = 7433, // vanilla 6409
            Para2Post = 256, // vanilla 0
            Description = "+29 attack Att: water [Heal]", // vanilla "+25 attack  Attribute: water"
        },
        new()
        {
            Id = Item.ShockingKnife,
            Note = "Shocking Knife",
            Cost = 10000, // vanilla 6500
            Para1Pre = 1, // vanilla 2
            Para3 = 10, // vanilla 0
            Para2Post = 256, // vanilla 0
        },
        new()
        {
            Id = Item.PoisonedKnife,
            Note = "Poisoned Knife",
            Para1Pre = 3, // vanilla 7
            Para3 = 10, // vanilla 0
            Para1Post = 10249, // vanilla 8969
            Para2Post = 256, // vanilla 0
            Description = "+40 attack  Very poisonous", // vanilla "+35 attack  Very poisonous"
        },
        new()
        {
            Id = Item.AssassinsDagger,
            Note = "Assassin's Dagger",
            Unknown13 = 0, // vanilla 9
            Unknown14 = 0, // vanilla 10
            Para1Pre = 0, // vanilla 7
            Para3 = 10, // vanilla 0
            Para1Post = 13321, // vanilla 12809
            Para2Post = 256, // vanilla 0
            Description = "+52 attack  Extremely lethal", // vanilla "+50 attack  Extremely lethal"
        },
        new()
        {
            Id = Item.BloodyKnife,
            Note = "Bloody Knife",
            Para3 = 10, // vanilla 0
            Para1Post = 11273, // vanilla 14089
            Para2Post = 256, // vanilla 0
            Description = "+44 attack  Effective on humans", // vanilla "+55 attack  Effective on humans"
        },
        new()
        {
            Id = Item.IcePick,
            Note = "Ice Pick",
            UseStatus = 26993, // vanilla 34929
            Effect = Skill.Crackle, // vanilla (Skill)0
            EffectValue = 120, // vanilla 0
            Para3 = 10, // vanilla 0
            Para1Post = 11529, // vanilla 9737
            Para2Post = 256, // vanilla 0
            Description = "+45 attack blizzard [Crackle]  ", // vanilla "+38 attack  Attribute: blizzard"
        },
        new()
        {
            Id = Item.ForceKnife,
            Note = "Force Knife",
            Para3 = 10, // vanilla 0
            Para1Post = 17929, // vanilla 16649
            Para2Post = 256, // vanilla 0
            Description = "+70 attack  Ups attack range [WOW!]", // vanilla "+65 attack  Ups attack range [WOW!]"
        },
        new()
        {
            Id = Item.GodspeedKnife,
            Note = "Spirit Dagger ",
            Para3 = 10, // vanilla 3
            Para1Post = 20489, // vanilla 15369
            Para2Post = 256, // vanilla 7680
            ShortName = "SP DAGGER", // vanilla "GOD KNIFE"
            Name = "Spirit Dagger ", // vanilla "Godspeed Knife"
            Description = "+80 attack  Best dagger [Mirage]", // vanilla "+60 attack  +30 action  [Runner]"
        },
        new()
        {
            Id = Item.GustKnife,
            Note = "Rock Knife",
            UseStatus = 51569, // vanilla 34929
            Effect = Skill.Howl, // vanilla (Skill)0
            EffectValue = 40, // vanilla 0
            Para3 = 10, // vanilla 0
            Para1Post = 7689, // vanilla 6153
            Para2Post = 256, // vanilla 0
            ShortName = "RCK KNIFE", // vanilla "GST KNIFE"
            Name = "Rock Knife", // vanilla "Gust Knife"
            Description = "+30 attack Attr: earth [Diggin']", // vanilla "+24 attack  Attribute: wind"
        },
        new()
        {
            Id = Item.RuinationKnife,
            Note = "Ruination Knife",
            Para2 = 10, // vanilla 2
            Para3 = 11, // vanilla 10
            Para4 = 13, // vanilla 0
            Para1Post = 521, // vanilla 55305
            Para2Post = 256, // vanilla 1023
            Para3Post = 1280, // vanilla 0
            Description = "Enrages the soul...  ", // vanilla "-40 defense  +3 Combo hits"
        },
        new()
        {
            Id = Item.ThiefCutter,
            Note = "Thief Cutter",
            Cost = 15000, // vanilla 30000
            Para3 = 10, // vanilla 0
            Para1Post = 6921, // vanilla 8969
            Para2Post = 256, // vanilla 0
            Description = "+27 attack  Aims for items", // vanilla "+35 attack  Aims for items"
        },
        new()
        {
            Id = Item.ZeroKnife,
            Note = "Zero Knife",
            Para3 = 10, // vanilla 0
            Para2Post = 256, // vanilla 0
        },
        new()
        {
            Id = Item.SwordfishSword,
            Note = "Swordfish Sword",
            Para3 = 3, // vanilla 0
            Para2Post = 1280, // vanilla 0
            Description = "+29 attack  +5 action  Dight's sword", // vanilla "+29 attack  The sword of a swordfish"
        },
        new()
        {
            Id = Item.DragonKiller,
            Note = "Dragon Killer",
            Para1Post = 8201, // vanilla 6665
            Description = "+32 attack  Effective on dragons", // vanilla "+26 attack  Effective on dragons"
        },
        new()
        {
            Id = Item.FireSword,
            Note = "Fire Sword",
            Para1Post = 11017, // vanilla 9737
            Description = "+43 attack  Attribute: fire", // vanilla "+38 attack  Attribute: fire"
        },
        new()
        {
            Id = Item.ShadowSword,
            Note = "Shadow Sword",
            Cost = 6000, // vanilla 7000
            Unknown13 = 0, // vanilla 9
            Unknown14 = 0, // vanilla 8
            Para1Pre = 0, // vanilla 3
            Para3 = 2, // vanilla 4
            Para1Post = 9993, // vanilla 8713
            Para2Post = 64256, // vanilla 61696
            Description = "+39 attack -5 defense  Dark tint ", // vanilla "+34 attack -15 move  Sudden death"
        },
        new()
        {
            Id = Item.SilenceSword,
            Note = "Silence Sword",
            Para1Post = 11273, // vanilla 10249
            Description = "+44 attack  Magic block effect", // vanilla "+40 attack  Magic block effect"
        },
        new()
        {
            Id = Item.HolySwordLorenzo,
            Note = "Holy Sword Lorenzo",
            Cost = 25000, // vanilla 40000
        },
        new()
        {
            Id = Item.IceBlade,
            Note = "Ice Blade",
            UseStatus = 34929, // vanilla 51569
            Effect = (Skill)0, // vanilla Skill.Cold
            EffectValue = 0, // vanilla 254
            Unknown11 = 0, // vanilla 255
            Para1Post = 14857, // vanilla 10249
            Description = "+58 attack  Att.: blizzard       ", // vanilla "+40 attack  Att.: blizzard [Cold]"
        },
        new()
        {
            Id = Item.LightningSword,
            Note = "Lightning Sword",
            Para1Post = 13833, // vanilla 12809
            Description = "+54 attack  Att.: thunder [Zap!]", // vanilla "+50 attack  Att.: thunder [Zap!]"
        },
        new()
        {
            Id = Item.BattleSaber,
            Note = "Battle Saber",
            Cost = 30000, // vanilla 31500
            Para1Post = 15369, // vanilla 12297
            Description = "+60 attack  A huge sword", // vanilla "+48 attack  A huge sword"
        },
        new()
        {
            Id = Item.MagicRod,
            Note = "Grandia Rod",
            Unknown7 = 128, // vanilla 165
            Para2 = 2, // vanilla 1
            Para1Post = 5129, // vanilla 15369
            Para2Post = 1280, // vanilla 512
            ShortName = "GRAND ROD", // vanilla "MAGIC ROD"
            Name = "Grandia Rod", // vanilla "Magic Rod"
            Description = "+20 defense  +5 magic  Best wand", // vanilla "+60 attack  +2 magic power level"
        },
        new()
        {
            Id = Item.MinersHammer,
            Note = "Mine Hammer ",
            Name = "Mine Hammer ", // vanilla "Miner's Hammer"
        },
        new()
        {
            Id = Item.IronMace,
            Note = "Iron Mace",
            Para1Post = 5385, // vanilla 4873
            Para2Post = 64256, // vanilla 62976
            Description = "+21 attack -5 action  Heavy ", // vanilla "+19 attack -10 action  Heavy"
        },
        new()
        {
            Id = Item.ArmyDarts,
            Note = "Army Darts",
            Para3 = 4, // vanilla 0
            Para2Post = 2560, // vanilla 0
            Description = "+18 attack  +10 move  Sharp   ", // vanilla "+18 attack  For covert actions"
        },
        new()
        {
            Id = Item.LassicHammer,
            Note = "Lassic Hammer",
            Cost = 21000, // vanilla 17500
            Para1Post = 14601, // vanilla 12809
            Description = "+57 attack  Crushing     ", // vanilla "+50 attack  A huge hammer"
        },
        new()
        {
            Id = Item.WarHammer,
            Note = "War Hammer",
            Para1Post = 13833, // vanilla 11017
            Description = "+54 attack  -10 move", // vanilla "+43 attack  -10 move"
        },
        new()
        {
            Id = Item.HertzSpike,
            Note = "Hertz Spike",
            Unknown13 = 0, // vanilla 9
            Unknown14 = 0, // vanilla 33
            Para1Pre = 0, // vanilla 1
            Para3 = 36, // vanilla 0
            Para1Post = 19977, // vanilla 16649
            Para2Post = 256, // vanilla 0
            Description = "+78 attack  +1 skill power         ", // vanilla "+65 attack  Sudden death  Best mace"
        },
        new()
        {
            Id = Item.OraclesStaff,
            Note = "Oracle's Staff",
            Cost = 3200, // vanilla 2600
            UseStatus = 34929, // vanilla 51569
            Effect = (Skill)0, // vanilla Skill.SmellingSaltsSkill
            EffectValue = 0, // vanilla 7
            Para2 = 2, // vanilla 1
            Para3 = 19, // vanilla 0
            Para1Post = 1289, // vanilla 5641
            Para2Post = 256, // vanilla 0
            Description = "+5 defense  +1 magic         ", // vanilla "+22 attack  [Cure Confusion]"
        },
        new()
        {
            Id = Item.RaincloudStaff,
            Note = "Raincloud Staff",
            Description = "+26 attack  Att: water [Snooze]", // vanilla "+26 attack  Att.: water [Snooze]"
        },
        new()
        {
            Id = Item.StaffOfLife,
            Note = "Ancient Staff",
            Effect = (Skill)28, // vanilla Skill.Protein
            Para3 = 19, // vanilla 0
            Para1Post = 11785, // vanilla 14857
            Para2Post = 512, // vanilla 0
            ShortName = "ANC STAFF", // vanilla "LIFESTAFF"
            Name = "Ancient Staff", // vanilla "Staff of Life"
            Description = "+46 attack  +2 magic  [Speedy]     ", // vanilla "+58 attack  [+2 HP level in combat]"
        },
        new()
        {
            Id = Item.WarpStaff,
            Note = "Warp Staff",
            Para1Post = 14601, // vanilla 9737
            Description = "+57 attack  Warps in combat", // vanilla "+38 attack  Warps in combat"
        },
        new()
        {
            Id = Item.SparklingRod,
            Note = "Magical Rod  ",
            Para2 = 19, // vanilla 1
            Para3 = 2, // vanilla 0
            Para1Post = 777, // vanilla 10761
            Para2Post = 1280, // vanilla 0
            ShortName = "MAGIC ROD", // vanilla "SPARK ROD"
            Name = "Magical Rod  ", // vanilla "Sparkling Rod"
            Description = "+3 magic  +5 defense  Mage's weapon", // vanilla "+42 attack  Speeds up spell casting"
        },
        new()
        {
            Id = Item.SpiritStaff,
            Note = "Spirit Staff",
            Effect = Skill.Protein, // vanilla Skill.Halvah
            EffectValue = 3, // vanilla 7
            Para1Post = 17417, // vanilla 16137
            Description = "+68 attack  [Star]            ", // vanilla "+63 attack  [Halvah in combat]"
        },
        new()
        {
            Id = Item.HomeRunHammer,
            Note = "Home Run Hammer",
            Para1Post = 10249, // vanilla 9225
            Description = "+40 attack  Belts 'em out", // vanilla "+36 attack  Belts 'em out"
        },
        new()
        {
            Id = Item.RustyShovel,
            Note = "Gaia's Rage ",
            Icon = 24, // vanilla 28
            Unknown7 = 17, // vanilla 37
            Unknown8 = 2, // vanilla 3
            Para1Post = 24329, // vanilla 521
            ShortName = "GAIA RAGE", // vanilla "RUSTSHOVL"
            Name = "Gaia's Rage ", // vanilla "Rusty Shovel"
            Description = "+95 attack  Enraged", // vanilla "+2 attack  Very old"
        },
        new()
        {
            Id = Item.DragonBoneAx,
            Note = "Dragon Bone Ax",
            Cost = 7500, // vanilla 10000
            Para3 = 2, // vanilla 4
            Para1Post = 12809, // vanilla 9737
            Description = "+50 attack  -10 defense    ", // vanilla "+38 attack  -10 move  Heavy"
        }
    ];
}
