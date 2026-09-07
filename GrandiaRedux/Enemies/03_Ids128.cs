using Grandia.Sdk;

namespace GrandiaRedux.Enemies;

/// <summary>
/// Values that differ between HD Remaster <c>BATLE/M_DAT.BIN</c> and
/// Redux 0.4.9 <c>redux_content/BATLE/M_DAT.BIN</c>. Unlisted fields stay vanilla.
/// </summary>
internal static class Ids128
{
    internal static readonly EnemyEdit[] All =
    [
        new()
        {
            Species = Species.RedSlime,
            Note = "Red Slime",
            Level = 4, // vanilla 6
            MaxHp = 215, // vanilla 100
            Str = 52, // vanilla 37
            Wit = 55, // vanilla 25
            Agi = 14, // vanilla 7
            Exp = 5, // vanilla 2
            Gold = 11, // vanilla 18
            FireResist = 11, // vanilla 0
            WindResist = 7, // vanilla 4
            EarthResist = 5, // vanilla 4
            DropItem0 = Item.ChollaFlowers, // vanilla Item.None
            DropRate0 = 10, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Divide",
                    Speed = 64, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.GrimHaze,
            Note = "Grim Haze",
            Level = 13, // vanilla 18
            MaxHp = 215, // vanilla 50
            Str = 65, // vanilla 60
            Wit = 144, // vanilla 90
            FireResist = 9, // vanilla 4
            WaterResist = 10, // vanilla 9
            WindResist = 11, // vanilla 4
            EarthResist = 10, // vanilla 11
            DropItem0 = Item.VacuumScroll, // vanilla Item.None
            DropRate0 = 9, // vanilla 0
        },
        new()
        {
            Species = Species.GasCloud,
            Note = "Gas Cloud",
            MaxHp = 286, // vanilla 125
            Str = 69, // vanilla 55
            Vit = 26, // vanilla 0
            Wit = 63, // vanilla 10
            Agi = 48, // vanilla 25
            Exp = 36, // vanilla 31
            FireResist = 10, // vanilla 4
            WaterResist = 11, // vanilla 9
            WindResist = 12, // vanilla 4
            EarthResist = 9, // vanilla 11
            DropItem0 = Item.BamoFruit, // vanilla Item.None
            DropRate0 = 8, // vanilla 0
            DropItem1 = Item.SpellBreaker, // vanilla Item.None
            DropRate1 = 25, // vanilla 0
        },
        new()
        {
            Species = Species.MistWraith,
            Note = "Mist Wraith",
            Level = 16, // vanilla 20
            MaxHp = 302, // vanilla 115
            Str = 68, // vanilla 57
            Vit = 50, // vanilla 40
            Wit = 160, // vanilla 55
            Agi = 80, // vanilla 25
            Exp = 41, // vanilla 30
            FireResist = 6, // vanilla 4
            WaterResist = 14, // vanilla 9
            WindResist = 7, // vanilla 5
            DropItem0 = Item.OrbOfSilence, // vanilla Item.None
            DropRate0 = 16, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Invisible",
                    Speed = 0, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.OddBird,
            Note = "Odd Bird",
            MaxHp = 271, // vanilla 127
            Str = 54, // vanilla 43
            Vit = 24, // vanilla 18
            Wit = 130, // vanilla 90
            Exp = 19, // vanilla 11
            FireResist = 11, // vanilla 5
            WaterResist = 6, // vanilla 5
            WindResist = 9, // vanilla 5
            DropRate0 = 3, // vanilla 5
            DropItem1 = Item.SmellingSalts, // vanilla Item.None
            DropRate1 = 35, // vanilla 0
        },
        new()
        {
            Species = Species.Birdrake,
            Note = "Birdrake",
            MaxHp = 404, // vanilla 80
            Str = 68, // vanilla 60
            Vit = 20, // vanilla 25
            Wit = 115, // vanilla 50
            Exp = 40, // vanilla 19
            WaterResist = 7, // vanilla 5
            WindResist = 7, // vanilla 5
        },
        new()
        {
            Species = Species.Dodo,
            Note = "Dodo",
            MaxHp = 412, // vanilla 96
            Str = 80, // vanilla 52
            Vit = 30, // vanilla 15
            Wit = 120, // vanilla 65
            Agi = 65, // vanilla 40
            Exp = 50, // vanilla 25
            FireResist = 11, // vanilla 1
            WaterResist = 9, // vanilla 7
            WindResist = 6, // vanilla 10
            EarthResist = 8, // vanilla 11
            DropItem0 = Item.ChollaFlowers, // vanilla Item.SmellingSalts
            DropRate0 = 22, // vanilla 5
            DropItem1 = Item.TremorScroll, // vanilla Item.None
            DropRate1 = 10, // vanilla 0
        },
        new()
        {
            Species = Species.Slipple,
            Note = "Slipple",
            MaxHp = 322, // vanilla 67
            Str = 75, // vanilla 52
            Vit = 10, // vanilla 35
            Wit = 160, // vanilla 58
            Exp = 62, // vanilla 25
            Gold = 64, // vanilla 18
            FireResist = 12, // vanilla 9
            WaterResist = 12, // vanilla 9
            WindResist = 12, // vanilla 9
            EarthResist = 12, // vanilla 10
            DropItem1 = Item.ChollaFlowers, // vanilla Item.None
            DropRate1 = 8, // vanilla 0
        },
        new()
        {
            Species = Species.Gripple,
            Note = "Gripple",
            MaxHp = 507, // vanilla 155
            Str = 101, // vanilla 66
            Vit = 0, // vanilla 58
            Wit = 160, // vanilla 67
            Agi = 50, // vanilla 23
            Exp = 89, // vanilla 25
            Gold = 85, // vanilla 18
            AttackRange = 5, // vanilla 4
            FireResist = 14, // vanilla 5
            WaterResist = 14, // vanilla 5
            WindResist = 14, // vanilla 5
            EarthResist = 14, // vanilla 5
            DropItem0 = Item.SquidGuts, // vanilla Item.FirstAidKit
            DropRate0 = 15, // vanilla 2
            DropItem1 = Item.FirstAidKit, // vanilla Item.None
            DropRate1 = 2, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Dizzy Tentacle",
                    Speed = 100, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.Stuttle,
            Note = "Stuttle",
            MaxHp = 2688, // vanilla 336
            Str = 242, // vanilla 133
            Vit = 0, // vanilla 85
            Wit = 360, // vanilla 108
            Exp = 1304, // vanilla 125
            Gold = 561, // vanilla 240
            AttackCount = 2, // vanilla 1
            FireResist = 14, // vanilla 9
            WaterResist = 14, // vanilla 9
            WindResist = 10, // vanilla 9
            EarthResist = 14, // vanilla 10
            DropItem0 = Item.FreesiaFlowers, // vanilla Item.None
            DropRate0 = 20, // vanilla 0
            DropItem1 = Item.PhantomSilk, // vanilla Item.None
            DropRate1 = 6, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Dizzy Tentacle",
                    Speed = 120, // vanilla 30
                    Element = CombatElement.Wind, // vanilla CombatElement.None
                    AddAilment = (StatusAilment)16, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Ent,
            Note = "Ent",
            MaxHp = 188, // vanilla 55
            Str = 56, // vanilla 45
            Vit = 53, // vanilla 60
            Wit = 66, // vanilla 30
            Agi = 30, // vanilla 11
            Gold = 25, // vanilla 40
            FireResist = 6, // vanilla 4
            WaterResist = 9, // vanilla 6
            WindResist = 2, // vanilla 5
            EarthResist = 15, // vanilla 7
            DropRate0 = 9, // vanilla 20
            DropItem1 = Item.PoisonAntidote367, // vanilla Item.None
            DropRate1 = 15, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Nut Bomb",
                    Power = 13, // vanilla 25
                    AddAilment = StatusAilment.Poison, // vanilla StatusAilment.None
                    Chance = 46, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.MistGuard,
            Note = "Mist Guard",
            MaxHp = 347, // vanilla 95
            Str = 64, // vanilla 54
            Vit = 90, // vanilla 60
            Wit = 90, // vanilla 35
            Agi = 30, // vanilla 15
            Exp = 28, // vanilla 17
            FireResist = 7, // vanilla 1
            WaterResist = 7, // vanilla 11
            WindResist = 9, // vanilla 7
            EarthResist = 4, // vanilla 10
            DropRate0 = 7, // vanilla 5
            DropItem1 = Item.SmarnaWeed, // vanilla Item.None
            DropRate1 = 22, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Random Nut",
                    Power = -2, // vanilla -3
                }
            ],
        },
        new()
        {
            Species = Species.KillerTree,
            Note = "Killer Tree",
            MaxHp = 373, // vanilla 80
            Str = 73, // vanilla 57
            Vit = 45, // vanilla 60
            Wit = 100, // vanilla 20
            Agi = 65, // vanilla 17
            FireResist = 6, // vanilla 1
            WaterResist = 7, // vanilla 11
            WindResist = 8, // vanilla 4
            EarthResist = 14, // vanilla 5
            DropItem0 = Item.BaobabFruit, // vanilla Item.None
            DropRate0 = 20, // vanilla 0
        },
        new()
        {
            Species = Species.Private,
            Note = "Private",
            MaxHp = 360, // vanilla 110
            Str = 61, // vanilla 50
            Vit = 20, // vanilla 26
            Wit = 73, // vanilla 42
            Agi = 42, // vanilla 16
            Exp = 26, // vanilla 15
            Gold = 46, // vanilla 100
            FireResist = 11, // vanilla 7
            WaterResist = 4, // vanilla 7
            WindResist = 8, // vanilla 7
            EarthResist = 10, // vanilla 7
            Skills =
            [
                new SkillChange
                {
                    Name = "Heavy Blow",
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Sergeant,
            Note = "Sergeant",
            MaxHp = 550, // vanilla 220
            Str = 67, // vanilla 50
            Vit = 15, // vanilla 26
            Wit = 90, // vanilla 46
            Agi = 50, // vanilla 18
            Exp = 50, // vanilla 19
            Gold = 100, // vanilla 45
            FireResist = 8, // vanilla 7
            WaterResist = 10, // vanilla 7
            WindResist = 10, // vanilla 7
            EarthResist = 8, // vanilla 7
            DropItem0 = Item.ResurrectPotion, // vanilla Item.None
            DropRate0 = 32, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Heavy Blow",
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.EliteOfficer,
            Note = "Elite Officer",
            Level = 24, // vanilla 26
            MaxHp = 1460, // vanilla 200
            Str = 148, // vanilla 90
            Wit = 225, // vanilla 80
            Agi = 55, // vanilla 30
            Exp = 335, // vanilla 80
            Gold = 226, // vanilla 81
            FireResist = 8, // vanilla 9
            WaterResist = 6, // vanilla 9
            WindResist = 8, // vanilla 9
            EarthResist = 8, // vanilla 9
            DropItem0 = Item.ResurrectPotion, // vanilla Item.UltraDrink
            DropRate0 = 21, // vanilla 10
            DropItem1 = Item.RescueSet, // vanilla Item.MiracleDrink
            DropRate1 = 21, // vanilla 5
            Skills =
            [
                new SkillChange
                {
                    Name = "Heavy Blow",
                    Speed = 35, // vanilla 30
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.KleppSoldier,
            Note = "Klepp Soldier",
            MaxHp = 537, // vanilla 160
            Str = 99, // vanilla 62
            Wit = 110, // vanilla 30
            Agi = 50, // vanilla 30
            Exp = 78, // vanilla 35
            Gold = 82, // vanilla 40
            FireResist = 8, // vanilla 5
            WaterResist = 8, // vanilla 13
            WindResist = 8, // vanilla 7
            EarthResist = 8, // vanilla 7
            DropItem1 = Item.BamoFruit, // vanilla Item.None
            DropRate1 = 8, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Slash Mace",
                    Power = 120, // vanilla 115
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.EliteKlepp,
            Note = "Elite Klepp",
            MaxHp = 495, // vanilla 170
            Str = 88, // vanilla 65
            Wit = 120, // vanilla 70
            Agi = 60, // vanilla 40
            Exp = 82, // vanilla 40
            FireResist = 9, // vanilla 5
            WaterResist = 8, // vanilla 13
            EarthResist = 8, // vanilla 10
            DropItem0 = Item.BamoFruit, // vanilla Item.KleppsSickle
            DropRate0 = 10, // vanilla 2
            DropItem1 = Item.KleppsSickle, // vanilla Item.None
            DropRate1 = 7, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Slash Mace",
                    Power = 135, // vanilla 110
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.KleppKnight,
            Note = "Klepp Knight",
            MaxHp = 617, // vanilla 180
            Str = 99, // vanilla 70
            Vit = 70, // vanilla 50
            Wit = 100, // vanilla 58
            Agi = 50, // vanilla 40
            Exp = 90, // vanilla 45
            FireResist = 8, // vanilla 5
            WaterResist = 7, // vanilla 13
            WindResist = 6, // vanilla 7
            DropItem0 = Item.ChollaFlowers, // vanilla Item.FireCharm
            DropRate0 = 10, // vanilla 5
            DropItem1 = Item.FireCharm, // vanilla Item.None
            DropRate1 = 7, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Spin Mace",
                    Speed = 40, // vanilla 30
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.LizardRider,
            Note = "Lizard Rider",
            MaxHp = 674, // vanilla 220
            Str = 102, // vanilla 68
            Vit = 30, // vanilla 50
            Wit = 140, // vanilla 50
            Agi = 60, // vanilla 50
            Exp = 112, // vanilla 50
            Gold = 93, // vanilla 60
            FireResist = 8, // vanilla 5
            WaterResist = 7, // vanilla 13
            WindResist = 5, // vanilla 7
            DropItem0 = Item.BamoFruit, // vanilla Item.None
            DropRate0 = 15, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Breath",
                    Power = 38, // vanilla 25
                    AddAilment = (StatusAilment)16, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.MadRider,
            Note = "Mad Rider",
            MaxHp = 650, // vanilla 230
            Str = 91, // vanilla 70
            Vit = 40, // vanilla 55
            Wit = 150, // vanilla 100
            Agi = 70, // vanilla 60
            Exp = 130, // vanilla 60
            Gold = 107, // vanilla 65
            FireResist = 6, // vanilla 5
            WaterResist = 6, // vanilla 13
            WindResist = 6, // vanilla 7
            EarthResist = 8, // vanilla 10
            DropItem0 = Item.BamoFruit, // vanilla Item.None
            DropRate0 = 12, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Neck-a-Neck Breath",
                    Power = -2, // vanilla -3
                    Speed = 15, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.KleppRider,
            Note = "Klepp Rider",
            MaxHp = 700, // vanilla 216
            Str = 91, // vanilla 70
            Vit = 80, // vanilla 60
            Wit = 105, // vanilla 50
            Agi = 60, // vanilla 40
            Exp = 144, // vanilla 70
            Gold = 105, // vanilla 70
            FireResist = 10, // vanilla 5
            WaterResist = 11, // vanilla 13
            WindResist = 5, // vanilla 7
            EarthResist = 6, // vanilla 10
            DropItem0 = Item.None, // vanilla Item.MetalFrog
            DropRate0 = 0, // vanilla 10
            DropItem1 = Item.MetalFrog, // vanilla Item.None
            DropRate1 = 10, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Killer Breath",
                    Power = 20, // vanilla 110
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    Chance = 80, // vanilla 100
                }
            ],
        },
        new()
        {
            Species = Species.SquidKing,
            Note = "Squid King",
            MaxHp = 959, // vanilla 592
            Str = 40, // vanilla 34
            Wit = 42, // vanilla 26
        },
        new()
        {
            Species = Species.RightTentacle151,
            Note = "Right Tentacle",
            MaxHp = 561, // vanilla 356
            Str = 48, // vanilla 36
            Wit = 30, // vanilla 12
        },
        new()
        {
            Species = Species.LeftTentacle152,
            Note = "Left Tentacle",
            MaxHp = 671, // vanilla 438
            Str = 52, // vanilla 42
            Wit = 36, // vanilla 24
            FireResist = 4, // vanilla 5
        },
        new()
        {
            Species = Species.Ganymede156,
            Note = "Ganymede",
            MaxHp = 1807, // vanilla 1500
            Str = 106, // vanilla 42
            Wit = 25, // vanilla 15
        },
        new()
        {
            Species = Species.Ganymede157,
            Note = "Ganymede",
            MaxHp = 1807, // vanilla 1500
            Str = 62, // vanilla 47
            Wit = 100, // vanilla 15
            AttackRange = 7, // vanilla 5
            Skills =
            [
                new SkillChange
                {
                    Name = "Suck In",
                    Speed = 10, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.GaiaBird,
            Note = "Gaia Bird",
            MaxHp = 4000, // vanilla 398
            Str = 292, // vanilla 170
            Vit = 20, // vanilla 55
            Wit = 330, // vanilla 150
            Exp = 1237, // vanilla 196
            Gold = 681, // vanilla 162
            FireResist = 4, // vanilla 10
            WaterResist = 4, // vanilla 7
            WindResist = 4, // vanilla 10
            EarthResist = 4, // vanilla 7
            DropRate0 = 15, // vanilla 3
            DropRate1 = 4, // vanilla 3
            Skills =
            [
                new SkillChange
                {
                    Name = "Back Kick",
                    Power = 110, // vanilla 125
                }
            ],
        },
        new()
        {
            Species = Species.Gargoyle162,
            Note = "Gargoyle",
            Level = 99, // vanilla 40
            MaxHp = 12793, // vanilla 5739
            Vit = 3000, // vanilla 180
            Wit = 520, // vanilla 175
            Exp = 31111, // vanilla 3250
            FireResist = 8, // vanilla 10
            WaterResist = 8, // vanilla 10
            WindResist = 8, // vanilla 10
            EarthResist = 8, // vanilla 10
        },
        new()
        {
            Species = Species.Gargoyle163,
            Note = "Gargoyle",
            Level = 99, // vanilla 40
            MaxHp = 12793, // vanilla 5739
            Str = 390, // vanilla 170
            Vit = 3000, // vanilla 108
            Wit = 700, // vanilla 160
            Exp = 0, // vanilla 3250
            Gold = 28761, // vanilla 5000
            FireResist = 8, // vanilla 10
            WaterResist = 8, // vanilla 10
            WindResist = 8, // vanilla 10
            EarthResist = 8, // vanilla 10
        },
        new()
        {
            Species = Species.Madragon164,
            Note = "Madragon",
            MaxHp = 5001, // vanilla 2150
            Str = 150, // vanilla 100
            Vit = 85, // vanilla 65
            Wit = 170, // vanilla 40
            Exp = 2450, // vanilla 1450
            WaterResist = 5, // vanilla 3
            WindResist = 5, // vanilla 7
            EarthResist = 13, // vanilla 7
        },
        new()
        {
            Species = Species.Madragon165,
            Note = "Madragon",
            MaxHp = 5001, // vanilla 2150
            Str = 120, // vanilla 80
            Vit = 80, // vanilla 58
            Wit = 215, // vanilla 65
            Exp = 3350, // vanilla 1450
            WaterResist = 5, // vanilla 6
            WindResist = 5, // vanilla 7
            EarthResist = 13, // vanilla 9
            Skills =
            [
                new SkillChange
                {
                    Name = "Flame Breath",
                    Power = 65, // vanilla 50
                    Speed = 20, // vanilla 30
                    Element = CombatElement.Explosion, // vanilla CombatElement.Fire
                }
            ],
        },
        new()
        {
            Species = Species.PhantomDragon167,
            Note = "Phantom Dragon",
            MaxHp = 13001, // vanilla 3976
            Str = 275, // vanilla 135
            Vit = 140, // vanilla 60
            Wit = 400, // vanilla 105
            Exp = 29000, // vanilla 1000
            FireResist = 9, // vanilla 7
            WaterResist = 11, // vanilla 9
            Skills =
            [
                new SkillChange
                {
                    Name = "Fire Breath",
                    AddAilment = (StatusAilment)16, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.PhantomDragon168,
            Note = "Phantom Dragon",
            MaxHp = 13001, // vanilla 3976
            Vit = 140, // vanilla 60
            Wit = 360, // vanilla 110
            Gold = 10500, // vanilla 1500
            FireResist = 9, // vanilla 7
            WaterResist = 11, // vanilla 9
            Skills =
            [
                new SkillChange
                {
                    Name = "Fire Breath",
                    Power = 109, // vanilla 50
                    Speed = 10, // vanilla 30
                    AddAilment = (StatusAilment)16, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.MassacreMachine170,
            Note = "Massacre Machine",
            MaxHp = 2500, // vanilla 1800
            Str = 150, // vanilla 100
            Vit = 82, // vanilla 65
            Wit = 180, // vanilla 75
            Agi = 60, // vanilla 24
            Skills =
            [
                new SkillChange
                {
                    Name = "Spin Cut",
                    Speed = 10, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.Eye171,
            Note = "Eye",
            MaxHp = 2500, // vanilla 1800
            Str = 107, // vanilla 82
            Vit = 82, // vanilla 45
            Wit = 122, // vanilla 45
            Agi = 50, // vanilla 24
            Skills =
            [
                new SkillChange
                {
                    Name = "Spin Cut",
                    Speed = 10, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.MassacreMachine172,
            Note = "Massacre Machine",
            MaxHp = 3000, // vanilla 2000
            Str = 170, // vanilla 100
            Vit = 170, // vanilla 65
            Wit = 182, // vanilla 75
            Agi = 60, // vanilla 24
            FireResist = 5, // vanilla 10
            WaterResist = 5, // vanilla 10
            WindResist = 5, // vanilla 10
            EarthResist = 5, // vanilla 10
            Skills =
            [
                new SkillChange
                {
                    Name = "Full-Moon Cut",
                    Power = 105, // vanilla 135
                    Speed = 10, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.Eye173,
            Note = "Eye",
            MaxHp = 3000, // vanilla 2000
            Vit = 170, // vanilla 65
            Wit = 170, // vanilla 45
            Agi = 120, // vanilla 24
            FireResist = 5, // vanilla 10
            WaterResist = 5, // vanilla 10
            WindResist = 5, // vanilla 10
            EarthResist = 5, // vanilla 10
            Skills =
            [
                new SkillChange
                {
                    Name = "Full-Moon Cut",
                    Speed = 10, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.Serpent,
            Note = "Serpent",
            MaxHp = 4000, // vanilla 1071
            Str = 110, // vanilla 75
            Vit = 60, // vanilla 30
            Wit = 60, // vanilla 20
            Exp = 3220, // vanilla 1250
            FireResist = 8, // vanilla 10
            WaterResist = 8, // vanilla 10
            WindResist = 8, // vanilla 10
            EarthResist = 8, // vanilla 10
        },
        new()
        {
            Species = Species.MeanHead,
            Note = "Mean Head",
            MaxHp = 1300, // vanilla 486
            Str = 100, // vanilla 70
            Vit = 35, // vanilla 30
            Wit = 85, // vanilla 30
            FireResist = 8, // vanilla 10
            WaterResist = 7, // vanilla 10
            WindResist = 13, // vanilla 10
            EarthResist = 4, // vanilla 10
            Skills =
            [
                new SkillChange
                {
                    Name = "Killer Bite",
                    Power = 100, // vanilla 90
                }
            ],
        },
        new()
        {
            Species = Species.HotHead176,
            Note = "Hot Head",
            MaxHp = 1600, // vanilla 516
            Vit = 35, // vanilla 30
            FireResist = 13, // vanilla 10
            WaterResist = 3, // vanilla 10
            WindResist = 6, // vanilla 10
            EarthResist = 9, // vanilla 10
            Skills =
            [
                new SkillChange
                {
                    Name = "Hot Gas",
                    Power = 35, // vanilla 23
                }
            ],
        },
        new()
        {
            Species = Species.NiceHead177,
            Note = "Nice Head",
            MaxHp = 2000, // vanilla 800
            Vit = 38, // vanilla 33
            Wit = 125, // vanilla 50
            FireResist = 4, // vanilla 10
            WaterResist = 13, // vanilla 10
            WindResist = 9, // vanilla 10
            EarthResist = 6, // vanilla 10
            Skills =
            [
                new SkillChange
                {
                    Name = "Recover Gas",
                    Speed = 10, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.BadHead,
            Note = "Bad Head",
            MaxHp = 1800, // vanilla 600
            Str = 82, // vanilla 80
            Vit = 35, // vanilla 30
            Wit = 45, // vanilla 30
            FireResist = 6, // vanilla 10
            WaterResist = 9, // vanilla 10
            WindResist = 4, // vanilla 10
            EarthResist = 13, // vanilla 10
            Skills =
            [
                new SkillChange
                {
                    Name = "Stun Gas",
                    Power = 12, // vanilla 90
                    Speed = 10, // vanilla 30
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    Chance = 50, // vanilla 20
                }
            ],
        },
        new()
        {
            Species = Species.Hydra,
            Note = "Hydra",
            MaxHp = 9200, // vanilla 3721
            Str = 285, // vanilla 175
            Wit = 240, // vanilla 60
            Exp = 21000, // vanilla 1000
            FireResist = 9, // vanilla 8
            WaterResist = 9, // vanilla 8
            WindResist = 9, // vanilla 8
            EarthResist = 9, // vanilla 8
            Skills =
            [
                new SkillChange
                {
                    Name = "Head Crash",
                    Speed = 80, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.PerilHead,
            Note = "Peril Head",
            MaxHp = 5000, // vanilla 2848
            Str = 230, // vanilla 400
            Wit = 180, // vanilla 2
            FireResist = 8, // vanilla 9
            WaterResist = 6, // vanilla 9
            WindResist = 12, // vanilla 9
            EarthResist = 3, // vanilla 9
            Skills =
            [
                new SkillChange
                {
                    Name = "Sudden Death",
                    Speed = 40, // vanilla 74
                    AddAilment = (StatusAilment)19, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.HotHead181,
            Note = "Hot Head",
            MaxHp = 4500, // vanilla 2292
            Wit = 270, // vanilla 99
            FireResist = 13, // vanilla 14
            EarthResist = 10, // vanilla 7
            Skills =
            [
                new SkillChange
                {
                    Name = "Hot Gas",
                    Power = 68, // vanilla 35
                }
            ],
        },
        new()
        {
            Species = Species.NiceHead182,
            Note = "Nice Head",
            MaxHp = 4700, // vanilla 1742
            Wit = 280, // vanilla 116
            FireResist = 3, // vanilla 7
            WaterResist = 13, // vanilla 7
            WindResist = 9, // vanilla 7
            EarthResist = 6, // vanilla 7
            Skills =
            [
                new SkillChange
                {
                    Name = "Recover Gas",
                    Speed = 10, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.AwfulHead,
            Note = "Awful Head",
            MaxHp = 4300, // vanilla 2462
            Wit = 240, // vanilla 95
            FireResist = 6, // vanilla 7
            WaterResist = 9, // vanilla 7
            WindResist = 3, // vanilla 7
            EarthResist = 12, // vanilla 7
            Skills =
            [
                new SkillChange
                {
                    Name = "Poison Gas",
                    Speed = 10, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.Trent,
            Note = "Trent",
            MaxHp = 4792, // vanilla 2249
            Str = 120, // vanilla 100
            Vit = 130, // vanilla 58
            Wit = 200, // vanilla 82
            Exp = 7002, // vanilla 2000
            AttackCount = 2, // vanilla 1
            FireResist = 6, // vanilla 5
            WaterResist = 10, // vanilla 14
            WindResist = 6, // vanilla 5
            DropItem0 = Item.DragonBoots, // vanilla Item.None
            Skills =
            [
                new SkillChange
                {
                    Name = "Sleep Gas",
                    Power = 2, // vanilla 1
                }
            ],
        },
        new()
        {
            Species = Species.Arm185,
            Note = "Arm",
            MaxHp = 2685, // vanilla 1366
            Str = 142, // vanilla 110
            Wit = 180, // vanilla 65
            WindResist = 6, // vanilla 4
        },
        new()
        {
            Species = Species.Flower186,
            Note = "Flower",
            MaxHp = 6006, // vanilla 1385
            Wit = 60, // vanilla 95
            Exp = 0, // vanilla 1000
            FireResist = 5, // vanilla 3
            WaterResist = 10, // vanilla 14
            WindResist = 5, // vanilla 4
            Skills =
            [
                new SkillChange
                {
                    Name = "Flower Beam",
                    Power = 279, // vanilla 57
                    AddAilment = (StatusAilment)13, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.GaiaTrent,
            Note = "Gaia Trent",
            Level = 95, // vanilla 64
            MaxHp = 19000, // vanilla 4578
            Str = 600, // vanilla 155
            Vit = 650, // vanilla 65
            Wit = 750, // vanilla 154
            Agi = 90, // vanilla 20
            Exp = 48814, // vanilla 2765
            Gold = 0, // vanilla 7200
            FireResist = 11, // vanilla 12
            WaterResist = 11, // vanilla 12
            WindResist = 11, // vanilla 12
            EarthResist = 11, // vanilla 12
            DropItem0 = Item.FrostHerb, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Sleep Pollen",
                    Power = 67, // vanilla 5
                    Strength = false, // vanilla True
                    Element = CombatElement.Forest, // vanilla CombatElement.Water
                    Effect = EffectType.Damage, // vanilla EffectType.Status
                    Mode = (int)DamageKind.Magic, // vanilla (int)StatusAilment.Sleep
                    AddAilment = StatusAilment.Plague, // vanilla StatusAilment.None
                    Chance = 64, // vanilla 0
                    AddLevel = 5, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Arm188,
            Note = "Arm",
            Level = 95, // vanilla 64
            MaxHp = 13000, // vanilla 2963
            Str = 460, // vanilla 165
            Wit = 600, // vanilla 155
            Exp = 0, // vanilla 1500
            Gold = 0, // vanilla 3600
            AttackCount = 1, // vanilla 2
            FireResist = 6, // vanilla 12
            WaterResist = 11, // vanilla 12
            WindResist = 4, // vanilla 12
            EarthResist = 6, // vanilla 12
        },
        new()
        {
            Species = Species.Flower189,
            Note = "Flower",
            Level = 95, // vanilla 64
            MaxHp = 21000, // vanilla 3167
            Wit = 400, // vanilla 146
            Exp = 0, // vanilla 1500
            Gold = 0, // vanilla 3600
            FireResist = 7, // vanilla 12
            WaterResist = 7, // vanilla 12
            WindResist = 7, // vanilla 12
            EarthResist = 7, // vanilla 12
            Skills =
            [
                new SkillChange
                {
                    Name = "Flower Laser",
                    Power = 375, // vanilla 91
                    Speed = 20, // vanilla 30
                    AddAilment = (StatusAilment)14, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.LordsGhost190,
            Note = "Lord's Ghost",
            MaxHp = 6000, // vanilla 4500
            Vit = 3000, // vanilla 61
            Wit = 305, // vanilla 100
            FireResist = 5, // vanilla 9
            WaterResist = 5, // vanilla 9
            WindResist = 5, // vanilla 9
            EarthResist = 5, // vanilla 9
            DropItem0 = Item.LordsWand, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
        },
        new()
        {
            Species = Species.LordsGhost191,
            Note = "Lord's Ghost",
            MaxHp = 6000, // vanilla 4500
            Vit = 3000, // vanilla 61
            Wit = 90, // vanilla 130
            Agi = 3000, // vanilla 7
            Exp = 17000, // vanilla 4950
            FireResist = 5, // vanilla 9
            WaterResist = 5, // vanilla 9
            WindResist = 5, // vanilla 9
            EarthResist = 5, // vanilla 9
            Skills =
            [
                new SkillChange
                {
                    Name = "X-Ray",
                    Power = 170, // vanilla 67
                    AddAilment = (StatusAilment)13, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        }
    ];
}
