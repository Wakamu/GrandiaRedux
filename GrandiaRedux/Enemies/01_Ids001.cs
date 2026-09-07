using Grandia.Sdk;

namespace GrandiaRedux.Enemies;

/// <summary>
/// Values that differ between HD Remaster <c>BATLE/M_DAT.BIN</c> and
/// Redux 0.4.9 <c>redux_content/BATLE/M_DAT.BIN</c>. Unlisted fields stay vanilla.
/// </summary>
internal static class Ids001
{
    internal static readonly EnemyEdit[] All =
    [
        new()
        {
            Species = Species.GaiaApe,
            Note = "/// M_DAT form-row /",
            Level = 60, // vanilla 63
            MaxHp = 4800, // vanilla 431
            Str = 342, // vanilla 180
            Wit = 360, // vanilla 145
            Exp = 2139, // vanilla 228
            Gold = 786, // vanilla 233
            FireResist = 5, // vanilla 9
            WaterResist = 9, // vanilla 7
            WindResist = 7, // vanilla 9
            EarthResist = 5, // vanilla 7
            DropItem0 = Item.RedMedicine, // vanilla Item.PrettyJewel436
            DropRate0 = 25, // vanilla 5
            DropItem1 = Item.PrettyJewel436, // vanilla Item.None
            DropRate1 = 7, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Earthquake",
                    Power = 117, // vanilla 125
                    Speed = 45, // vanilla 30
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    AddLevel = 2, // vanilla 3
                }
            ],
        },
        new()
        {
            Species = Species.GaiaHorn,
            Note = "Gaia Horn",
            Level = 54, // vanilla 63
            MaxHp = 5000, // vanilla 378
            Str = 330, // vanilla 160
            Wit = 335, // vanilla 155
            Agi = 65, // vanilla 50
            Exp = 1807, // vanilla 212
            Gold = 950, // vanilla 213
            FireResist = 5, // vanilla 10
            WaterResist = 5, // vanilla 7
            WindResist = 5, // vanilla 9
            EarthResist = 5, // vanilla 7
            DropItem0 = Item.Panacea, // vanilla Item.None
            DropRate0 = 16, // vanilla 0
            DropItem1 = Item.YellowMedicine, // vanilla Item.None
            DropRate1 = 16, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "All Together!",
                    Speed = 200, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.Dragonoid,
            Note = "Dragonoid",
            Level = 80, // vanilla 78
            MaxHp = 3184, // vanilla 700
            Str = 425, // vanilla 170
            Wit = 380, // vanilla 100
            Exp = 1874, // vanilla 223
            Gold = 0, // vanilla 256
            WaterResist = 9, // vanilla 7
            WindResist = 6, // vanilla 7
            DropItem0 = Item.ResurrectPotion, // vanilla Item.None
            DropRate0 = 60, // vanilla 0
            DropItem1 = Item.CrimsonPotion, // vanilla Item.None
            DropRate1 = 40, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Poison Lance",
                    Power = 105, // vanilla 120
                }
            ],
        },
        new()
        {
            Species = Species.GaiaDrago,
            Note = "Gaia Drago",
            MaxHp = 3800, // vanilla 388
            Str = 500, // vanilla 176
            Vit = 450, // vanilla 100
            Wit = 600, // vanilla 146
            Agi = 60, // vanilla 30
            Exp = 7136, // vanilla 299
            Gold = 0, // vanilla 289
            FireResist = 12, // vanilla 5
            WaterResist = 12, // vanilla 5
            WindResist = 12, // vanilla 5
            EarthResist = 12, // vanilla 5
            DropItem0 = Item.ResurrectPotion, // vanilla Item.DeepBluePotion
            DropRate0 = 70, // vanilla 10
            DropItem1 = Item.DeepBluePotion, // vanilla Item.None
            DropRate1 = 35, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Critical Hit",
                    Power = 191, // vanilla 33
                    AddAilment = (StatusAilment)20, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 7, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.DragonKnight,
            Note = "Dragon Knight",
            Level = 70, // vanilla 19
            MaxHp = 2749, // vanilla 558
            Str = 302, // vanilla 165
            Vit = 150, // vanilla 156
            Wit = 410, // vanilla 145
            Agi = 60, // vanilla 45
            Exp = 1750, // vanilla 41
            Gold = 1231, // vanilla 95
            FireResist = 7, // vanilla 13
            WaterResist = 9, // vanilla 13
            WindResist = 6, // vanilla 13
            EarthResist = 7, // vanilla 13
            DropItem0 = Item.YellowMedicine, // vanilla Item.SeedOfDefense
            DropRate0 = 20, // vanilla 3
            DropItem1 = Item.RedMedicine, // vanilla Item.FruitOfPower
            DropRate1 = 15, // vanilla 2
            Skills =
            [
                new SkillChange
                {
                    Name = "Paralyze Spear",
                    Power = 50, // vanilla 45
                    Speed = 20, // vanilla 30
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.MountainApe,
            Note = "Mountain Ape",
            Level = 29, // vanilla 31
            MaxHp = 1857, // vanilla 330
            Str = 186, // vanilla 120
            Vit = 80, // vanilla 60
            Wit = 280, // vanilla 87
            Agi = 55, // vanilla 20
            Exp = 435, // vanilla 100
            Gold = 416, // vanilla 200
            FireResist = 5, // vanilla 4
            WaterResist = 10, // vanilla 12
            WindResist = 10, // vanilla 11
            EarthResist = 6, // vanilla 7
            DropItem1 = Item.BlizzardCharm, // vanilla Item.None
            DropRate1 = 6, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Snowball Throw",
                    Power = 75, // vanilla 45
                    Speed = 10, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.Yeti,
            Note = "Yeti",
            Level = 46, // vanilla 45
            MaxHp = 3432, // vanilla 400
            Str = 274, // vanilla 145
            Wit = 300, // vanilla 101
            Agi = 32, // vanilla 23
            Exp = 1182, // vanilla 110
            Gold = 509, // vanilla 130
            FireResist = 4, // vanilla 7
            WaterResist = 9, // vanilla 7
            WindResist = 3, // vanilla 7
            EarthResist = 4, // vanilla 7
            DropItem0 = Item.YellowMedicine, // vanilla Item.None
            DropRate0 = 25, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Earthquake",
                    Power = 90, // vanilla 125
                    Element = CombatElement.Earth, // vanilla CombatElement.None
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.BlackBeret,
            Note = "Black Beret",
            MaxHp = 1937, // vanilla 265
            Str = 164, // vanilla 102
            Wit = 245, // vanilla 100
            Exp = 500, // vanilla 85
            FireResist = 6, // vanilla 7
            WaterResist = 5, // vanilla 7
            WindResist = 6, // vanilla 7
            EarthResist = 6, // vanilla 7
            DropItem0 = Item.SeedOfLife, // vanilla Item.None
            DropRate0 = 15, // vanilla 0
            DropItem1 = Item.SeedOfMoves, // vanilla Item.None
            DropRate1 = 15, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Heavy Blow",
                    Power = 115, // vanilla 120
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.RockMan,
            Note = "Rock Man",
            MaxHp = 512, // vanilla 81
            Str = 90, // vanilla 72
            Vit = 38, // vanilla 50
            Wit = 95, // vanilla 41
            Agi = 30, // vanilla 13
            Exp = 64, // vanilla 42
            Gold = 78, // vanilla 50
            EarthResist = 3, // vanilla 14
            Skills =
            [
                new SkillChange
                {
                    Name = "Rock Throw",
                    Power = 105, // vanilla 110
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.MagmaMan,
            Note = "Magma Man",
            Level = 19, // vanilla 22
            MaxHp = 810, // vanilla 211
            Str = 124, // vanilla 80
            Vit = 68, // vanilla 66
            Wit = 105, // vanilla 43
            Agi = 35, // vanilla 16
            Exp = 125, // vanilla 75
            Gold = 104, // vanilla 40
            FireResist = 10, // vanilla 13
            WaterResist = 4, // vanilla 0
            WindResist = 6, // vanilla 3
            EarthResist = 5, // vanilla 9
            DropItem0 = Item.SmarnaWeed, // vanilla Item.RaincloudStaff
            DropRate0 = 15, // vanilla 10
            DropItem1 = Item.RaincloudStaff, // vanilla Item.None
            DropRate1 = 5, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Lava Throw",
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.IronGiant,
            Note = "Iron Giant",
            Level = 44, // vanilla 15
            MaxHp = 4407, // vanilla 700
            Str = 330, // vanilla 130
            Vit = 240, // vanilla 100
            Wit = 300, // vanilla 30
            Agi = 40, // vanilla 20
            Exp = 2200, // vanilla 25
            Gold = 468, // vanilla 50
            FireResist = 7, // vanilla 13
            WaterResist = 9, // vanilla 13
            WindResist = 4, // vanilla 13
            EarthResist = 7, // vanilla 13
            DropItem0 = Item.BOOMScroll, // vanilla Item.None
            DropRate0 = 12, // vanilla 0
            DropItem1 = Item.BlackOnyx, // vanilla Item.None
            DropRate1 = 12, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Bomb Throw",
                    Power = 110, // vanilla 130
                    Element = CombatElement.Fire, // vanilla CombatElement.None
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    AddAilment = StatusAilment.Confuse, // vanilla StatusAilment.None
                    Chance = 80, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.CactusMan,
            Note = "Cactus Man",
            Level = 25, // vanilla 22
            MaxHp = 1717, // vanilla 297
            Str = 165, // vanilla 105
            Wit = 270, // vanilla 100
            Agi = 46, // vanilla 25
            Exp = 327, // vanilla 70
            Gold = 321, // vanilla 87
            FireResist = 6, // vanilla 1
            WaterResist = 8, // vanilla 4
            EarthResist = 8, // vanilla 10
            DropItem0 = Item.MikeromaScroll, // vanilla Item.CactusHelm
            DropRate0 = 15, // vanilla 5
            DropItem1 = Item.CactusHelm, // vanilla Item.None
            DropRate1 = 5, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Fire Time",
                    Power = 2, // vanilla 110
                    Speed = 60, // vanilla 30
                    Effect = EffectType.Status, // vanilla EffectType.Damage
                    Mode = (int)StatusAilment.Confuse, // vanilla (int)DamageKind.Physical
                    AddAilment = (StatusAilment)13, // vanilla StatusAilment.None
                    Chance = 55, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Vanatos,
            Note = "Vanatos",
            MaxHp = 2455, // vanilla 325
            Str = 197, // vanilla 125
            Vit = 90, // vanilla 45
            Wit = 255, // vanilla 112
            Agi = 70, // vanilla 20
            Exp = 731, // vanilla 110
            Gold = 491, // vanilla 150
            FireResist = 6, // vanilla 2
            WaterResist = 10, // vanilla 7
            WindResist = 6, // vanilla 7
            EarthResist = 8, // vanilla 7
            DropItem0 = Item.TortesWhistle, // vanilla Item.None
            DropRate0 = 12, // vanilla 0
            DropItem1 = Item.PrimeRib, // vanilla Item.None
            DropRate1 = 12, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Fire Time",
                    Power = 20, // vanilla 85
                    Speed = 100, // vanilla 30
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    AddAilment = StatusAilment.Sleep, // vanilla StatusAilment.Confuse
                    Chance = 50, // vanilla 45
                }
            ],
        },
        new()
        {
            Species = Species.GaiaMan,
            Note = "Gaia Man",
            Level = 90, // vanilla 86
            MaxHp = 6000, // vanilla 800
            Str = 444, // vanilla 160
            Wit = 525, // vanilla 147
            Agi = 55, // vanilla 26
            Exp = 5394, // vanilla 264
            Gold = 0, // vanilla 312
            FireResist = 5, // vanilla 3
            WaterResist = 9, // vanilla 11
            WindResist = 6, // vanilla 8
            EarthResist = 6, // vanilla 11
            DropItem0 = Item.YellowMedicine, // vanilla Item.GoldenPotion
            DropRate0 = 75, // vanilla 10
            DropItem1 = Item.TearJewel, // vanilla Item.None
            DropRate1 = 20, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Fire Time",
                    Power = 2, // vanilla 5
                    Speed = 80, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.MedusaDancer,
            Note = "Medusa Dancer",
            MaxHp = 499, // vanilla 256
            Str = 103, // vanilla 80
            Vit = 100, // vanilla 72
            Wit = 225, // vanilla 105
            Agi = 100, // vanilla 70
            Exp = 180, // vanilla 75
            AttackCount = 3, // vanilla 1
            FireResist = 11, // vanilla 4
            WaterResist = 9, // vanilla 6
            WindResist = 11, // vanilla 6
            EarthResist = 11, // vanilla 4
            DropItem0 = Item.SpellBreaker, // vanilla Item.MagicBlockCharm
            DropRate0 = 20, // vanilla 10
            DropItem1 = Item.MagicBlockCharm, // vanilla Item.None
            DropRate1 = 7, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Life Drain",
                    Power = 44, // vanilla 120
                    Speed = 70, // vanilla 30
                    Element = CombatElement.Thunder, // vanilla CombatElement.None
                    Effect = EffectType.ProbDamage, // vanilla EffectType.Drain
                }
            ],
        },
        new()
        {
            Species = Species.Lilith,
            Note = "Lilith",
            Level = 75, // vanilla 76
            MaxHp = 1877, // vanilla 320
            Str = 395, // vanilla 136
            Vit = 200, // vanilla 60
            Wit = 335, // vanilla 250
            Exp = 1299, // vanilla 158
            Gold = 0, // vanilla 176
            FireResist = 14, // vanilla 7
            WaterResist = 14, // vanilla 7
            WindResist = 14, // vanilla 7
            EarthResist = 14, // vanilla 7
            DropItem0 = Item.RedMedicine, // vanilla Item.ResurrectPotion
            DropRate0 = 60, // vanilla 10
            DropItem1 = Item.BlueMedicine, // vanilla Item.None
            DropRate1 = 25, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Life Drain",
                    Speed = 100, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.NagaQueen,
            Note = "Naga Queen",
            Level = 85, // vanilla 21
            MaxHp = 4733, // vanilla 642
            Str = 390, // vanilla 152
            Vit = 100, // vanilla 189
            Wit = 600, // vanilla 124
            Agi = 50, // vanilla 22
            Exp = 3863, // vanilla 67
            Gold = 3192, // vanilla 118
            FireResist = 6, // vanilla 9
            WindResist = 7, // vanilla 14
            EarthResist = 7, // vanilla 9
            DropItem0 = Item.Weeds, // vanilla Item.SeedOfSpeed
            DropRate0 = 25, // vanilla 3
            DropItem1 = Item.SeedOfLife, // vanilla Item.FruitOfSpeed
            DropRate1 = 10, // vanilla 2
            Skills =
            [
                new SkillChange
                {
                    Name = "Life Drain",
                    Power = 80, // vanilla 100
                    Speed = 70, // vanilla 30
                    AddAilment = (StatusAilment)18, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.HyenaMan,
            Note = "Hyena Man",
            Level = 48, // vanilla 50
            MaxHp = 3912, // vanilla 425
            Str = 283, // vanilla 144
            Wit = 325, // vanilla 150
            Agi = 50, // vanilla 20
            Exp = 1089, // vanilla 117
            Gold = 600, // vanilla 270
            FireResist = 4, // vanilla 1
            WaterResist = 4, // vanilla 1
            WindResist = 4, // vanilla 1
            EarthResist = 4, // vanilla 1
            DropItem0 = Item.PoisonedApple, // vanilla Item.None
            DropRate0 = 16, // vanilla 0
            DropItem1 = Item.CultureMedium, // vanilla Item.None
            DropRate1 = 8, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Bite",
                    Power = 115, // vanilla 130
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Wolfman,
            Note = "Wolfman",
            Level = 41, // vanilla 13
            MaxHp = 3125, // vanilla 256
            Str = 276, // vanilla 113
            Wit = 280, // vanilla 103
            Agi = 45, // vanilla 20
            Exp = 898, // vanilla 23
            Gold = 555, // vanilla 11
            FireResist = 6, // vanilla 13
            WaterResist = 6, // vanilla 13
            WindResist = 6, // vanilla 13
            EarthResist = 6, // vanilla 13
            DropItem0 = Item.YellowMedicine, // vanilla Item.None
            DropRate0 = 30, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Fire Breath",
                    Power = 118, // vanilla 36
                    Speed = 50, // vanilla 30
                    AddAilment = (StatusAilment)16, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Jackal,
            Note = "Jackal",
            Level = 70, // vanilla 20
            MaxHp = 2985, // vanilla 498
            Str = 305, // vanilla 145
            Vit = 30, // vanilla 125
            Wit = 400, // vanilla 138
            Agi = 50, // vanilla 33
            Exp = 1308, // vanilla 34
            Gold = 837, // vanilla 68
            FireResist = 4, // vanilla 12
            WaterResist = 5, // vanilla 12
            WindResist = 4, // vanilla 12
            EarthResist = 4, // vanilla 12
            DropItem0 = Item.ResurrectPotion, // vanilla Item.SeedOfPower
            DropRate0 = 20, // vanilla 3
            DropItem1 = Item.GoldenPotion, // vanilla Item.FruitOfPower
            DropRate1 = 12, // vanilla 2
            Skills =
            [
                new SkillChange
                {
                    Name = "Poison Bite",
                    Power = 110, // vanilla 125
                    Chance = 80, // vanilla 75
                    AddLevel = 3, // vanilla 6
                }
            ],
        },
        new()
        {
            Species = Species.RedDevil,
            Note = "Red Devil",
            MaxHp = 666, // vanilla 87
            Str = 84, // vanilla 62
            Vit = 25, // vanilla 45
            Wit = 155, // vanilla 35
            Agi = 55, // vanilla 17
            Exp = 70, // vanilla 20
            Gold = 90, // vanilla 32
            FireResist = 11, // vanilla 9
            WaterResist = 5, // vanilla 8
            EarthResist = 7, // vanilla 8
            DropItem1 = Item.FirewoodSparks, // vanilla Item.None
            DropRate1 = 10, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Demon Throw",
                    Power = 112, // vanilla 18
                    Mode = (int)DamageKind.Physical, // vanilla (int)DamageKind.Magic
                    AddAilment = (StatusAilment)18, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.BlueDevil,
            Note = "Blue Devil",
            MaxHp = 746, // vanilla 145
            Str = 111, // vanilla 75
            Vit = 65, // vanilla 50
            Wit = 150, // vanilla 64
            Agi = 30, // vanilla 20
            Exp = 142, // vanilla 70
            Gold = 127, // vanilla 50
            FireResist = 5, // vanilla 8
            WaterResist = 11, // vanilla 8
            DropItem0 = Item.GaleScroll, // vanilla Item.TitansRing
            DropRate0 = 10, // vanilla 1
            DropItem1 = Item.TitansRing, // vanilla Item.None
            DropRate1 = 4, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Demon Throw",
                    Power = 112, // vanilla 28
                    Mode = (int)DamageKind.Physical, // vanilla (int)DamageKind.Magic
                    AddAilment = (StatusAilment)18, // vanilla StatusAilment.None
                }
            ],
        },
        new()
        {
            Species = Species.Nyalmot,
            Note = "Nyalmot",
            MaxHp = 777, // vanilla 225
            Str = 121, // vanilla 105
            Wit = 155, // vanilla 65
            Agi = 40, // vanilla 23
            Exp = 189, // vanilla 53
            WaterResist = 7, // vanilla 8
            WindResist = 7, // vanilla 8
            EarthResist = 7, // vanilla 8
            DropItem0 = Item.MikeromaScroll, // vanilla Item.None
            DropRate0 = 10, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Nyalmot Throw",
                    Power = 110, // vanilla 40
                    Mode = (int)DamageKind.Physical, // vanilla (int)DamageKind.Magic
                    AddAilment = (StatusAilment)18, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.PinkMage,
            Note = "Pink Mage",
            Level = 31, // vanilla 17
            MaxHp = 500, // vanilla 100
            Str = 170, // vanilla 115
            Vit = 3000, // vanilla 256
            Wit = 345, // vanilla 130
            Exp = 444, // vanilla 36
            Gold = 655, // vanilla 24
            AttackRange = 7, // vanilla 2
            WindResist = 9, // vanilla 12
            DropItem0 = Item.BlueMedicine, // vanilla Item.ResurrectPotion
            DropRate0 = 15, // vanilla 4
            DropItem1 = Item.MageHat, // vanilla Item.None
            DropRate1 = 8, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Slip Away",
                    Power = 100, // vanilla 25
                    Mode = (int)DamageKind.Physical, // vanilla (int)DamageKind.Magic
                }
            ],
        },
        new()
        {
            Species = Species.Layelah,
            Note = "Layelah",
            Level = 75, // vanilla 21
            MaxHp = 1999, // vanilla 385
            Str = 350, // vanilla 100
            Vit = 3000, // vanilla 170
            Wit = 485, // vanilla 126
            Agi = 60, // vanilla 19
            Exp = 2185, // vanilla 41
            Gold = 2658, // vanilla 92
            AttackRange = 5, // vanilla 2
            FireResist = 8, // vanilla 12
            WaterResist = 9, // vanilla 12
            WindResist = 8, // vanilla 12
            EarthResist = 7, // vanilla 12
            DropItem0 = Item.BlueMedicine, // vanilla Item.SeedOfMagic
            DropRate0 = 30, // vanilla 4
            DropItem1 = Item.MagicLamp, // vanilla Item.FruitOfMagic
            DropRate1 = 14, // vanilla 2
            Skills =
            [
                new SkillChange
                {
                    Name = "Deadly Temptation",
                    Power = 100, // vanilla 33
                    Speed = 110, // vanilla 30
                    Element = CombatElement.None, // vanilla CombatElement.Thunder
                }
            ],
        },
        new()
        {
            Species = Species.Pteranobone,
            Note = "Pteranobone",
            Level = 30, // vanilla 17
            MaxHp = 1555, // vanilla 555
            Str = 163, // vanilla 145
            Vit = 100, // vanilla 200
            Wit = 235, // vanilla 100
            Exp = 452, // vanilla 40
            Gold = 267, // vanilla 31
            AttackCount = 3, // vanilla 1
            FireResist = 8, // vanilla 0
            WaterResist = 8, // vanilla 10
            WindResist = 12, // vanilla 10
            EarthResist = 8, // vanilla 7
            DropItem0 = Item.YellowMedicine, // vanilla Item.DeathMask
            DropRate0 = 12, // vanilla 3
            DropItem1 = Item.DeathMask, // vanilla Item.None
            DropRate1 = 6, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Aim Cut",
                    Power = 108, // vanilla 125
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.BirdSkull,
            Note = "Bird Skull",
            Level = 35, // vanilla 30
            MaxHp = 1773, // vanilla 350
            Str = 199, // vanilla 130
            Vit = 140, // vanilla 75
            Wit = 265, // vanilla 80
            Agi = 35, // vanilla 18
            Exp = 434, // vanilla 92
            Gold = 364, // vanilla 85
            FireResist = 11, // vanilla 5
            WaterResist = 10, // vanilla 7
            WindResist = 10, // vanilla 7
            EarthResist = 6, // vanilla 7
            DropRate0 = 12, // vanilla 10
            DropItem1 = Item.RescueSet, // vanilla Item.PrettyJewel
            DropRate1 = 12, // vanilla 2
            Skills =
            [
                new SkillChange
                {
                    Name = "Aim Cut",
                    Power = 112, // vanilla 110
                }
            ],
        },
        new()
        {
            Species = Species.Skeleton,
            Note = "Skeleton",
            Level = 75, // vanilla 71
            MaxHp = 3444, // vanilla 391
            Str = 408, // vanilla 165
            Vit = 120, // vanilla 80
            Wit = 295, // vanilla 128
            Agi = 38, // vanilla 23
            Exp = 1282, // vanilla 163
            Gold = 0, // vanilla 218
            FireResist = 6, // vanilla 5
            WaterResist = 6, // vanilla 7
            WindResist = 6, // vanilla 7
            EarthResist = 6, // vanilla 7
            DropItem0 = Item.YellowMedicine, // vanilla Item.BlueMedicine
            DropRate0 = 50, // vanilla 10
            DropItem1 = Item.Panacea, // vanilla Item.None
            DropRate1 = 50, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Magic Block Cut",
                    Power = 100, // vanilla 120
                }
            ],
        },
        new()
        {
            Species = Species.Zombie,
            Note = "Zombie",
            Level = 30, // vanilla 15
            MaxHp = 2738, // vanilla 600
            Str = 215, // vanilla 150
            Wit = 999, // vanilla 30
            Agi = 12, // vanilla 10
            Exp = 284, // vanilla 34
            Gold = 255, // vanilla 37
            AttackCount = 2, // vanilla 1
            FireResist = 2, // vanilla 0
            WaterResist = 11, // vanilla 4
            WindResist = 5, // vanilla 4
            DropItem0 = Item.RedMedicine, // vanilla Item.PrettyJewel436
            DropRate0 = 15, // vanilla 1
            DropItem1 = Item.PrettyJewel435, // vanilla Item.None
            DropRate1 = 3, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Deadly Stink",
                    Power = 80, // vanilla 110
                    Speed = 10, // vanilla 30
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.Lich,
            Note = "Lich",
            Level = 34, // vanilla 29
            MaxHp = 2634, // vanilla 372
            Str = 206, // vanilla 120
            Wit = 250, // vanilla 90
            Agi = 85, // vanilla 18
            Exp = 402, // vanilla 73
            Gold = 311, // vanilla 100
            FireResist = 5, // vanilla 4
            WaterResist = 8, // vanilla 7
            DropItem0 = Item.PrimeRib, // vanilla Item.PrettyJewel435
            DropRate0 = 20, // vanilla 2
            DropItem1 = Item.PrettyJewel435, // vanilla Item.None
            DropRate1 = 4, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Paralyze Gas",
                    Power = 60, // vanilla 100
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.GaiaZombie,
            Note = "Gaia Zombie",
            MaxHp = 7000, // vanilla 439
            Str = 515, // vanilla 166
            Wit = 500, // vanilla 133
            Exp = 5739, // vanilla 267
            Gold = 0, // vanilla 238
            FireResist = 3, // vanilla 4
            WaterResist = 7, // vanilla 9
            WindResist = 6, // vanilla 9
            EarthResist = 6, // vanilla 9
            DropItem0 = Item.Weeds, // vanilla Item.None
            DropRate0 = 70, // vanilla 0
            DropItem1 = Item.MagicLamp, // vanilla Item.None
            DropRate1 = 30, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Delay Gas",
                    Power = 167, // vanilla 120
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.WarpMan,
            Note = "Warp Man",
            Level = 42, // vanilla 35
            MaxHp = 3525, // vanilla 345
            Str = 205, // vanilla 135
            Vit = 140, // vanilla 120
            Wit = 335, // vanilla 85
            Agi = 32, // vanilla 17
            Exp = 750, // vanilla 98
            Gold = 696, // vanilla 115
            AttackCount = 2, // vanilla 1
            FireResist = 10, // vanilla 14
            WaterResist = 12, // vanilla 0
            WindResist = 5, // vanilla 7
            EarthResist = 10, // vanilla 14
            DropItem0 = Item.YellowMedicine, // vanilla Item.WarpShoes
            DropRate0 = 14, // vanilla 3
            DropItem1 = Item.WarpShoes, // vanilla Item.None
            DropRate1 = 6, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Spin Cut",
                    Power = 130, // vanilla 115
                    Speed = 50, // vanilla 30
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.GaiaKnight,
            Note = "Gaia Knight",
            MaxHp = 9600, // vanilla 396
            Str = 630, // vanilla 172
            Vit = 200, // vanilla 128
            Wit = 600, // vanilla 149
            Agi = 40, // vanilla 20
            Exp = 11323, // vanilla 285
            Gold = 0, // vanilla 326
            AttackRange = 3, // vanilla 2
            FireResist = 8, // vanilla 4
            WaterResist = 11, // vanilla 4
            WindResist = 6, // vanilla 4
            EarthResist = 8, // vanilla 4
            DropItem0 = Item.TearJewel, // vanilla Item.None
            DropRate0 = 60, // vanilla 0
            DropItem1 = Item.SpiritPotion, // vanilla Item.None
            DropRate1 = 12, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Spin Cut",
                    Power = 85, // vanilla 130
                    Speed = 45, // vanilla 30
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.SpacetimeArmor,
            Note = "Spacetime Armor",
            Level = 46, // vanilla 15
            MaxHp = 5555, // vanilla 321
            Str = 340, // vanilla 125
            Vit = 100, // vanilla 75
            Wit = 350, // vanilla 100
            Exp = 2531, // vanilla 23
            Gold = 100, // vanilla 23
            FireResist = 10, // vanilla 13
            WaterResist = 11, // vanilla 13
            WindResist = 10, // vanilla 13
            EarthResist = 10, // vanilla 13
            DropItem0 = Item.DeepBluePotion, // vanilla Item.None
            DropRate0 = 25, // vanilla 0
            DropItem1 = Item.SeedOfDefense, // vanilla Item.None
            DropRate1 = 8, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Spin Cut",
                    Speed = 50, // vanilla 30
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 3, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Ghostoid,
            Note = "Ghostoid",
            MaxHp = 150, // vanilla 62
            Str = 36, // vanilla 27
            Vit = 21, // vanilla 11
            Wit = 80, // vanilla 45
            Exp = 7, // vanilla 4
            Gold = 5, // vanilla 1
            FireResist = 6, // vanilla 5
            DropItem0 = Item.HowlerScroll, // vanilla Item.None
            DropRate0 = 20, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Shout!",
                    Speed = 35, // vanilla 30
                    AddAilment = StatusAilment.Paralyze, // vanilla (StatusAilment)13
                    Chance = 50, // vanilla 100
                }
            ],
        },
        new()
        {
            Species = Species.VengefulSpirit,
            Note = "Vengeful Spirit",
            Level = 9, // vanilla 10
            MaxHp = 60, // vanilla 35
            Str = 54, // vanilla 40
            Wit = 50, // vanilla 15
            FireResist = 11, // vanilla 4
            WaterResist = 11, // vanilla 7
            WindResist = 12, // vanilla 4
            EarthResist = 15, // vanilla 14
            DropRate0 = 8, // vanilla 10
            DropItem1 = Item.Dynamite, // vanilla Item.None
            DropRate1 = 12, // vanilla 0
        },
        new()
        {
            Species = Species.Ghost,
            Note = "Ghost",
            Level = 75, // vanilla 20
            MaxHp = 1846, // vanilla 465
            Str = 380, // vanilla 126
            Vit = 3000, // vanilla 999
            Wit = 530, // vanilla 65
            Exp = 2127, // vanilla 36
            Gold = 2839, // vanilla 83
            FireResist = 4, // vanilla 9
            WaterResist = 14, // vanilla 9
            WindResist = 14, // vanilla 9
            EarthResist = 14, // vanilla 9
            DropItem0 = Item.RedMedicine, // vanilla Item.SeedOfMoves
            DropRate0 = 30, // vanilla 3
            DropItem1 = Item.SeedOfSpeed, // vanilla Item.FruitOfMoves
            DropRate1 = 8, // vanilla 1
            Skills =
            [
                new SkillChange
                {
                    Name = "Divide",
                    Speed = 200, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.LostSoul,
            Note = "Lost Soul",
            MaxHp = 498, // vanilla 75
            Str = 115, // vanilla 70
            Vit = 110, // vanilla 100
            Wit = 180, // vanilla 68
            Agi = 35, // vanilla 25
            Exp = 135, // vanilla 40
            Gold = 91, // vanilla 20
            AttackRange = 4, // vanilla 3
            WaterResist = 13, // vanilla 4
            WindResist = 13, // vanilla 4
            EarthResist = 13, // vanilla 11
            DropItem0 = Item.ResurrectPotion, // vanilla Item.FireCharm
            DropRate0 = 10, // vanilla 5
            DropItem1 = Item.KnifeOfJudgment, // vanilla Item.None
            DropRate1 = 22, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Flame Shot",
                    Power = 200, // vanilla 28
                    Speed = 105, // vanilla 30
                    Element = CombatElement.None, // vanilla CombatElement.Fire
                }
            ],
        },
        new()
        {
            Species = Species.Critter,
            Note = "Critter",
            Level = 60, // vanilla 63
            MaxHp = 2129, // vanilla 325
            Str = 400, // vanilla 160
            Vit = 600, // vanilla 145
            Wit = 475, // vanilla 115
            Agi = 50, // vanilla 21
            Exp = 1628, // vanilla 231
            Gold = 0, // vanilla 157
            WaterResist = 12, // vanilla 1
            WindResist = 12, // vanilla 1
            EarthResist = 12, // vanilla 7
            DropItem0 = Item.ChollaFlowers, // vanilla Item.None
            DropRate0 = 85, // vanilla 0
            DropItem1 = Item.SuddenDeathCharm, // vanilla Item.None
            DropRate1 = 15, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Death Spear",
                    Power = 100, // vanilla 65
                    Speed = 110, // vanilla 105
                    Element = CombatElement.None, // vanilla CombatElement.Fire
                }
            ],
        },
        new()
        {
            Species = Species.WillOWisp,
            Note = "Will-O'-Wisp",
            Level = 41, // vanilla 14
            MaxHp = 1364, // vanilla 145
            Str = 300, // vanilla 110
            Vit = 3000, // vanilla 120
            Wit = 225, // vanilla 100
            Agi = 100, // vanilla 23
            Exp = 1189, // vanilla 25
            Gold = 645, // vanilla 21
            AttackRange = 5, // vanilla 3
            FireResist = 7, // vanilla 14
            WaterResist = 11, // vanilla 3
            WindResist = 7, // vanilla 3
            DropItem0 = Item.FreesiaFlowers, // vanilla Item.None
            DropRate0 = 18, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Fire Hand",
                    Power = 153, // vanilla 26
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.HotDog,
            Note = "Hot Dog",
            MaxHp = 791, // vanilla 164
            Str = 112, // vanilla 75
            Vit = 25, // vanilla 35
            Wit = 160, // vanilla 90
            Agi = 85, // vanilla 28
            Exp = 112, // vanilla 45
            Gold = 100, // vanilla 5
            WaterResist = 4, // vanilla 1
            WindResist = 7, // vanilla 3
            DropItem0 = Item.HealthWeed, // vanilla Item.RaincloudStaff
            DropRate0 = 12, // vanilla 10
            DropItem1 = Item.RaincloudStaff, // vanilla Item.None
            DropRate1 = 5, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Flame Howl",
                    Power = 40, // vanilla 20
                }
            ],
        },
        new()
        {
            Species = Species.FireHound,
            Note = "Fire Hound",
            MaxHp = 1899, // vanilla 260
            Str = 195, // vanilla 115
            Vit = 70, // vanilla 40
            Wit = 315, // vanilla 125
            Agi = 50, // vanilla 28
            Exp = 483, // vanilla 80
            Gold = 314, // vanilla 72
            FireResist = 14, // vanilla 13
            WaterResist = 4, // vanilla 2
            EarthResist = 10, // vanilla 7
            DropRate0 = 12, // vanilla 10
            DropItem1 = Item.ResurrectPotion441, // vanilla Item.None
            DropRate1 = 10, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Flame Howl",
                    Power = 62, // vanilla 29
                }
            ],
        },
        new()
        {
            Species = Species.Cerberus,
            Note = "Cerberus",
            Level = 41, // vanilla 14
            MaxHp = 2694, // vanilla 244
            Str = 267, // vanilla 115
            Vit = 50, // vanilla 59
            Wit = 300, // vanilla 150
            Agi = 150, // vanilla 55
            Exp = 1063, // vanilla 18
            Gold = 676, // vanilla 10
            FireResist = 9, // vanilla 14
            WaterResist = 9, // vanilla 4
            DropItem0 = Item.ResurrectPotion, // vanilla Item.None
            DropRate0 = 12, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Dark Breath",
                    Power = 52, // vanilla 38
                    Speed = 80, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.SnowBoar,
            Note = "Snow Boar",
            MaxHp = 2004, // vanilla 246
            Str = 192, // vanilla 130
            Vit = 48, // vanilla 100
            Wit = 245, // vanilla 85
            Agi = 50, // vanilla 23
            Exp = 346, // vanilla 80
            Gold = 333, // vanilla 78
            FireResist = 5, // vanilla 1
            WaterResist = 10, // vanilla 14
            WindResist = 7, // vanilla 10
            EarthResist = 8, // vanilla 7
            DropItem0 = Item.FreesiaFlowers, // vanilla Item.None
            DropRate0 = 12, // vanilla 0
            DropItem1 = Item.RestraintWalnut, // vanilla Item.None
            DropRate1 = 15, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "All Together!",
                    Speed = 210, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.KingHorn,
            Note = "King Horn",
            Level = 46, // vanilla 41
            MaxHp = 4014, // vanilla 309
            Str = 270, // vanilla 136
            Vit = 40, // vanilla 85
            Wit = 270, // vanilla 126
            Agi = 35, // vanilla 20
            Exp = 1053, // vanilla 100
            Gold = 523, // vanilla 102
            FireResist = 4, // vanilla 9
            WaterResist = 9, // vanilla 7
            WindResist = 2, // vanilla 9
            EarthResist = 3, // vanilla 7
            DropItem0 = Item.PowerMushroom, // vanilla Item.None
            DropRate0 = 12, // vanilla 0
            DropItem1 = Item.RedMedicine, // vanilla Item.None
            DropRate1 = 12, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "All Together!",
                    Speed = 200, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.Milda,
            Note = "Milda",
            MaxHp = 5300, // vanilla 2800
            Str = 175, // vanilla 130
            Wit = 345, // vanilla 110
            FireResist = 6, // vanilla 9
            WaterResist = 11, // vanilla 9
            WindResist = 10, // vanilla 9
            EarthResist = 6, // vanilla 9
        },
        new()
        {
            Species = Species.GlugBird,
            Note = "Glug Bird",
            Level = 7, // vanilla 8
            MaxHp = 130, // vanilla 65
            Str = 44, // vanilla 35
            Vit = 10, // vanilla 16
            Wit = 37, // vanilla 26
            Exp = 6, // vanilla 7
            Gold = 12, // vanilla 16
            FireResist = 5, // vanilla 7
            DropItem0 = Item.BaobabFruit, // vanilla Item.None
            DropRate0 = 22, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Back Kick",
                    Power = 110, // vanilla 125
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.ThudBird,
            Note = "Thud Bird",
            Level = 39, // vanilla 42
            MaxHp = 2858, // vanilla 800
            Str = 232, // vanilla 132
            Wit = 255, // vanilla 112
            Agi = 50, // vanilla 25
            Exp = 722, // vanilla 100
            Gold = 497, // vanilla 120
            WindResist = 2, // vanilla 4
            EarthResist = 8, // vanilla 7
            DropItem0 = Item.YellowMedicine, // vanilla Item.None
            DropRate0 = 12, // vanilla 0
            DropItem1 = Item.PrimeRib, // vanilla Item.None
            DropRate1 = 15, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Chain Kick",
                    Power = 120, // vanilla 110
                    Speed = 55, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.FlapBird,
            Note = "Flap Bird",
            Level = 26, // vanilla 18
            MaxHp = 1656, // vanilla 255
            Str = 183, // vanilla 120
            Wit = 180, // vanilla 105
            Agi = 45, // vanilla 24
            Exp = 263, // vanilla 70
            Gold = 221, // vanilla 78
            FireResist = 8, // vanilla 7
            WaterResist = 8, // vanilla 7
            WindResist = 6, // vanilla 7
            EarthResist = 8, // vanilla 7
            DropItem0 = Item.SmokedSalmon, // vanilla Item.None
            DropRate0 = 20, // vanilla 0
            DropItem1 = Item.YellowMedicine, // vanilla Item.None
            DropRate1 = 10, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Back Kick",
                    Power = 105, // vanilla 110
                    AddAilment = StatusAilment.Paralyze, // vanilla StatusAilment.None
                    Chance = 60, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Sphytaros,
            Note = "Sphytaros",
            Level = 34, // vanilla 32
            MaxHp = 1397, // vanilla 421
            Str = 201, // vanilla 120
            Vit = 150, // vanilla 85
            Wit = 285, // vanilla 100
            Agi = 40, // vanilla 21
            Exp = 479, // vanilla 100
            Gold = 600, // vanilla 125
            DropItem0 = Item.SpellBreaker, // vanilla Item.MoveBreaker
            DropRate0 = 8, // vanilla 5
            DropItem1 = Item.OrbOfSilence, // vanilla Item.None
            DropRate1 = 12, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Electric Shock",
                    Power = 68, // vanilla 33
                }
            ],
        },
        new()
        {
            Species = Species.Sphynx,
            Note = "Sphynx",
            MaxHp = 1111, // vanilla 250
            Str = 188, // vanilla 120
            Vit = 175, // vanilla 60
            Wit = 310, // vanilla 115
            Agi = 40, // vanilla 21
            Exp = 511, // vanilla 87
            Gold = 810, // vanilla 89
            FireResist = 11, // vanilla 10
            WaterResist = 11, // vanilla 10
            WindResist = 8, // vanilla 10
            EarthResist = 8, // vanilla 10
            DropItem0 = Item.BlueMedicine, // vanilla Item.None
            DropRate0 = 14, // vanilla 0
            DropItem1 = Item.PrettyJewel, // vanilla Item.None
            DropRate1 = 7, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Riddle",
                    AddAilment = (StatusAilment)14, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Guardian,
            Note = "Guardian",
            Level = 60, // vanilla 70
            MaxHp = 5238, // vanilla 550
            Str = 369, // vanilla 165
            Wit = 435, // vanilla 118
            Exp = 1574, // vanilla 179
            Gold = 0, // vanilla 245
            AttackRange = 10, // vanilla 3
            FireResist = 7, // vanilla 10
            WaterResist = 9, // vanilla 10
            WindResist = 5, // vanilla 10
            EarthResist = 7, // vanilla 10
            DropItem0 = Item.YellowMedicine, // vanilla Item.None
            DropRate0 = 75, // vanilla 0
            DropItem1 = Item.StaffOfLife, // vanilla Item.None
            DropRate1 = 10, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Riddle",
                    Power = 2, // vanilla 5
                    Speed = 80, // vanilla 30
                    AddAilment = (StatusAilment)18, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.LandSlug,
            Note = "Land Slug",
            Level = 20, // vanilla 15
            MaxHp = 812, // vanilla 220
            Str = 129, // vanilla 93
            Vit = 105, // vanilla 75
            Wit = 175, // vanilla 55
            Exp = 159, // vanilla 65
            Gold = 85, // vanilla 41
            WaterResist = 10, // vanilla 7
            EarthResist = 7, // vanilla 5
            DropItem0 = Item.BamoFruit, // vanilla Item.PoisonAntidote
            DropRate0 = 15, // vanilla 10
            DropItem1 = Item.RainbowWeed, // vanilla Item.None
            DropRate1 = 15, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Curl Gas",
                    Power = 30, // vanilla 115
                    Element = CombatElement.Forest, // vanilla CombatElement.None
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.HugePupa,
            Note = "Huge Pupa",
            Level = 21, // vanilla 17
            MaxHp = 900, // vanilla 300
            Str = 150, // vanilla 88
            Vit = 110, // vanilla 75
            Wit = 200, // vanilla 65
            Agi = 30, // vanilla 16
            Exp = 373, // vanilla 60
            Gold = 189, // vanilla 59
            FireResist = 10, // vanilla 7
            WaterResist = 10, // vanilla 7
            WindResist = 10, // vanilla 7
            EarthResist = 10, // vanilla 7
            DropItem0 = Item.RainbowWeed, // vanilla Item.None
            DropRate0 = 15, // vanilla 0
            DropItem1 = Item.Vaccine, // vanilla Item.None
            DropRate1 = 10, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Dizzy Gas",
                    Power = 34, // vanilla 120
                    Strength = false, // vanilla True
                    Element = CombatElement.Forest, // vanilla CombatElement.None
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    Chance = 64, // vanilla 16
                    AddLevel = 5, // vanilla 4
                }
            ],
        },
        new()
        {
            Species = Species.GaiaSlug,
            Note = "Gaia Slug",
            Level = 95, // vanilla 82
            MaxHp = 7800, // vanilla 485
            Str = 480, // vanilla 173
            Vit = 300, // vanilla 50
            Wit = 500, // vanilla 122
            Agi = 40, // vanilla 17
            Exp = 6837, // vanilla 266
            Gold = 0, // vanilla 225
            FireResist = 6, // vanilla 8
            WaterResist = 9, // vanilla 8
            WindResist = 6, // vanilla 8
            EarthResist = 6, // vanilla 8
            DropItem0 = Item.BlueMedicine, // vanilla Item.None
            DropRate0 = 75, // vanilla 0
            DropItem1 = Item.MagicLamp, // vanilla Item.None
            DropRate1 = 35, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Dizzy Gas",
                    Power = 87, // vanilla 115
                    Speed = 40, // vanilla 30
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.GaiaDevil,
            Note = "Gaia Devil",
            MaxHp = 4900, // vanilla 526
            Str = 440, // vanilla 160
            Wit = 570, // vanilla 132
            Agi = 50, // vanilla 21
            Exp = 6891, // vanilla 310
            Gold = 0, // vanilla 345
            FireResist = 14, // vanilla 11
            WaterResist = 1, // vanilla 11
            WindResist = 6, // vanilla 11
            EarthResist = 6, // vanilla 11
            DropItem0 = Item.YellowMedicine, // vanilla Item.None
            DropRate0 = 70, // vanilla 0
            DropItem1 = Item.GoldenPotion, // vanilla Item.None
            DropRate1 = 35, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Power Drain",
                    Power = -1, // vanilla -3
                    AddAilment = (StatusAilment)14, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 3, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.ToadDemon,
            Note = "Toad Demon",
            Level = 75, // vanilla 22
            MaxHp = 3730, // vanilla 428
            Str = 400, // vanilla 115
            Vit = 60, // vanilla 175
            Wit = 350, // vanilla 120
            Exp = 2598, // vanilla 39
            Gold = 1536, // vanilla 77
            FireResist = 7, // vanilla 12
            WaterResist = 9, // vanilla 12
            WindResist = 6, // vanilla 12
            EarthResist = 7, // vanilla 12
            DropItem0 = Item.YellowMedicine, // vanilla Item.SeedOfMagic
            DropRate0 = 30, // vanilla 4
            DropItem1 = Item.SeedOfPower, // vanilla Item.SeedOfLife
            DropRate1 = 8, // vanilla 2
            Skills =
            [
                new SkillChange
                {
                    Name = "Demon Kick",
                    Power = 80, // vanilla 125
                    AddAilment = (StatusAilment)18, // vanilla (StatusAilment)13
                    AddLevel = 5, // vanilla 2
                }
            ],
        },
        new()
        {
            Species = Species.Satan,
            Note = "Satan",
            Level = 80, // vanilla 20
            MaxHp = 4093, // vanilla 589
            Str = 345, // vanilla 135
            Vit = 50, // vanilla 195
            Wit = 420, // vanilla 135
            Exp = 2784, // vanilla 54
            Gold = 1437, // vanilla 102
            FireResist = 9, // vanilla 14
            WindResist = 4, // vanilla 9
            EarthResist = 3, // vanilla 14
            DropItem0 = Item.BlackNailPolish, // vanilla Item.DeepBluePotion
            DropRate0 = 30, // vanilla 14
            DropItem1 = Item.TearJewel, // vanilla Item.AllAroundFruit
            DropRate1 = 15, // vanilla 1
            Skills =
            [
                new SkillChange
                {
                    Name = "Flap Twister",
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    AddAilment = (StatusAilment)16, // vanilla (StatusAilment)13
                }
            ],
        },
        new()
        {
            Species = Species.BabyBat,
            Note = "Baby Bat",
            MaxHp = 24, // vanilla 18
            Str = 26, // vanilla 20
            Wit = 30, // vanilla 19
            DropItem0 = Item.Herbs, // vanilla Item.None
            DropRate0 = 13, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Sonar",
                    Power = 4, // vanilla 100
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.VampireBat,
            Note = "Vampire Bat",
            Level = 9, // vanilla 10
            MaxHp = 144, // vanilla 45
            Str = 48, // vanilla 37
            Vit = 8, // vanilla 25
            Wit = 100, // vanilla 64
            Agi = 42, // vanilla 17
            Exp = 13, // vanilla 10
            Gold = 16, // vanilla 19
            FireResist = 9, // vanilla 5
            WaterResist = 9, // vanilla 5
            WindResist = 8, // vanilla 7
            DropItem0 = Item.HowlerScroll, // vanilla Item.None
            DropRate0 = 15, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Suck Blood",
                    Power = 110, // vanilla 130
                    Speed = 20, // vanilla 30
                    AddAilment = (StatusAilment)18, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.SonicBat,
            Note = "Sonic Bat",
            MaxHp = 312, // vanilla 81
            Str = 64, // vanilla 47
            Wit = 115, // vanilla 70
            Agi = 60, // vanilla 25
            Exp = 37, // vanilla 25
            FireResist = 9, // vanilla 5
            WaterResist = 4, // vanilla 5
            WindResist = 14, // vanilla 7
            Skills =
            [
                new SkillChange
                {
                    Name = "Mana Capture",
                    Power = 10, // vanilla 1
                }
            ],
        },
        new()
        {
            Species = Species.MagicHead,
            Note = "Magic Head",
            MaxHp = 770, // vanilla 235
            Str = 195, // vanilla 120
            Vit = 70, // vanilla 45
            Wit = 225, // vanilla 118
            Exp = 214, // vanilla 80
            AttackCount = 1, // vanilla 2
            FireResist = 9, // vanilla 7
            WaterResist = 9, // vanilla 7
            WindResist = 9, // vanilla 7
            EarthResist = 9, // vanilla 7
            DropItem0 = Item.PowerMushroom, // vanilla Item.None
            DropRate0 = 15, // vanilla 0
        }
    ];
}
