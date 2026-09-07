using Grandia.Sdk;

namespace GrandiaRedux.Items;

/// <summary>
/// WINDT sec3 rows from id 128 that differ between HD Remaster
/// FIELD/WINDT.BIN and Redux 0.4.9. Unlisted fields stay vanilla.
/// Names / leftover sec3 bytes apply through OnItem (TEXT1 + WINDT).
/// </summary>
internal static class Ids128
{
    internal static readonly ItemEdit[] All =
    [
        new()
        {
            Id = Item.KleppsSickle,
            Note = "Klepp's Sickle",
            Para1Post = 7689, // vanilla 6409
            Description = "+30 attack  Weapon of Klepp soldiers", // vanilla "+25 attack  Weapon of Klepp soldiers"
        },
        new()
        {
            Id = Item.FrogAx,
            Note = "Frog Ax",
            Cost = 6300, // vanilla 4200
            UseStatus = 34929, // vanilla 51569
            Effect = (Skill)0, // vanilla Skill.Burn
            EffectValue = 0, // vanilla 50
            Para1Post = 8969, // vanilla 7177
            Description = "+35 attack  Has a frog emblem", // vanilla "+28 attack  Has a frog emblem"
        },
        new()
        {
            Id = Item.BoneSplitterAx,
            Note = "Bone Splitter Ax",
            Cost = 16000, // vanilla 9800
            Unknown13 = 0, // vanilla 9
            Unknown14 = 0, // vanilla 33
            Para1Pre = 0, // vanilla 1
            Para1Post = 13833, // vanilla 10505
            Description = "+54 attack  Sounds painful    ", // vanilla "+41 attack  Causes sudden death"
        },
        new()
        {
            Id = Item.EarthenAx,
            Note = "Spirit Ax ",
            Unknown12 = 0, // vanilla 144
            Para1Post = 25609, // vanilla 17417
            ShortName = "SPT AX", // vanilla "EARTH AX"
            Name = "Spirit Ax ", // vanilla "Earthen Ax"
            Description = "+100 attack  Best ax                 ", // vanilla "+68 attack  Att.: explosion; best ax"
        },
        new()
        {
            Id = Item.BusterAx,
            Note = "Buster Ax",
            Cost = 21000, // vanilla 32000
            Para1Post = 16905, // vanilla 13321
            Para2Post = 60416, // vanilla 59136
            Description = "+66 attack  -20 move  Very heavy", // vanilla "+52 attack  -25 move  Very heavy"
        },
        new()
        {
            Id = Item.WreckingAx,
            Note = "Wrecking Ax",
            Para1Post = 10761, // vanilla 8969
            Description = "+42 attack  Att.: explosion [BOOM!]", // vanilla "+35 attack  [BOOM!]"
        },
        new()
        {
            Id = Item.BentMattock,
            Note = "Ca-fu Cape  ",
            Cost = 50000, // vanilla 75
            Icon = 48, // vanilla 29
            UseStatus = 34934, // vanilla 34929
            Unknown7 = 16, // vanilla 33
            Unknown8 = 0, // vanilla 4
            Unknown27 = 0, // vanilla 6
            Para3 = 4, // vanilla 0
            Para1Post = 10240, // vanilla 1289
            Para2Post = 15360, // vanilla 0
            Para4Post = 512, // vanilla 2817
            ShortName = "CAFU CAPE", // vanilla "MATTOCK"
            Name = "Ca-fu Cape  ", // vanilla "Bent Mattock"
            Description = "+40 attack +60 move  Stolen", // vanilla "+5 attack  Bent and useless"
        },
        new()
        {
            Id = Item.HandmadeDarts,
            Note = "Handmade Darts",
            Para3 = 4, // vanilla 0
            Para2Post = 1280, // vanilla 0
            Description = "+7 attack  +5 move  Flys well   ", // vanilla "+7 attack  Fly surprisingly well"
        },
        new()
        {
            Id = Item.HuntersBow,
            Note = "Poison Bow  ",
            Unknown13 = 13, // vanilla 0
            Unknown14 = 33, // vanilla 0
            Para1Pre = 2, // vanilla 0
            Para1Post = 2569, // vanilla 4105
            ShortName = "POIS BOW", // vanilla "HUNT BOW"
            Name = "Poison Bow  ", // vanilla "Hunter's Bow"
            Description = "+10 attack  Slightly poisonous     ", // vanilla "+16 attack  Hunter's bow and arrows"
        },
        new()
        {
            Id = Item.CafuShuriken,
            Note = "Cafu Shuriken",
            Para3 = 4, // vanilla 0
            Para2Post = 3840, // vanilla 0
            Description = "+26 attack +15 move Cafu iron", // vanilla "+26 attack  Made of Cafu iron"
        },
        new()
        {
            Id = Item.Boomerang,
            Note = "Boomerang",
            Para1Post = 9481, // vanilla 8457
            Description = "+37 attack  Used for hunting", // vanilla "+33 attack  Used for hunting"
        },
        new()
        {
            Id = Item.FireDarts,
            Note = "Fire Darts",
            Para3 = 4, // vanilla 0
            Para2Post = 5632, // vanilla 0
            Description = "+41 attack +22 move Att:Fire", // vanilla "+41 attack  Attribute: fire"
        },
        new()
        {
            Id = Item.EvilShuriken,
            Note = "Evil Shuriken",
            Para3 = 4, // vanilla 3
            Para1Post = 19721, // vanilla 16393
            Para2Post = 10240, // vanilla 5120
            Description = "+77 attack  +40 move   Best shuriken", // vanilla "+64 attack  +20 action  Best shuriken"
        },
        new()
        {
            Id = Item.DemonslayerBoomer,
            Note = "Demonslayer Boomer",
            Cost = 30000, // vanilla 40000
            Para1Post = 18441, // vanilla 15369
            Description = "+72 attack  Effective on demons", // vanilla "+60 attack  Effective on demons"
        },
        new()
        {
            Id = Item.CactusThorns,
            Note = "Cactus Thorns",
            Para3 = 4, // vanilla 0
            Para2Post = 5120, // vanilla 0
            Description = "+38 attack  +20 move  Painful", // vanilla "+38 attack  Sharp and painful"
        },
        new()
        {
            Id = Item.IceBoomerang,
            Note = "Ice Boomerang",
            Cost = 18000, // vanilla 5000
            Para1Post = 14345, // vanilla 11785
            Description = "+56 attack  Attribute: blizzard", // vanilla "+46 attack  Attribute: blizzard"
        },
        new()
        {
            Id = Item.ThornyWhip,
            Note = "Thorny Whip",
            Cost = 1300, // vanilla 650
            Para3 = 36, // vanilla 0
            Para1Post = 4617, // vanilla 3849
            Para2Post = 256, // vanilla 0
            Description = "+18 attack  +1 skill power  ", // vanilla "+15 attack  Whip with thorns"
        },
        new()
        {
            Id = Item.CatfishWhiskers,
            Note = "Catfish Whiskers",
            Description = "+43 attack  Attribute: water        ", // vanilla "+43 attack  Att.: water Used as whip"
        },
        new()
        {
            Id = Item.GiantSnakeWhip,
            Note = "Giant Snake Whip",
            Cost = 8000, // vanilla 5400
        },
        new()
        {
            Id = Item.BindingWhip,
            Note = "Binding Whip",
            Unknown14 = 10, // vanilla 160
            Para1Pre = 3, // vanilla 0
            Para1Post = 11529, // vanilla 14345
            Description = "+45 attack  Temporarily binds enemy", // vanilla "+56 attack  Temporarily binds enemy"
        },
        new()
        {
            Id = Item.MorningStar,
            Note = "Morning Star",
            Cost = 13000, // vanilla 9600
            Para1Post = 14089, // vanilla 10249
            Description = "+55 attack -15 move  Heavy iron ball", // vanilla "+40 attack -15 move  Heavy iron ball"
        },
        new()
        {
            Id = Item.WhipOfLight,
            Note = "Whip of Light",
            Para1Post = 18697, // vanilla 16649
            Para2Post = 768, // vanilla 512
            Description = "+73 attack  +3 skill power level", // vanilla "+65 attack  +2 skill power level"
        },
        new()
        {
            Id = Item.GaleWhip,
            Note = "Gale Whip",
            Effect = Skill.Howl, // vanilla Skill.Runner
            EffectValue = 40, // vanilla 1
            Description = "+27 attack Attribute: wind  [Howl]  ", // vanilla "+27 attack"
        },
        new()
        {
            Id = Item.FlyingDragonVest,
            Note = "Flying Dragon Vest",
            Para2Post = 256, // vanilla 512
            Description = "+14 defense  +1 anti-fire level", // vanilla "+14 defense  +2 anti-fire level"
        },
        new()
        {
            Id = Item.FrogShirt,
            Note = "Frog Shirt",
            Para1Post = 3328, // vanilla 2560
            Description = "+13 defense  +1 anti-water level", // vanilla "+10 defense  +1 anti-water level"
        },
        new()
        {
            Id = Item.SpyClothes,
            Note = "Spy Clothes",
            Para3 = 4, // vanilla 0
            Para2Post = 3584, // vanilla 0
            Description = "+10 def +15 move  ", // vanilla "+10 defense  Stiff"
        },
        new()
        {
            Id = Item.BattleBikini,
            Note = "Battle Bikini",
            Para2Post = 2560, // vanilla 1024
            Description = "+10 defense +10 attack  Sexy", // vanilla "+10 defense  +4 attack  Sexy"
        },
        new()
        {
            Id = Item.MinkCoat,
            Note = "Mink Coat",
            Para2Post = 256, // vanilla 1280
            Para3Post = 256, // vanilla 1280
            Description = "+25 defense  +1 against blizzard", // vanilla "+25 defense  +5 against blizzard"
        },
        new()
        {
            Id = Item.EnchantressRobe,
            Note = "Enchantress' Robe",
            Unknown7 = 130, // vanilla 255
        },
        new()
        {
            Id = Item.AngelsRobe,
            Note = "Angel's Robe",
            Unknown7 = 130, // vanilla 255
            Description = "+33 defense  Regens HP over time  ", // vanilla "+33 defense  Restores HP in combat"
        },
        new()
        {
            Id = Item.RobeOfTheSun,
            Note = "Robe of the Sun",
            Unknown7 = 130, // vanilla 255
            Unknown12 = 0, // vanilla 16
            Unknown13 = 1, // vanilla 29
            Unknown14 = 25, // vanilla 128
            Para3 = 0, // vanilla 16
            Para1Post = 10752, // vanilla 11520
            Para2Post = 0, // vanilla 768
            Description = "+42 defense Speeds casting", // vanilla "+45 defense  Slows IP loss"
        },
        new()
        {
            Id = Item.ThickArmor,
            Note = "Thick Armor",
            Para3 = 1, // vanilla 0
            Para2Post = 1280, // vanilla 0
            Description = "+12 defense  +5 attack  Thick armor", // vanilla "+12 defense  Strong and thick armor"
        },
        new()
        {
            Id = Item.SwordfishArmor,
            Note = "Swordfish Armor",
            Cost = 3000, // vanilla 2100
            Para3 = 36, // vanilla 0
            Para2Post = 256, // vanilla 0
            Description = "+12 defense  +2 SP when attacked  ", // vanilla "+12 defense  Swordfish scale armor"
        },
        new()
        {
            Id = Item.AuraArmor,
            Note = "Aura Armor",
            Cost = 16000, // vanilla 20000
            Para1Post = 6144, // vanilla 8960
            Description = "+24 defense  Regen HP over time  ", // vanilla "+35 defense  +1 skill power level"
        },
        new()
        {
            Id = Item.DarkArmor,
            Note = "Dark Armor",
            Para2Post = 1024, // vanilla 768
            Description = "+22 defense Res +4 SP when damaged  ", // vanilla "+22 defense Restores SP when damaged"
        },
        new()
        {
            Id = Item.SpiritArmor,
            Note = "Spirit Armor",
            Unknown7 = 17, // vanilla 1
            Para1Post = 15360, // vanilla 14080
            Description = "+60 defense  Regens HP over time  ", // vanilla "+55 defense  Restores HP in combat"
        },
        new()
        {
            Id = Item.DevilsRobe,
            Note = "Devil's Robe",
            Para1Post = 7680, // vanilla 8192
            Description = "+30 defense  +1 all magic resistance", // vanilla "+32 defense  +2 all magic resistance"
        },
        new()
        {
            Id = Item.AlligatorGauntlet,
            Note = "Alligator Gauntlet",
            Para3 = 4, // vanilla 0
            Para2Post = 2560, // vanilla 0
            Description = "+12 defense +10 move  Light", // vanilla "+12 defense  Light and strong"
        },
        new()
        {
            Id = Item.LafaFlowerShield,
            Note = "Lafa Flower Shield",
            Cost = 10000, // vanilla 18000
            Unknown7 = 162, // vanilla 127
            Para3 = 3, // vanilla 19
            Para1Post = 3584, // vanilla 4864
            Para2Post = 3584, // vanilla 256
            Description = "+14 defense  +14 action  Beautiful ", // vanilla "+19 defense  +1 magic power level"
        },
        new()
        {
            Id = Item.PowerShield,
            Note = "Power Shield",
            Para2Post = 3840, // vanilla 1792
            Description = "+10 defense +15 attack  Powerful", // vanilla "+10 defense  +7 attack  Powerful"
        },
        new()
        {
            Id = Item.MoonlightShield,
            Note = "Moonlight Shield",
            Cost = 5000, // vanilla 5700
            Para1Post = 4352, // vanilla 5376
            Para2Post = 256, // vanilla 512
            Para3Post = 256, // vanilla 512
            Description = "+17 defense  +1 blizzard resistance", // vanilla "+21 defense  +2 blizzard resistance"
        },
        new()
        {
            Id = Item.Gauntlets,
            Note = "Gauntlets",
            Para1Post = 3840, // vanilla 5120
            Para2Post = 6400, // vanilla 2560
            Description = "+15 defense  +25 attack  A knight's", // vanilla "+20 defense  +10 attack  A knight's"
        },
        new()
        {
            Id = Item.DragonGauntlet,
            Note = "Dragon Gauntlet",
            Para3 = 1, // vanilla 0
            Para2Post = 2560, // vanilla 0
            Description = "+5 defense  +10 attack  Scales ", // vanilla "+5 defense  Made of dragon skin"
        },
        new()
        {
            Id = Item.HeavyShield,
            Note = "Heavy Shield",
            Para2Post = 57856, // vanilla 60416
            Description = "+23 defense  -30 move  Heavy", // vanilla "+23 defense  -20 move  Heavy"
        },
        new()
        {
            Id = Item.GauntletsOfLight,
            Note = "Gloves of Light   ",
            Unknown7 = 130, // vanilla 255
            Para3 = 19, // vanilla 33
            Para1Post = 7168, // vanilla 6400
            ShortName = "L GLOVES ", // vanilla "L GANTLET"
            Name = "Gloves of Light   ", // vanilla "Gauntlets of Light"
            Description = "+28 defense  +1 magic  Purified     ", // vanilla "+25 defense  +1 all magic resistance"
        },
        new()
        {
            Id = Item.SpiritShield,
            Note = "Spirit Shield",
            Para1Post = 8960, // vanilla 11520
            Para2Post = 512, // vanilla 1024
            Description = "+35 defense +2 all status resistance", // vanilla "+45 defense +4 all status resistance"
        },
        new()
        {
            Id = Item.MagicGloves,
            Note = "Magic Gloves",
            Unknown7 = 130, // vanilla 255
            Para3 = 19, // vanilla 0
            Para2Post = 256, // vanilla 0
            Description = "+20 defense  +1 magic  Pure white   ", // vanilla "+20 defense  Pure white, finely made"
        },
        new()
        {
            Id = Item.FeatheredTurban,
            Note = "Feathered Turban",
            Para3 = 4, // vanilla 0
            Para2Post = 6400, // vanilla 0
            Description = "+13 defense +25 move            ", // vanilla "+13 defense  Has pretty feathers"
        },
        new()
        {
            Id = Item.AngelsHat,
            Note = "Angel's Hat",
            Unknown7 = 130, // vanilla 255
            Unknown14 = 20, // vanilla 3
            Description = "+23 defense  Regen HP over time    ", // vanilla "+23 defense  Restores HP in attacks"
        },
        new()
        {
            Id = Item.PiratesHelmet,
            Note = "Pirate's Helmet",
            Para1Post = 2048, // vanilla 3072
            Description = "+8 defense   Ominous", // vanilla "+12 defense  Ominous"
        },
        new()
        {
            Id = Item.DeathMask,
            Note = "Death Mask",
            Para1Post = 5632, // vanilla 6656
            Para2Post = 512, // vanilla 65024
            Para3Post = 0, // vanilla 255
            Description = "+22 defense  Slows IP loss", // vanilla "+26 defense  Slows IP loss"
        },
        new()
        {
            Id = Item.CharismaHelm,
            Note = "Charisma Helm",
            Cost = 18000, // vanilla 23800
            Para2Post = 3840, // vanilla 7680
            Description = "+26 defense  +15 action", // vanilla "+26 defense  +30 action"
        },
        new()
        {
            Id = Item.SpiritHelmet,
            Note = "Spirit Helmet",
            Para1Post = 9728, // vanilla 10752
            Description = "+38 defense  Prevents sudden death", // vanilla "+42 defense  Prevents sudden death"
        },
        new()
        {
            Id = Item.HolyCrown,
            Note = "Holy Crown",
            Para1Post = 8192, // vanilla 9728
            Description = "+32 defense  Slows IP loss", // vanilla "+38 defense  Slows IP loss"
        },
        new()
        {
            Id = Item.FairyTiara,
            Note = "Fairy Tiara",
            Para1Post = 7680, // vanilla 8960
            Description = "+30 defense Prevents damage below 20", // vanilla "+35 defense Prevents damage below 20"
        },
        new()
        {
            Id = Item.MansHeadband,
            Note = "Man's Headband",
            Para1Post = 7936, // vanilla 7168
            Para2Post = 6400, // vanilla 3840
            Description = "+31 defense  +25 attack  Men only", // vanilla "+28 defense  +15 attack  Men only"
        },
        new()
        {
            Id = Item.DressShoes,
            Note = "Dress Shoes",
            Description = "+30 move  Itty-bitty shoes  ", // vanilla "+30 move Itty-bitty shoes"
        },
        new()
        {
            Id = Item.HuntersBoots,
            Note = "Hunter's Boots",
            Unknown7 = 127, // vanilla 255
        }
    ];
}
