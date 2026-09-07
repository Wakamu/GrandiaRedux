using Grandia.Sdk;

namespace GrandiaRedux.Enemies;

/// <summary>
/// Values that differ between HD Remaster <c>BATLE/M_DAT.BIN</c> and
/// Redux 0.4.9 <c>redux_content/BATLE/M_DAT.BIN</c>. Unlisted fields stay vanilla.
/// </summary>
internal static class Ids064
{
    internal static readonly EnemyEdit[] All =
    [
        new()
        {
            Species = Species.GaiaBrain,
            Note = "Gaia Brain",
            MaxHp = 4400, // vanilla 327
            Str = 430, // vanilla 141
            Wit = 550, // vanilla 157
            Exp = 4801, // vanilla 276
            Gold = 0, // vanilla 297
            AttackCount = 1, // vanilla 2
            AttackRange = 2, // vanilla 1
            WindResist = 9, // vanilla 8
            EarthResist = 7, // vanilla 11
            DropItem0 = Item.BlueMedicine, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Psychokinesis",
                    Power = 0, // vanilla -3
                    Speed = 70, // vanilla 30
                    Mode = (int)StatMod.Defense, // vanilla (int)StatMod.Move
                    AddAilment = (StatusAilment)19, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.BrainBat,
            Note = "Brain Bat",
            Level = 70, // vanilla 21
            MaxHp = 1233, // vanilla 294
            Str = 338, // vanilla 98
            Vit = 400, // vanilla 100
            Wit = 500, // vanilla 130
            Agi = 65, // vanilla 35
            Exp = 1684, // vanilla 30
            Gold = 2222, // vanilla 70
            AttackCount = 1, // vanilla 2
            AttackRange = 2, // vanilla 1
            FireResist = 12, // vanilla 13
            WaterResist = 12, // vanilla 13
            WindResist = 12, // vanilla 13
            EarthResist = 12, // vanilla 13
            DropItem0 = Item.BlueMedicine, // vanilla Item.SeedOfMagic
            DropRate0 = 30, // vanilla 4
            DropItem1 = Item.SeedOfMagic, // vanilla Item.FruitOfLife
            DropRate1 = 8, // vanilla 1
            Skills =
            [
                new SkillChange
                {
                    Name = "Body Blow",
                    Power = 110, // vanilla 120
                    AddAilment = (StatusAilment)16, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 3, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.ClayBird,
            Note = "Clay Bird",
            MaxHp = 1563, // vanilla 203
            Str = 86, // vanilla 55
            Vit = 90, // vanilla 45
            Wit = 150, // vanilla 45
            Agi = 45, // vanilla 23
            Exp = 500, // vanilla 75
            Gold = 1000, // vanilla 120
            WaterResist = 7, // vanilla 10
            WindResist = 5, // vanilla 10
            EarthResist = 7, // vanilla 11
            Skills =
            [
                new SkillChange
                {
                    Name = "Clay Breath",
                    Power = 26, // vanilla 25
                    Speed = 42, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.RockBird,
            Note = "Rock Bird",
            MaxHp = 450, // vanilla 230
            Wit = 46, // vanilla 13
            Skills =
            [
                new SkillChange
                {
                    Name = "Fire Orb",
                    Speed = 45, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.EmeraldBird,
            Note = "Emerald Bird",
            Level = 16, // vanilla 18
            MaxHp = 750, // vanilla 268
            Str = 66, // vanilla 60
            Vit = 50, // vanilla 45
            Wit = 90, // vanilla 50
            Agi = 50, // vanilla 26
            Exp = 300, // vanilla 100
            Gold = 150, // vanilla 200
            FireResist = 6, // vanilla 10
            WaterResist = 8, // vanilla 10
            WindResist = 8, // vanilla 10
            Skills =
            [
                new SkillChange
                {
                    Name = "Emerald Bomb",
                    Power = 10, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.SweetMoth,
            Note = "Sweet Moth",
            MaxHp = 1016, // vanilla 160
            Str = 113, // vanilla 90
            Vit = 30, // vanilla 40
            Wit = 260, // vanilla 150
            Exp = 141, // vanilla 60
            Gold = 96, // vanilla 51
            AttackRange = 2, // vanilla 1
            FireResist = 7, // vanilla 4
            WaterResist = 7, // vanilla 4
            WindResist = 7, // vanilla 4
            EarthResist = 7, // vanilla 11
            DropItem0 = Item.Honey, // vanilla Item.SwallowtailHat
            DropRate0 = 15, // vanilla 5
            DropItem1 = Item.SwallowtailHat, // vanilla Item.None
            DropRate1 = 5, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Sonar Flutter",
                    Power = 26, // vanilla 120
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.DizzyMoth,
            Note = "Dizzy Moth",
            Level = 27, // vanilla 24
            MaxHp = 1528, // vanilla 180
            Str = 184, // vanilla 100
            Vit = 100, // vanilla 35
            Wit = 245, // vanilla 110
            Agi = 38, // vanilla 24
            Exp = 387, // vanilla 56
            Gold = 300, // vanilla 58
            AttackRange = 2, // vanilla 1
            FireResist = 9, // vanilla 4
            WaterResist = 9, // vanilla 4
            WindResist = 7, // vanilla 4
            EarthResist = 10, // vanilla 11
            DropItem0 = Item.Honey, // vanilla Item.None
            DropRate0 = 25, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Poison Scales",
                    Power = 45, // vanilla 140
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    Chance = 59, // vanilla 100
                }
            ],
        },
        new()
        {
            Species = Species.GiantMoth,
            Note = "Giant Moth",
            Level = 31, // vanilla 15
            MaxHp = 1997, // vanilla 235
            Str = 179, // vanilla 123
            Wit = 333, // vanilla 300
            Agi = 37, // vanilla 25
            Exp = 469, // vanilla 34
            Gold = 358, // vanilla 36
            AttackRange = 2, // vanilla 1
            WaterResist = 5, // vanilla 4
            WindResist = 5, // vanilla 4
            EarthResist = 12, // vanilla 11
            DropItem0 = Item.BamoFruit, // vanilla Item.SpellBreaker
            DropRate0 = 16, // vanilla 10
            Skills =
            [
                new SkillChange
                {
                    Name = "Sonar",
                    Power = 45, // vanilla 100
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    AddLevel = 2, // vanilla 3
                }
            ],
        },
        new()
        {
            Species = Species.PlopMold,
            Note = "Plop Mold",
            MaxHp = 462, // vanilla 129
            Str = 82, // vanilla 62
            Wit = 130, // vanilla 25
            Agi = 75, // vanilla 25
            Exp = 67, // vanilla 15
            Gold = 68, // vanilla 24
            FireResist = 6, // vanilla 4
            WaterResist = 10, // vanilla 6
            WindResist = 10, // vanilla 5
            EarthResist = 6, // vanilla 11
            Skills =
            [
                new SkillChange
                {
                    Name = "Poison Spores",
                    Power = 18, // vanilla 100
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.MoldBird,
            Note = "Mold Bird",
            MaxHp = 598, // vanilla 140
            Str = 95, // vanilla 68
            Vit = 20, // vanilla 35
            Wit = 130, // vanilla 45
            Agi = 50, // vanilla 25
            Exp = 75, // vanilla 35
            Gold = 81, // vanilla 19
            FireResist = 6, // vanilla 5
            WaterResist = 7, // vanilla 10
            EarthResist = 8, // vanilla 11
            DropRate0 = 15, // vanilla 5
            DropItem1 = Item.ChollaFlowers, // vanilla Item.None
            DropRate1 = 15, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Plague Spores",
                    Power = 16, // vanilla 100
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    Chance = 50, // vanilla 11
                }
            ],
        },
        new()
        {
            Species = Species.GaiaMold,
            Note = "Gaia Mold",
            Level = 90, // vanilla 82
            MaxHp = 800, // vanilla 288
            Str = 450, // vanilla 150
            Wit = 1600, // vanilla 100
            Agi = 200, // vanilla 27
            Exp = 2000, // vanilla 205
            Gold = 0, // vanilla 276
            FireResist = 10, // vanilla 6
            WaterResist = 10, // vanilla 6
            WindResist = 10, // vanilla 6
            EarthResist = 10, // vanilla 11
            DropItem0 = Item.BamoFruit, // vanilla Item.None
            DropRate0 = 50, // vanilla 0
            DropItem1 = Item.CultureMedium, // vanilla Item.None
            DropRate1 = 20, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Germ Spores",
                    Power = 49, // vanilla 110
                    Speed = 10, // vanilla 30
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    Chance = 50, // vanilla 100
                    AddLevel = 2, // vanilla 5
                }
            ],
        },
        new()
        {
            Species = Species.MarnaBug,
            Note = "Marna Bug",
            MaxHp = 24, // vanilla 18
            Str = 21, // vanilla 18
            Wit = 30, // vanilla 13
            Agi = 50, // vanilla 30
            DropItem0 = Item.Herbs, // vanilla Item.None
            DropRate0 = 10, // vanilla 0
        },
        new()
        {
            Species = Species.Beetlebug,
            Note = "Beetlebug",
            MaxHp = 286, // vanilla 108
            Str = 64, // vanilla 55
            Vit = 38, // vanilla 32
            Wit = 132, // vanilla 100
            Exp = 39, // vanilla 9
            Gold = 39, // vanilla 50
            FireResist = 9, // vanilla 7
            WaterResist = 6, // vanilla 7
            WindResist = 9, // vanilla 5
            EarthResist = 8, // vanilla 9
            DropItem0 = Item.SmellingSalts, // vanilla Item.None
            DropRate0 = 28, // vanilla 0
        },
        new()
        {
            Species = Species.MetalBeetle,
            Note = "Metal Beetle",
            MaxHp = 240, // vanilla 60
            Str = 64, // vanilla 50
            Vit = 25, // vanilla 45
            Wit = 65, // vanilla 20
            Exp = 26, // vanilla 25
            Gold = 41, // vanilla 50
            DropItem0 = Item.OverflowingWalnut, // vanilla Item.None
            DropRate0 = 20, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Wing Sonar",
                    Power = 15, // vanilla 120
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.ZilScorpion,
            Note = "Zil Scorpion",
            Level = 23, // vanilla 18
            MaxHp = 814, // vanilla 248
            Str = 156, // vanilla 106
            Vit = 165, // vanilla 55
            Wit = 170, // vanilla 90
            Agi = 30, // vanilla 20
            Exp = 215, // vanilla 58
            Gold = 182, // vanilla 30
            FireResist = 12, // vanilla 13
            WaterResist = 11, // vanilla 4
            WindResist = 11, // vanilla 7
            EarthResist = 11, // vanilla 7
            DropItem0 = Item.SmarnaWeed, // vanilla Item.None
            DropRate0 = 15, // vanilla 0
            DropItem1 = Item.LeafShield, // vanilla Item.None
            DropRate1 = 5, // vanilla 0
        },
        new()
        {
            Species = Species.Scissorlock,
            Note = "Scissorlock",
            Level = 70, // vanilla 21
            MaxHp = 7667, // vanilla 289
            Str = 466, // vanilla 116
            Vit = 320, // vanilla 68
            Wit = 450, // vanilla 63
            Agi = 70, // vanilla 23
            Exp = 7836, // vanilla 65
            Gold = 5, // vanilla 76
            FireResist = 12, // vanilla 7
            WaterResist = 12, // vanilla 7
            WindResist = 11, // vanilla 7
            EarthResist = 11, // vanilla 7
            DropItem0 = Item.AllAroundSeed, // vanilla Item.None
            DropRate0 = 25, // vanilla 0
            DropItem1 = Item.RobeOfTheSun, // vanilla Item.None
            DropRate1 = 3, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Quick Quills",
                    Power = -5, // vanilla -2
                    Speed = 10, // vanilla 30
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.Poison
                    AddLevel = 3, // vanilla 6
                }
            ],
        },
        new()
        {
            Species = Species.GaiaDemon,
            Note = "Gaia Demon",
            Level = 56, // vanilla 89
            MaxHp = 3600, // vanilla 426
            Str = 287, // vanilla 170
            Vit = 30, // vanilla 85
            Wit = 355, // vanilla 163
            Exp = 1268, // vanilla 293
            Gold = 672, // vanilla 316
            FireResist = 7, // vanilla 8
            WaterResist = 6, // vanilla 8
            WindResist = 6, // vanilla 8
            EarthResist = 3, // vanilla 8
            DropItem0 = Item.OrbOfSilence, // vanilla Item.None
            DropRate0 = 15, // vanilla 0
            DropItem1 = Item.ResurrectPotion441, // vanilla Item.None
            DropRate1 = 10, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Quick Quills",
                    Speed = 45, // vanilla 30
                    AddAilment = (StatusAilment)16, // vanilla (StatusAilment)17
                    AddLevel = 2, // vanilla 3
                }
            ],
        },
        new()
        {
            Species = Species.Crimsona,
            Note = "Crimsona",
            Level = 38, // vanilla 31
            MaxHp = 880, // vanilla 288
            Str = 225, // vanilla 133
            Vit = 500, // vanilla 300
            Wit = 300, // vanilla 118
            Agi = 40, // vanilla 20
            Exp = 719, // vanilla 108
            Gold = 480, // vanilla 110
            FireResist = 11, // vanilla 3
            WaterResist = 11, // vanilla 3
            WindResist = 11, // vanilla 3
            EarthResist = 10, // vanilla 3
            DropRate0 = 10, // vanilla 5
            DropItem1 = Item.TortesWhistle, // vanilla Item.None
            DropRate1 = 15, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Head Dance",
                    Power = 74, // vanilla 125
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    AddAilment = StatusAilment.Sleep, // vanilla StatusAilment.Confuse
                    Chance = 80, // vanilla 20
                }
            ],
        },
        new()
        {
            Species = Species.GaiaAlien,
            Note = "Gaia Alien",
            Level = 95, // vanilla 71
            MaxHp = 8000, // vanilla 335
            Str = 440, // vanilla 157
            Wit = 800, // vanilla 136
            Agi = 80, // vanilla 25
            Exp = 11846, // vanilla 283
            Gold = 0, // vanilla 321
            AttackCount = 2, // vanilla 1
            AttackRange = 3, // vanilla 2
            FireResist = 14, // vanilla 5
            WaterResist = 14, // vanilla 5
            WindResist = 14, // vanilla 5
            EarthResist = 14, // vanilla 5
            DropItem0 = Item.YellowMedicine, // vanilla Item.ManaEgg
            DropRate0 = 70, // vanilla 5
            DropItem1 = Item.QueenHeels, // vanilla Item.None
            DropRate1 = 35, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Head Step",
                    Power = 125, // vanilla 120
                    Speed = 20, // vanilla 30
                    AddAilment = (StatusAilment)20, // vanilla (StatusAilment)19
                    AddLevel = 7, // vanilla 5
                }
            ],
        },
        new()
        {
            Species = Species.Spyder,
            Note = "Spyder",
            Level = 5, // vanilla 4
            MaxHp = 60, // vanilla 36
            Str = 28, // vanilla 21
            Wit = 28, // vanilla 16
            DropItem0 = Item.Herbs, // vanilla Item.None
            DropRate0 = 18, // vanilla 0
        },
        new()
        {
            Species = Species.BlackWidow,
            Note = "Black Widow",
            MaxHp = 106, // vanilla 53
            Str = 41, // vanilla 30
            Vit = 16, // vanilla 13
            Wit = 55, // vanilla 29
            Agi = 60, // vanilla 30
            Exp = 5, // vanilla 6
            Gold = 11, // vanilla 13
            DropItem0 = Item.BambooShoots, // vanilla Item.None
            DropRate0 = 15, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Gummy Fluid",
                    AddAilment = (StatusAilment)16, // vanilla (StatusAilment)17
                    AddLevel = 1, // vanilla 2
                }
            ],
        },
        new()
        {
            Species = Species.Tarantula,
            Note = "Tarantula",
            MaxHp = 352, // vanilla 98
            Str = 67, // vanilla 55
            Wit = 96, // vanilla 50
            Agi = 75, // vanilla 25
            FireResist = 9, // vanilla 7
            EarthResist = 11, // vanilla 7
            DropItem0 = Item.ParalysisOintment, // vanilla Item.SpellBreaker
            DropRate0 = 16, // vanilla 10
            DropItem1 = Item.PoisonAntidote367, // vanilla Item.None
            DropRate1 = 13, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Gooey Fluid",
                    Speed = 20, // vanilla 30
                    AddAilment = StatusAilment.Sleep, // vanilla (StatusAilment)17
                    Chance = 80, // vanilla 100
                }
            ],
        },
        new()
        {
            Species = Species.Ammonite,
            Note = "Ammonite",
            Level = 4, // vanilla 3
            MaxHp = 132, // vanilla 56
            Str = 40, // vanilla 27
            Vit = 30, // vanilla 24
            Wit = 60, // vanilla 22
            Exp = 8, // vanilla 5
            FireResist = 11, // vanilla 7
            Skills =
            [
                new SkillChange
                {
                    Name = "Spin Attack",
                    Power = 120, // vanilla 140
                }
            ],
        },
        new()
        {
            Species = Species.MadSnail,
            Note = "Mad Snail",
            MaxHp = 135, // vanilla 60
            Str = 48, // vanilla 35
            Vit = 40, // vanilla 26
            Wit = 70, // vanilla 28
            Agi = 20, // vanilla 8
            Gold = 20, // vanilla 40
            FireResist = 7, // vanilla 2
            WindResist = 8, // vanilla 2
            DropItem0 = Item.SmarnaWeed, // vanilla Item.None
            DropRate0 = 14, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Spin Attack",
                    Power = 112, // vanilla 130
                }
            ],
        },
        new()
        {
            Species = Species.GaiaCyst,
            Note = "Gaia Cyst",
            MaxHp = 14000, // vanilla 4500
            Vit = 220, // vanilla 98
            Wit = 1800, // vanilla 250
            Exp = 0, // vanilla 2270
            Gold = 0, // vanilla 100
            FireResist = 12, // vanilla 14
            WaterResist = 12, // vanilla 14
            WindResist = 12, // vanilla 14
            EarthResist = 12, // vanilla 14
            Skills =
            [
                new SkillChange
                {
                    Name = "Seed Smash",
                    Power = 67, // vanilla 35
                    Speed = 30, // vanilla 60
                }
            ],
        },
        new()
        {
            Species = Species.SeaJelly,
            Note = "Sea Jelly",
            MaxHp = 144, // vanilla 68
            Str = 39, // vanilla 29
            Vit = 21, // vanilla 8
            Wit = 65, // vanilla 28
            Exp = 6, // vanilla 5
            DropItem0 = Item.MikeromaScroll, // vanilla Item.None
            DropRate0 = 10, // vanilla 0
        },
        new()
        {
            Species = Species.MudJelly,
            Note = "Mud Jelly",
            MaxHp = 123, // vanilla 73
            Str = 48, // vanilla 35
            Vit = 21, // vanilla 16
            Wit = 46, // vanilla 15
            Agi = 38, // vanilla 12
            Exp = 7, // vanilla 10
            Gold = 12, // vanilla 17
            FireResist = 7, // vanilla 0
            WaterResist = 7, // vanilla 9
            WindResist = 5, // vanilla 2
            EarthResist = 9, // vanilla 7
            DropItem0 = Item.SnoozeScroll, // vanilla Item.None
            DropRate0 = 12, // vanilla 0
        },
        new()
        {
            Species = Species.HermitCrab,
            Note = "Hermit Crab",
            MaxHp = 545, // vanilla 94
            Str = 128, // vanilla 81
            Vit = 124, // vanilla 100
            Wit = 90, // vanilla 30
            Agi = 33, // vanilla 24
            Exp = 150, // vanilla 56
            Gold = 90, // vanilla 120
            DropItem0 = Item.SmarnaWeed, // vanilla Item.None
            DropRate0 = 18, // vanilla 0
            DropItem1 = Item.YellowMedicine, // vanilla Item.None
            DropRate1 = 12, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Lean Over",
                    Power = 112, // vanilla 125
                    AddAilment = (StatusAilment)15, // vanilla (StatusAilment)13
                    AddLevel = 2, // vanilla 5
                }
            ],
        },
        new()
        {
            Species = Species.Scarab,
            Note = "Scarab",
            Level = 50, // vanilla 45
            MaxHp = 2450, // vanilla 228
            Str = 324, // vanilla 138
            Wit = 280, // vanilla 99
            Exp = 1342, // vanilla 120
            Gold = 555, // vanilla 500
            FireResist = 9, // vanilla 4
            WaterResist = 9, // vanilla 4
            WindResist = 10, // vanilla 4
            EarthResist = 7, // vanilla 4
            DropItem0 = Item.SmarnaWeed, // vanilla Item.None
            DropRate0 = 16, // vanilla 0
            DropItem1 = Item.Scarab, // vanilla Item.None
            DropRate1 = 6, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Earth Attack",
                    Power = 120, // vanilla 115
                    Element = CombatElement.Earth, // vanilla CombatElement.None
                    AddAilment = StatusAilment.Paralyze, // vanilla (StatusAilment)13
                    Chance = 80, // vanilla 100
                    AddLevel = 3, // vanilla 5
                }
            ],
        },
        new()
        {
            Species = Species.GaiaCancer,
            Note = "Gaia Cancer",
            Level = 95, // vanilla 71
            MaxHp = 5600, // vanilla 327
            Str = 550, // vanilla 150
            Vit = 3000, // vanilla 225
            Wit = 400, // vanilla 130
            Agi = 40, // vanilla 19
            Exp = 6981, // vanilla 271
            Gold = 0, // vanilla 309
            AttackRange = 3, // vanilla 2
            FireResist = 4, // vanilla 9
            WindResist = 2, // vanilla 9
            EarthResist = 4, // vanilla 9
            DropItem0 = Item.Weeds, // vanilla Item.None
            DropRate0 = 80, // vanilla 0
            DropItem1 = Item.EarthCharm, // vanilla Item.None
            DropRate1 = 25, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Earth Pound",
                    Power = 112, // vanilla 120
                    Speed = 45, // vanilla 30
                    Element = CombatElement.Earth, // vanilla CombatElement.None
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    AddAilment = (StatusAilment)13, // vanilla StatusAilment.None
                    Chance = 40, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.SeaStar,
            Note = "Sea Star",
            MaxHp = 2137, // vanilla 275
            Str = 187, // vanilla 120
            Vit = 80, // vanilla 55
            Wit = 350, // vanilla 100
            Agi = 100, // vanilla 30
            Exp = 500, // vanilla 85
            Gold = 399, // vanilla 80
            FireResist = 6, // vanilla 3
            WaterResist = 4, // vanilla 10
            WindResist = 4, // vanilla 10
            EarthResist = 7, // vanilla 11
            DropItem0 = Item.MoveMushroom, // vanilla Item.MoveBreaker
            DropRate0 = 12, // vanilla 10
            DropItem1 = Item.Panacea, // vanilla Item.None
            DropRate1 = 12, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Crush",
                    Power = 116, // vanilla 110
                    Speed = 50, // vanilla 30
                    AddAilment = StatusAilment.Stop, // vanilla (StatusAilment)17
                    Chance = 50, // vanilla 100
                }
            ],
        },
        new()
        {
            Species = Species.Starfish,
            Note = "Starfish (vanilla HP 408)",
            When = e => e.MaxHp == 408 && e.Level == 67,
        },
        new()
        {
            Species = Species.Starfish,
            Note = "Starfish (vanilla HP 108)",
            When = e => e.MaxHp == 108 && e.Level == 97,
        },
        new()
        {
            Species = Species.GaiaStar,
            Note = "Gaia Star",
            Level = 95, // vanilla 91
            MaxHp = 7300, // vanilla 317
            Str = 445, // vanilla 143
            Wit = 570, // vanilla 147
            Agi = 100, // vanilla 22
            Exp = 7183, // vanilla 235
            Gold = 0, // vanilla 317
            FireResist = 6, // vanilla 8
            WindResist = 6, // vanilla 8
            EarthResist = 6, // vanilla 11
            DropItem0 = Item.BlueMedicine, // vanilla Item.None
            DropRate0 = 80, // vanilla 0
            DropItem1 = Item.MagicLipstick, // vanilla Item.None
            DropRate1 = 25, // vanilla 0
        },
        new()
        {
            Species = Species.BlueKite,
            Note = "Blue Kite",
            MaxHp = 640, // vanilla 135
            Str = 90, // vanilla 69
            Vit = 110, // vanilla 100
            Wit = 180, // vanilla 100
            Exp = 90, // vanilla 35
            Gold = 83, // vanilla 27
            AttackCount = 2, // vanilla 1
            AttackRange = 3, // vanilla 2
            FireResist = 5, // vanilla 2
            WaterResist = 5, // vanilla 2
            WindResist = 5, // vanilla 2
            EarthResist = 5, // vanilla 2
            DropItem0 = Item.FreesiaFlowers, // vanilla Item.None
            DropRate0 = 8, // vanilla 0
            DropItem1 = Item.MikeromaScroll, // vanilla Item.None
            DropRate1 = 12, // vanilla 0
        },
        new()
        {
            Species = Species.MantaRay,
            Note = "Manta Ray",
            MaxHp = 763, // vanilla 276
            Str = 100, // vanilla 70
            Vit = 80, // vanilla 20
            Wit = 150, // vanilla 95
            Agi = 50, // vanilla 35
            Exp = 137, // vanilla 60
            Gold = 125, // vanilla 29
            AttackCount = 2, // vanilla 1
            FireResist = 6, // vanilla 12
            WaterResist = 6, // vanilla 0
            WindResist = 6, // vanilla 0
            EarthResist = 6, // vanilla 12
            Skills =
            [
                new SkillChange
                {
                    Name = "Bombs Away",
                    Power = 29, // vanilla 17
                }
            ],
        },
        new()
        {
            Species = Species.Stingray,
            Note = "Stingray",
            Level = 60, // vanilla 69
            MaxHp = 4474, // vanilla 392
            Str = 440, // vanilla 160
            Vit = 270, // vanilla 60
            Wit = 355, // vanilla 125
            Exp = 1873, // vanilla 182
            Gold = 0, // vanilla 182
            FireResist = 9, // vanilla 3
            WaterResist = 9, // vanilla 3
            WindResist = 9, // vanilla 3
            EarthResist = 9, // vanilla 3
            DropItem0 = Item.Weeds, // vanilla Item.None
            DropRate0 = 70, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Flight Bomb",
                    Power = 100, // vanilla 38
                    Element = CombatElement.None, // vanilla CombatElement.Fire
                    AddAilment = (StatusAilment)16, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.SandDiver,
            Note = "Sand Diver",
            Level = 8, // vanilla 10
            MaxHp = 242, // vanilla 78
            Str = 44, // vanilla 47
            Vit = 43, // vanilla 27
            Wit = 100, // vanilla 33
            Agi = 80, // vanilla 38
            Exp = 21, // vanilla 11
            Gold = 50, // vanilla 100
            AttackCount = 4, // vanilla 1
            FireResist = 10, // vanilla 7
            WaterResist = 10, // vanilla 7
            EarthResist = 4, // vanilla 2
            DropItem0 = Item.SmarnaWeed, // vanilla Item.None
            DropRate0 = 20, // vanilla 0
            DropItem1 = Item.DriedFish, // vanilla Item.None
            DropRate1 = 16, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Sand Shower",
                    Power = 0, // vanilla -2
                    Speed = 45, // vanilla 30
                    Mode = (int)StatMod.Defense, // vanilla (int)StatMod.Attack
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.SandMan,
            Note = "Sand Man",
            Level = 41, // vanilla 13
            MaxHp = 2977, // vanilla 268
            Str = 240, // vanilla 120
            Vit = 160, // vanilla 85
            Wit = 370, // vanilla 105
            Agi = 70, // vanilla 23
            Exp = 1231, // vanilla 13
            Gold = 700, // vanilla 30
            AttackCount = 2, // vanilla 1
            FireResist = 9, // vanilla 13
            WaterResist = 9, // vanilla 13
            WindResist = 9, // vanilla 13
            EarthResist = 9, // vanilla 13
            DropItem0 = Item.SquidGuts, // vanilla Item.None
            DropRate0 = 10, // vanilla 0
            DropItem1 = Item.ChollaFlowers, // vanilla Item.None
            DropRate1 = 15, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Sandstorm",
                    Power = 118, // vanilla 100
                    Element = CombatElement.Earth, // vanilla CombatElement.None
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    AddAilment = (StatusAilment)14, // vanilla StatusAilment.Plague
                    Chance = 100, // vanilla 30
                    AddLevel = 3, // vanilla 5
                }
            ],
        },
        new()
        {
            Species = Species.GaiaScorpion,
            Note = "Gaia Scorpion",
            Level = 55, // vanilla 41
            MaxHp = 2500, // vanilla 312
            Str = 295, // vanilla 150
            Vit = 150, // vanilla 80
            Wit = 355, // vanilla 155
            Exp = 1306, // vanilla 182
            Gold = 641, // vanilla 176
            AttackCount = 1, // vanilla 0
            AttackRange = 2, // vanilla 1
            WaterResist = 9, // vanilla 7
            WindResist = 9, // vanilla 10
            EarthResist = 9, // vanilla 7
            DropItem0 = Item.YellowMedicine, // vanilla Item.PrettyJewel
            DropRate0 = 15, // vanilla 5
            DropItem1 = Item.PrettyJewel, // vanilla Item.None
            DropRate1 = 4, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Poison Quills",
                    Power = 110, // vanilla 120
                }
            ],
        },
        new()
        {
            Species = Species.GiantCentipede,
            Note = "Giant Centipede",
            MaxHp = 48, // vanilla 32
            Str = 22, // vanilla 19
            Wit = 16, // vanilla 9
            DropItem0 = Item.Herbs, // vanilla Item.None
            DropRate0 = 16, // vanilla 0
        },
        new()
        {
            Species = Species.Inchworm,
            Note = "Inchworm",
            MaxHp = 181, // vanilla 65
            Str = 50, // vanilla 41
            Wit = 62, // vanilla 25
            Agi = 25, // vanilla 10
            Gold = 14, // vanilla 20
            FireResist = 8, // vanilla 6
            WaterResist = 8, // vanilla 6
            WindResist = 9, // vanilla 6
            EarthResist = 9, // vanilla 6
            DropRate0 = 6, // vanilla 3
            DropItem1 = Item.WhiteSulfaWeed, // vanilla Item.None
            DropRate1 = 14, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Sleep Gas",
                    Power = 10, // vanilla 113
                    Speed = 80, // vanilla 30
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    Chance = 80, // vanilla 100
                }
            ],
        },
        new()
        {
            Species = Species.Roadcrawler,
            Note = "Roadcrawler",
            MaxHp = 90, // vanilla 40
            Str = 42, // vanilla 33
            Wit = 38, // vanilla 26
            Agi = 24, // vanilla 14
            Exp = 5, // vanilla 7
            Gold = 8, // vanilla 15
            DropRate0 = 20, // vanilla 15
            Skills =
            [
                new SkillChange
                {
                    Name = "Poison Gas",
                    Power = 8, // vanilla 140
                    Speed = 50, // vanilla 30
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    Chance = 70, // vanilla 50
                }
            ],
        },
        new()
        {
            Species = Species.SpittingCobra,
            Note = "Spitting Cobra",
            MaxHp = 112, // vanilla 60
            Str = 43, // vanilla 31
            Vit = 17, // vanilla 15
            Wit = 55, // vanilla 32
            Agi = 26, // vanilla 20
            Exp = 5, // vanilla 6
            Gold = 10, // vanilla 14
            DropRate0 = 15, // vanilla 10
            DropItem1 = Item.BambooShoots, // vanilla Item.None
            DropRate1 = 10, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Spew Poison",
                    Power = 6, // vanilla 115
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.PitViper,
            Note = "Pit Viper",
            MaxHp = 387, // vanilla 124
            Str = 65, // vanilla 59
            Wit = 80, // vanilla 47
            Agi = 68, // vanilla 35
            Exp = 29, // vanilla 21
            FireResist = 8, // vanilla 7
            WaterResist = 8, // vanilla 7
            WindResist = 8, // vanilla 7
            EarthResist = 8, // vanilla 7
            DropItem0 = Item.ParalysisOintment, // vanilla Item.MoveBreaker
            DropRate0 = 13, // vanilla 10
            Skills =
            [
                new SkillChange
                {
                    Name = "Paralyze Fluid",
                    Power = 6, // vanilla 115
                    Speed = 70, // vanilla 30
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.SandWorm,
            Note = "Sand Worm",
            MaxHp = 1258, // vanilla 195
            Str = 159, // vanilla 116
            Wit = 210, // vanilla 75
            Agi = 35, // vanilla 20
            Exp = 324, // vanilla 60
            Gold = 236, // vanilla 52
            FireResist = 11, // vanilla 10
            WaterResist = 11, // vanilla 7
            WindResist = 6, // vanilla 1
            EarthResist = 10, // vanilla 4
            DropItem0 = Item.Honey, // vanilla Item.None
            DropRate0 = 15, // vanilla 0
            DropItem1 = Item.SnoozeScroll, // vanilla Item.None
            DropRate1 = 10, // vanilla 0
        },
        new()
        {
            Species = Species.SandSnake,
            Note = "Sand Snake",
            MaxHp = 2751, // vanilla 388
            Str = 265, // vanilla 132
            Wit = 325, // vanilla 116
            Agi = 36, // vanilla 24
            Exp = 1114, // vanilla 103
            Gold = 583, // vanilla 97
            WaterResist = 9, // vanilla 5
            WindResist = 3, // vanilla 10
            EarthResist = 6, // vanilla 5
            DropItem0 = Item.ChollaFlowers, // vanilla Item.None
            DropRate0 = 20, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Sandwave",
                    Power = 55, // vanilla 115
                    Element = CombatElement.Earth, // vanilla CombatElement.None
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.GaiaSnake,
            Note = "Gaia Snake",
            Level = 59, // vanilla 57
            MaxHp = 3900, // vanilla 311
            Str = 325, // vanilla 160
            Wit = 415, // vanilla 130
            Exp = 1874, // vanilla 182
            Gold = 837, // vanilla 177
            AttackCount = 1, // vanilla 0
            AttackRange = 2, // vanilla 1
            FireResist = 7, // vanilla 11
            WaterResist = 9, // vanilla 7
            WindResist = 6, // vanilla 11
            EarthResist = 7, // vanilla 4
            DropItem0 = Item.BlueMedicine, // vanilla Item.PrettyJewel436
            DropRate0 = 20, // vanilla 3
            DropItem1 = Item.PrettyJewel436, // vanilla Item.None
            DropRate1 = 5, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Crush",
                    Power = 120, // vanilla 125
                    Speed = 50, // vanilla 30
                    AddAilment = (StatusAilment)18, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Chameleon,
            Note = "Chameleon",
            Level = 21, // vanilla 99
            MaxHp = 837, // vanilla 210
            Str = 133, // vanilla 90
            Vit = 85, // vanilla 100
            Wit = 215, // vanilla 100
            Exp = 227, // vanilla 60
            Gold = 500, // vanilla 600
            FireResist = 10, // vanilla 12
            WaterResist = 10, // vanilla 12
            WindResist = 10, // vanilla 12
            EarthResist = 10, // vanilla 12
            DropItem0 = Item.FreesiaFlowers, // vanilla Item.ChameleonArmor
            DropRate0 = 13, // vanilla 2
            DropItem1 = Item.ChameleonArmor, // vanilla Item.None
            Skills =
            [
                new SkillChange
                {
                    Name = "Tail Attack",
                    Power = 105, // vanilla 140
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Alligator,
            Note = "Alligator",
            Level = 21, // vanilla 26
            MaxHp = 962, // vanilla 245
            Str = 146, // vanilla 118
            Wit = 215, // vanilla 107
            Agi = 200, // vanilla 98
            Exp = 241, // vanilla 300
            Gold = 112, // vanilla 60
            AttackRange = 4, // vanilla 3
            FireResist = 9, // vanilla 5
            WindResist = 3, // vanilla 5
            EarthResist = 4, // vanilla 5
            DropItem0 = Item.FreesiaFlowers, // vanilla Item.None
            DropRate0 = 15, // vanilla 0
            DropItem1 = Item.ParalysisCharm, // vanilla Item.None
            DropRate1 = 8, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Para Tail",
                    Power = 105, // vanilla 125
                }
            ],
        },
        new()
        {
            Species = Species.Salamadile,
            Note = "Salamadile",
            Level = 31, // vanilla 17
            MaxHp = 807, // vanilla 312
            Str = 157, // vanilla 123
            Vit = 155, // vanilla 999
            Wit = 240, // vanilla 200
            Agi = 55, // vanilla 19
            Exp = 388, // vanilla 30
            Gold = 334, // vanilla 200
            AttackCount = 5, // vanilla 1
            WaterResist = 14, // vanilla 4
            WindResist = 14, // vanilla 4
            EarthResist = 10, // vanilla 4
            DropRate0 = 7, // vanilla 5
            DropItem1 = Item.PrettyJewel435, // vanilla Item.PrettyJewel436
            DropRate1 = 3, // vanilla 2
            Skills =
            [
                new SkillChange
                {
                    Name = "Para Tail",
                    Power = 108, // vanilla 120
                    Speed = 15, // vanilla 30
                    Chance = 80, // vanilla 25
                }
            ],
        },
        new()
        {
            Species = Species.GillNewt,
            Note = "Gill Newt",
            Level = 38, // vanilla 36
            MaxHp = 2135, // vanilla 316
            Str = 227, // vanilla 121
            Vit = 80, // vanilla 68
            Wit = 320, // vanilla 170
            Agi = 60, // vanilla 25
            Exp = 707, // vanilla 91
            Gold = 436, // vanilla 107
            WindResist = 8, // vanilla 7
            EarthResist = 6, // vanilla 7
            DropItem0 = Item.ZapBook, // vanilla Item.Scarab
            DropRate0 = 14, // vanilla 5
            DropItem1 = Item.ChollaFlowers, // vanilla Item.None
            DropRate1 = 12, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Stun Mist",
                    Power = 60, // vanilla 100
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    AddAilment = StatusAilment.Poison, // vanilla StatusAilment.Paralyze
                }
            ],
        },
        new()
        {
            Species = Species.GaiaFly,
            Note = "Gaia Fly",
            Level = 57, // vanilla 55
            MaxHp = 4400, // vanilla 278
            Str = 315, // vanilla 150
            Wit = 400, // vanilla 137
            Exp = 1725, // vanilla 163
            Gold = 937, // vanilla 158
            FireResist = 7, // vanilla 3
            WaterResist = 9, // vanilla 3
            WindResist = 5, // vanilla 3
            EarthResist = 7, // vanilla 11
            DropItem0 = Item.PrimeRib, // vanilla Item.PrettyJewel435
            DropRate0 = 20, // vanilla 4
            DropItem1 = Item.BlueMedicine, // vanilla Item.None
            DropRate1 = 10, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Poison Scales",
                    Speed = 80, // vanilla 30
                    Mode = (int)StatusAilment.Sleep, // vanilla (int)StatusAilment.Poison
                }
            ],
        },
        new()
        {
            Species = Species.HornedToad,
            Note = "Horned Toad",
            MaxHp = 480, // vanilla 112
            Str = 94, // vanilla 70
            Wit = 90, // vanilla 65
            Agi = 40, // vanilla 26
            Exp = 48, // vanilla 40
            FireResist = 5, // vanilla 0
            WindResist = 5, // vanilla 7
            EarthResist = 6, // vanilla 9
            DropItem0 = Item.YellowMedicine, // vanilla Item.None
            DropRate0 = 15, // vanilla 0
            DropItem1 = Item.Raincoat, // vanilla Item.None
            DropRate1 = 8, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Spin Needle",
                    Power = 120, // vanilla 130
                }
            ],
        },
        new()
        {
            Species = Species.MadFrog,
            Note = "Mad Frog",
            MaxHp = 593, // vanilla 163
            Str = 110, // vanilla 85
            Vit = 30, // vanilla 52
            Wit = 180, // vanilla 70
            Agi = 70, // vanilla 60
            Exp = 142, // vanilla 62
            Gold = 108, // vanilla 31
            FireResist = 6, // vanilla 0
            WaterResist = 9, // vanilla 7
            WindResist = 9, // vanilla 7
            EarthResist = 10, // vanilla 9
            DropItem0 = Item.ChollaFlowers, // vanilla Item.None
            DropRate0 = 12, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Poke Attack",
                    Power = 115, // vanilla 100
                    AddAilment = StatusAilment.Poison, // vanilla StatusAilment.Paralyze
                    Chance = 80, // vanilla 20
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.ToadKing,
            Note = "Toad King",
            MaxHp = 660, // vanilla 236
            Str = 113, // vanilla 87
            Vit = 30, // vanilla 68
            Wit = 160, // vanilla 50
            Exp = 97, // vanilla 53
            FireResist = 6, // vanilla 5
            WaterResist = 11, // vanilla 7
            WindResist = 8, // vanilla 7
            EarthResist = 6, // vanilla 5
            Skills =
            [
                new SkillChange
                {
                    Name = "Plague Lick",
                    Power = 100, // vanilla 85
                }
            ],
        },
        new()
        {
            Species = Species.Hippocamp,
            Note = "Hippocamp",
            MaxHp = 511, // vanilla 141
            Str = 116, // vanilla 84
            Vit = 100, // vanilla 67
            Wit = 190, // vanilla 85
            Agi = 40, // vanilla 25
            Exp = 127, // vanilla 59
            FireResist = 6, // vanilla 5
            WaterResist = 12, // vanilla 10
            WindResist = 12, // vanilla 10
            EarthResist = 6, // vanilla 5
            Skills =
            [
                new SkillChange
                {
                    Name = "Runaround",
                    Power = 92, // vanilla 128
                    Speed = 45, // vanilla 30
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Coelacanth,
            Note = "Coelacanth",
            MaxHp = 3827, // vanilla 371
            Str = 405, // vanilla 138
            Vit = 3000, // vanilla 100
            Wit = 425, // vanilla 180
            Exp = 2106, // vanilla 198
            Gold = 0, // vanilla 238
            FireResist = 3, // vanilla 1
            WaterResist = 14, // vanilla 7
            WindResist = 3, // vanilla 7
            EarthResist = 3, // vanilla 14
            DropItem0 = Item.BlueMedicine, // vanilla Item.None
            DropRate0 = 80, // vanilla 0
            DropItem1 = Item.GoldenPotion, // vanilla Item.None
            DropRate1 = 30, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Hoparound",
                    Power = 98, // vanilla 125
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.Paralyze
                    AddLevel = 1, // vanilla 4
                }
            ],
        },
        new()
        {
            Species = Species.GreenSlime,
            Note = "Green Slime",
            MaxHp = 70, // vanilla 45
            Str = 27, // vanilla 20
            Wit = 7, // vanilla 1
            DropRate0 = 18, // vanilla 15
            Skills =
            [
                new SkillChange
                {
                    Name = "Coverup",
                    Power = 102, // vanilla 115
                }
            ],
        },
        new()
        {
            Species = Species.PurpleSlime,
            Note = "Purple Slime",
            Level = 4, // vanilla 1
            MaxHp = 130, // vanilla 70
            Str = 45, // vanilla 37
            Vit = 15, // vanilla 12
            Wit = 40, // vanilla 25
            Agi = 10, // vanilla 5
            Exp = 3, // vanilla 2
            Gold = 6, // vanilla 10
            FireResist = 6, // vanilla 3
            WindResist = 6, // vanilla 4
            EarthResist = 7, // vanilla 14
            DropItem0 = Item.DreamTruffle, // vanilla Item.None
            DropRate0 = 22, // vanilla 0
            DropItem1 = Item.Herbs, // vanilla Item.None
            DropRate1 = 20, // vanilla 0
        }
    ];
}
