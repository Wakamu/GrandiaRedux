using Grandia.Sdk;

namespace GrandiaRedux.Enemies;

/// <summary>
/// Values that differ between HD Remaster <c>BATLE/M_DAT.BIN</c> and
/// Redux 0.4.9 <c>redux_content/BATLE/M_DAT.BIN</c>. Unlisted fields stay vanilla.
/// </summary>
internal static class Ids192
{
    internal static readonly EnemyEdit[] All =
    [
        new()
        {
            Species = Species.Wand192,
            Note = "Wand",
            MaxHp = 4200, // vanilla 3000
            Str = 210, // vanilla 120
            Vit = 0, // vanilla 78
            Wit = 330, // vanilla 70
            FireResist = 14, // vanilla 9
            WaterResist = 14, // vanilla 9
            WindResist = 14, // vanilla 9
            EarthResist = 14, // vanilla 9
        },
        new()
        {
            Species = Species.MageKing193,
            Note = "Mage King",
            Level = 70, // vanilla 60
            MaxHp = 13298, // vanilla 3892
            Vit = 3000, // vanilla 100
            Wit = 370, // vanilla 128
            Exp = 37833, // vanilla 1135
            Gold = 0, // vanilla 3200
            WaterResist = 3, // vanilla 7
            WindResist = 6, // vanilla 7
            EarthResist = 3, // vanilla 7
            DropItem0 = Item.SpiritStaff, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
        },
        new()
        {
            Species = Species.MageKing194,
            Note = "Mage King",
            Level = 70, // vanilla 60
            MaxHp = 13298, // vanilla 3892
            Vit = 3000, // vanilla 100
            Wit = 150, // vanilla 146
            Exp = 0, // vanilla 1135
            Gold = 0, // vanilla 3200
            WaterResist = 3, // vanilla 7
            WindResist = 6, // vanilla 7
            EarthResist = 3, // vanilla 7
            DropItem0 = Item.DeepBluePotion, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Atomic Shot",
                    Power = 25, // vanilla 30
                    AddAilment = (StatusAilment)18, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 7, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Wand195,
            Note = "Wand",
            Level = 70, // vanilla 60
            MaxHp = 7648, // vanilla 2346
            Str = 440, // vanilla 141
            Vit = 0, // vanilla 62
            Wit = 300, // vanilla 60
            Exp = 0, // vanilla 1135
            Gold = 0, // vanilla 3200
            FireResist = 14, // vanilla 12
            WaterResist = 14, // vanilla 12
            WindResist = 14, // vanilla 12
            EarthResist = 14, // vanilla 12
            DropItem0 = Item.GoldenPotion, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
        },
        new()
        {
            Species = Species.RuinGuard,
            Note = "Ruin Guard",
            MaxHp = 8421, // vanilla 4500
            Str = 220, // vanilla 110
            Vit = 140, // vanilla 70
            Wit = 240, // vanilla 130
            Agi = 45, // vanilla 25
            Exp = 21777, // vanilla 3950
            FireResist = 8, // vanilla 4
            WaterResist = 8, // vanilla 10
            WindResist = 8, // vanilla 10
            EarthResist = 8, // vanilla 4
        },
        new()
        {
            Species = Species.Ax197,
            Note = "Ax",
            MaxHp = 4198, // vanilla 2350
            Str = 275, // vanilla 165
            Vit = 240, // vanilla 150
            Wit = 200, // vanilla 135
            FireResist = 5, // vanilla 6
            WaterResist = 11, // vanilla 6
            WindResist = 2, // vanilla 6
        },
        new()
        {
            Species = Species.Boomerang,
            Note = "Boomerang",
            MaxHp = 3475, // vanilla 2350
            Str = 240, // vanilla 140
            Wit = 425, // vanilla 400
            WaterResist = 10, // vanilla 4
            WindResist = 10, // vanilla 4
        },
        new()
        {
            Species = Species.GreatSusanoO,
            Note = "Great Susano-o",
            MaxHp = 10762, // vanilla 3453
            Wit = 260, // vanilla 70
            Agi = 45, // vanilla 10
            Exp = 25500, // vanilla 1000
            FireResist = 8, // vanilla 7
            WaterResist = 8, // vanilla 7
            WindResist = 8, // vanilla 7
            EarthResist = 8, // vanilla 7
        },
        new()
        {
            Species = Species.Ax201,
            Note = "Ax",
            MaxHp = 4525, // vanilla 2306
            Str = 235, // vanilla 140
            Wit = 280, // vanilla 90
            FireResist = 5, // vanilla 7
            WaterResist = 11, // vanilla 7
            WindResist = 1, // vanilla 7
            EarthResist = 5, // vanilla 7
        },
        new()
        {
            Species = Species.IronBall,
            Note = "Iron Ball",
            MaxHp = 3975, // vanilla 1600
            Str = 360, // vanilla 140
            Wit = 85, // vanilla 200
            FireResist = 10, // vanilla 7
            WaterResist = 11, // vanilla 7
            WindResist = 9, // vanilla 7
            EarthResist = 10, // vanilla 7
            Skills =
            [
                new SkillChange
                {
                    Name = "Hammer Shot",
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 3, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Chang,
            Note = "Chang",
            MaxHp = 999, // vanilla 738
            Str = 52, // vanilla 38
            Vit = 28, // vanilla 21
            Wit = 90, // vanilla 50
            Agi = 50, // vanilla 35
            Exp = 164, // vanilla 235
            FireResist = 6, // vanilla 10
            WaterResist = 6, // vanilla 10
            WindResist = 6, // vanilla 10
            EarthResist = 6, // vanilla 10
            Skills =
            [
                new SkillChange
                {
                    Name = "Spin Kick",
                    Power = 110, // vanilla 21
                    Speed = 10, // vanilla 30
                    Mode = (int)DamageKind.Physical, // vanilla (int)DamageKind.Magic
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Gadwin205,
            Note = "Gadwin",
            MaxHp = 273, // vanilla 300
            Vit = 245, // vanilla 999
            Exp = 9999, // vanilla 0
            FireResist = 13, // vanilla 14
            WaterResist = 13, // vanilla 14
            WindResist = 13, // vanilla 14
            EarthResist = 13, // vanilla 14
            DropItem0 = Item.SatisfactionGem, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
        },
        new()
        {
            Species = Species.Gadwin206,
            Note = "Gadwin",
            MaxHp = 2150, // vanilla 1525
            Str = 110, // vanilla 75
            Vit = 91, // vanilla 75
            Wit = 115, // vanilla 30
            Agi = 46, // vanilla 15
            Exp = 1500, // vanilla 4000
            WaterResist = 12, // vanilla 10
            WindResist = 8, // vanilla 10
        },
        new()
        {
            Species = Species.KungFuMaster,
            Note = "Kung Fu Master",
            Level = 50, // vanilla 42
            MaxHp = 11212, // vanilla 4776
            Str = 330, // vanilla 165
            Vit = 300, // vanilla 100
            Wit = 770, // vanilla 195
            Agi = 70, // vanilla 45
            Exp = 35353, // vanilla 9800
            FireResist = 11, // vanilla 9
            WaterResist = 11, // vanilla 9
            WindResist = 11, // vanilla 9
            EarthResist = 11, // vanilla 9
            DropItem0 = Item.BentMattock, // vanilla Item.SatisfactionGem
            Skills =
            [
                new SkillChange
                {
                    Name = "Spin Kick",
                    Power = 135, // vanilla 60
                    Element = CombatElement.Wind, // vanilla CombatElement.None
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Mullen,
            Note = "Mullen",
            MaxHp = 9998, // vanilla 2946
            Str = 330, // vanilla 180
            Vit = 250, // vanilla 112
            Wit = 410, // vanilla 160
            Exp = 20000, // vanilla 5682
            WaterResist = 11, // vanilla 10
            WindResist = 9, // vanilla 10
            Skills =
            [
                new SkillChange
                {
                    Name = "Sonic Boom",
                    Power = 98, // vanilla 30
                    AddAilment = (StatusAilment)16, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Saki209,
            Note = "Saki",
            MaxHp = 1500, // vanilla 1000
            Str = 59, // vanilla 53
            Exp = 222, // vanilla 85
            Skills =
            [
                new SkillChange
                {
                    Name = "Power Lariat",
                    Speed = 45, // vanilla 30
                    AddAilment = (StatusAilment)18, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Saki210,
            Note = "Saki",
            MaxHp = 7000, // vanilla 5000
            Str = 202, // vanilla 140
            Wit = 230, // vanilla 120
            Exp = 7000, // vanilla 3200
            AttackCount = 2, // vanilla 1
            FireResist = 6, // vanilla 7
            WaterResist = 6, // vanilla 7
            WindResist = 6, // vanilla 7
            EarthResist = 6, // vanilla 7
            Skills =
            [
                new SkillChange
                {
                    Name = "Max Lariat",
                    Power = 140, // vanilla 130
                    Speed = 55, // vanilla 30
                    AddAilment = (StatusAilment)18, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Mio211,
            Note = "Mio",
            MaxHp = 1300, // vanilla 700
            Str = 75, // vanilla 50
            Wit = 130, // vanilla 110
            Agi = 50, // vanilla 30
            Exp = 522, // vanilla 85
            Gold = 0, // vanilla 2000
            FireResist = 9, // vanilla 7
            WaterResist = 9, // vanilla 7
            EarthResist = 9, // vanilla 7
            DropItem0 = Item.ManaEgg, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Balloon",
                    Speed = 80, // vanilla 60
                }
            ],
        },
        new()
        {
            Species = Species.Mio212,
            Note = "Mio",
            MaxHp = 6000, // vanilla 3000
            Str = 220, // vanilla 130
            Vit = 130, // vanilla 70
            Wit = 320, // vanilla 80
            Agi = 50, // vanilla 30
            Exp = 7000, // vanilla 3200
            AttackCount = 1, // vanilla 2
            FireResist = 9, // vanilla 7
            WaterResist = 11, // vanilla 7
            WindResist = 8, // vanilla 7
            EarthResist = 9, // vanilla 7
            Skills =
            [
                new SkillChange
                {
                    Name = "Super Balloon",
                    Speed = 85, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.Nana213,
            Note = "Nana",
            MaxHp = 1400, // vanilla 900
            Str = 70, // vanilla 60
            Wit = 115, // vanilla 100
            Exp = 372, // vanilla 85
            DropItem0 = Item.Yoyo, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Yo-Yo",
                    Power = 16, // vanilla 10
                }
            ],
        },
        new()
        {
            Species = Species.Nana214,
            Note = "Nana",
            MaxHp = 6500, // vanilla 4000
            Str = 232, // vanilla 150
            Vit = 100, // vanilla 70
            Wit = 300, // vanilla 90
            Exp = 7000, // vanilla 3200
            FireResist = 8, // vanilla 7
            WaterResist = 8, // vanilla 7
            WindResist = 8, // vanilla 7
            EarthResist = 8, // vanilla 7
            Skills =
            [
                new SkillChange
                {
                    Name = "Electric Yo-Yo",
                    Power = 50, // vanilla 20
                    Speed = 40, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.Grinwhale,
            Note = "Grinwhale",
            MaxHp = 3636, // vanilla 1985
            Str = 120, // vanilla 80
            Wit = 135, // vanilla 60
            Skills =
            [
                new SkillChange
                {
                    Name = "Electric Shock",
                    Power = 55, // vanilla 40
                    Speed = 100, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.Lure216,
            Note = "Lure",
            MaxHp = 2122, // vanilla 1733
            Str = 112, // vanilla 90
            Wit = 140, // vanilla 85
            DropItem0 = Item.LuresHeart, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Entice",
                    Power = 117, // vanilla 130
                    Speed = 10, // vanilla 30
                    AddAilment = (StatusAilment)20, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 7, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.SlugFish,
            Note = "Slug Fish",
            Level = 99, // vanilla 45
            MaxHp = 15826, // vanilla 3459
            Str = 300, // vanilla 148
            Vit = 250, // vanilla 135
            Wit = 650, // vanilla 168
            Exp = 35555, // vanilla 4000
            Gold = 0, // vanilla 6400
            Skills =
            [
                new SkillChange
                {
                    Name = "Electric Shock",
                    Power = 179, // vanilla 60
                    Speed = 60, // vanilla 30
                    AddAilment = (StatusAilment)16, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Lure218,
            Note = "Lure",
            Level = 99, // vanilla 45
            MaxHp = 12336, // vanilla 2869
            Str = 420, // vanilla 152
            Vit = 200, // vanilla 125
            Wit = 675, // vanilla 175
            Exp = 0, // vanilla 4000
            DropItem0 = Item.Talisman, // vanilla Item.MysteriousVeil
            Skills =
            [
                new SkillChange
                {
                    Name = "Entice",
                    Power = 100, // vanilla 140
                    Speed = 10, // vanilla 30
                    AddAilment = (StatusAilment)18, // vanilla StatusAilment.Confuse
                    Chance = 100, // vanilla 16
                }
            ],
        },
        new()
        {
            Species = Species.Baal219,
            Note = "Baal",
            MaxHp = 4998, // vanilla 2783
            Str = 228, // vanilla 162
            Vit = 130, // vanilla 58
            Wit = 260, // vanilla 116
            Agi = 35, // vanilla 24
            Exp = 9999, // vanilla 4500
        },
        new()
        {
            Species = Species.Baal220,
            Note = "Baal",
            Level = 55, // vanilla 40
            MaxHp = 4998, // vanilla 6000
            Str = 390, // vanilla 175
            Vit = 3000, // vanilla 120
            Wit = 500, // vanilla 230
            Agi = 246, // vanilla 45
            Exp = 56994, // vanilla 5800
            Gold = 25000, // vanilla 5000
            FireResist = 14, // vanilla 10
            WaterResist = 14, // vanilla 10
            WindResist = 14, // vanilla 10
            EarthResist = 14, // vanilla 10
            Skills =
            [
                new SkillChange
                {
                    Name = "Gaia Power",
                    Speed = 0, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.GaiaTentacle221,
            Note = "Gaia Tentacle",
            MaxHp = 25000, // vanilla 7000
            Wit = 480, // vanilla 250
            Exp = 0, // vanilla 5800
            FireResist = 6, // vanilla 7
            WaterResist = 6, // vanilla 7
            WindResist = 6, // vanilla 7
            EarthResist = 6, // vanilla 7
            DropItem0 = Item.GaiaWand, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Gaia Strike",
                    Power = 250, // vanilla 130
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.Baal222,
            Note = "Baal",
            MaxHp = 27000, // vanilla 7000
            Str = 510, // vanilla 180
            Wit = 1000, // vanilla 125
            Exp = 63837, // vanilla 0
            Gold = 0, // vanilla 100
            WaterResist = 11, // vanilla 9
            Skills =
            [
                new SkillChange
                {
                    Name = "Grand Cross",
                    Power = 100, // vanilla 140
                    Speed = 50, // vanilla 45
                }
            ],
        },
        new()
        {
            Species = Species.GaiaTentacle223,
            Note = "Gaia Tentacle",
            MaxHp = 21000, // vanilla 6000
            Wit = 1150, // vanilla 200
            Exp = 0, // vanilla 2270
            Gold = 0, // vanilla 100
            FireResist = 3, // vanilla 9
            WaterResist = 3, // vanilla 9
            WindResist = 3, // vanilla 9
            EarthResist = 3, // vanilla 9
        },
        new()
        {
            Species = Species.GaiaTentacle224,
            Note = "Gaia Tentacle",
            MaxHp = 17000, // vanilla 5456
            Wit = 600, // vanilla 200
            Exp = 0, // vanilla 2270
            Gold = 0, // vanilla 100
            FireResist = 4, // vanilla 9
            WaterResist = 4, // vanilla 9
            WindResist = 4, // vanilla 9
            EarthResist = 4, // vanilla 9
        },
        new()
        {
            Species = Species.GaiaBattler225,
            Note = "Gaia Battler",
            MaxHp = 7394, // vanilla 2473
            Wit = 180, // vanilla 110
            Agi = 48, // vanilla 20
            Exp = 15000, // vanilla 3100
            WindResist = 6, // vanilla 9
            Skills =
            [
                new SkillChange
                {
                    Name = "Poison Gas",
                    Power = 60, // vanilla 120
                    Speed = 10, // vanilla 30
                    Element = CombatElement.Forest, // vanilla CombatElement.None
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.RightHand226,
            Note = "Right Hand",
            MaxHp = 3408, // vanilla 1708
            Str = 150, // vanilla 110
            Wit = 190, // vanilla 130
            AttackCount = 2, // vanilla 1
            WaterResist = 7, // vanilla 1
            EarthResist = 5, // vanilla 1
            Skills =
            [
                new SkillChange
                {
                    Name = "Ray Spread",
                    Power = 42, // vanilla 140
                    Element = CombatElement.Earth, // vanilla CombatElement.None
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    AddAilment = (StatusAilment)19, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.LeftHand227,
            Note = "Left Hand",
            MaxHp = 3972, // vanilla 1972
            Str = 180, // vanilla 136
            Wit = 190, // vanilla 90
            Skills =
            [
                new SkillChange
                {
                    Name = "Combination",
                    Power = 200, // vanilla 140
                }
            ],
        },
        new()
        {
            Species = Species.GaiaBattler228,
            Note = "Gaia Battler",
            Level = 37, // vanilla 34
            MaxHp = 8847, // vanilla 3567
            Str = 200, // vanilla 135
            Vit = 165, // vanilla 120
            Wit = 175, // vanilla 145
            Agi = 65, // vanilla 20
            Exp = 24500, // vanilla 3300
            Skills =
            [
                new SkillChange
                {
                    Name = "Poison Gas",
                    Power = 65, // vanilla 90
                    Speed = 10, // vanilla 30
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.RightHand229,
            Note = "Right Hand",
            Level = 37, // vanilla 33
            MaxHp = 4475, // vanilla 2528
            Str = 215, // vanilla 126
            Vit = 160, // vanilla 100
            Wit = 330, // vanilla 165
            AttackCount = 2, // vanilla 1
            Skills =
            [
                new SkillChange
                {
                    Name = "Grand Heal",
                    Power = 1000, // vanilla 500
                    Speed = 1, // vanilla 30
                    AddAilment = (StatusAilment)21, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.LeftHand230,
            Note = "Left Hand",
            Level = 37, // vanilla 32
            MaxHp = 4739, // vanilla 2573
            Str = 250, // vanilla 146
            Wit = 270, // vanilla 115
            FireResist = 5, // vanilla 1
            WaterResist = 5, // vanilla 1
            WindResist = 5, // vanilla 1
            EarthResist = 5, // vanilla 1
            Skills =
            [
                new SkillChange
                {
                    Name = "Combination",
                    Power = 140, // vanilla 135
                }
            ],
        },
        new()
        {
            Species = Species.GaiaBattler231,
            Note = "Gaia Battler",
            Level = 60, // vanilla 51
            MaxHp = 16276, // vanilla 4976
            Vit = 400, // vanilla 120
            Wit = 440, // vanilla 140
            Agi = 60, // vanilla 30
            Exp = 31711, // vanilla 3300
            Gold = 15386, // vanilla 6000
            FireResist = 10, // vanilla 7
            WaterResist = 10, // vanilla 7
            WindResist = 10, // vanilla 7
            EarthResist = 10, // vanilla 7
            Skills =
            [
                new SkillChange
                {
                    Name = "Rust Gas",
                    Power = 104, // vanilla 120
                    Speed = 10, // vanilla 30
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.RightHand232,
            Note = "Right Hand",
            MaxHp = 7534, // vanilla 2742
            Str = 425, // vanilla 145
            Vit = 3000, // vanilla 600
            Wit = 380, // vanilla 155
            AttackCount = 2, // vanilla 1
            FireResist = 3, // vanilla 1
            WaterResist = 3, // vanilla 1
            WindResist = 3, // vanilla 1
            EarthResist = 3, // vanilla 1
            Skills =
            [
                new SkillChange
                {
                    Name = "Ray Spread",
                    Power = 129, // vanilla 40
                    Speed = 20, // vanilla 30
                    Element = CombatElement.Earth, // vanilla CombatElement.None
                    AddAilment = (StatusAilment)19, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.LeftHand233,
            Note = "Left Hand",
            MaxHp = 8219, // vanilla 3109
            Str = 350, // vanilla 160
            Vit = 0, // vanilla 80
            Wit = 390, // vanilla 125
            FireResist = 14, // vanilla 12
            WaterResist = 14, // vanilla 12
            WindResist = 14, // vanilla 12
            EarthResist = 14, // vanilla 12
            Skills =
            [
                new SkillChange
                {
                    Name = "Combination",
                    Power = 140, // vanilla 130
                    Speed = 55, // vanilla 60
                }
            ],
        },
        new()
        {
            Species = Species.GaiaBattler234,
            Note = "Gaia Battler",
            Level = 85, // vanilla 70
            MaxHp = 14836, // vanilla 5871
            Vit = 750, // vanilla 40
            Wit = 400, // vanilla 125
            Agi = 80, // vanilla 27
            Exp = 40826, // vanilla 3300
            Gold = 0, // vanilla 6000
            FireResist = 10, // vanilla 7
            WaterResist = 10, // vanilla 7
            WindResist = 10, // vanilla 7
            EarthResist = 10, // vanilla 7
            DropItem0 = Item.SpiritWhip, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Rust Gas",
                    Power = 104, // vanilla 120
                    Speed = 10, // vanilla 30
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                }
            ],
        },
        new()
        {
            Species = Species.RightHand235,
            Note = "Right Hand",
            Level = 85, // vanilla 72
            MaxHp = 7026, // vanilla 4237
            Str = 442, // vanilla 171
            Vit = 3000, // vanilla 800
            Wit = 500, // vanilla 140
            Exp = 0, // vanilla 1500
            Gold = 0, // vanilla 3450
            FireResist = 3, // vanilla 1
            WaterResist = 3, // vanilla 1
            WindResist = 3, // vanilla 1
            EarthResist = 3, // vanilla 1
            DropItem0 = Item.RustyShovel, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Ray Spread",
                    Power = 129, // vanilla 35
                    Speed = 10, // vanilla 30
                    AddAilment = (StatusAilment)19, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.LeftHand236,
            Note = "Left Hand",
            Level = 85, // vanilla 73
            MaxHp = 7731, // vanilla 4291
            Str = 455, // vanilla 171
            Vit = 180, // vanilla 20
            Wit = 450, // vanilla 120
            Exp = 0, // vanilla 1500
            Gold = 0, // vanilla 3450
            FireResist = 14, // vanilla 12
            WaterResist = 14, // vanilla 12
            WindResist = 14, // vanilla 12
            EarthResist = 14, // vanilla 12
            DropItem0 = Item.SoulOfAsura, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Combination",
                    Power = 140, // vanilla 125
                    Speed = 55, // vanilla 60
                }
            ],
        },
        new()
        {
            Species = Species.GaiaCore237,
            Note = "Gaia Core",
            MaxHp = 29999, // vanilla 9999
            Vit = 1000, // vanilla 100
            Wit = 500, // vanilla 100
            FireResist = 11, // vanilla 9
            WaterResist = 11, // vanilla 9
            WindResist = 11, // vanilla 9
            EarthResist = 11, // vanilla 9
        },
        new()
        {
            Species = Species.MegaGaia,
            Note = "Mega Gaia",
            MaxHp = 19999, // vanilla 4800
            Str = 500, // vanilla 200
            Vit = 850, // vanilla 110
            Wit = 750, // vanilla 328
            FireResist = 9, // vanilla 12
            WaterResist = 9, // vanilla 12
            WindResist = 9, // vanilla 12
            EarthResist = 9, // vanilla 12
        },
        new()
        {
            Species = Species.GaiaTentacle240,
            Note = "Gaia Tentacle",
            MaxHp = 8000, // vanilla 1300
            Str = 440, // vanilla 200
            Vit = 50, // vanilla 10
            Wit = 440, // vanilla 120
            FireResist = 5, // vanilla 13
            WaterResist = 5, // vanilla 13
            WindResist = 5, // vanilla 13
            EarthResist = 5, // vanilla 13
        },
        new()
        {
            Species = Species.EvilGaia,
            Note = "Evil Gaia",
            MaxHp = 22666, // vanilla 9999
            Vit = 500, // vanilla 0
            Wit = 1800, // vanilla 256
            FireResist = 10, // vanilla 11
            WaterResist = 10, // vanilla 11
            WindResist = 10, // vanilla 11
            EarthResist = 10, // vanilla 11
        },
        new()
        {
            Species = Species.GaiaCore242,
            Note = "Gaia Core (vanilla HP 786)",
            When = e => e.MaxHp == 786 && e.Level == 15,
        },
        new()
        {
            Species = Species.GaiaCore242,
            Note = "Gaia Core (vanilla HP 786)",
            When = e => e.MaxHp == 786 && e.Level == 15,
        },
        new()
        {
            Species = Species.GaiaCore242,
            Note = "Gaia Core (vanilla HP 786)",
            When = e => e.MaxHp == 786 && e.Level == 15,
        },
        new()
        {
            Species = Species.GaiaCore242,
            Note = "Gaia Core (vanilla HP 786)",
            When = e => e.MaxHp == 786 && e.Level == 15,
        },
        new()
        {
            Species = Species.GaiaArmor,
            Note = "Gaia Armor",
            Level = 99, // vanilla 70
            MaxHp = 24000, // vanilla 6785
            Str = 740, // vanilla 192
            Vit = 700, // vanilla 90
            Wit = 1300, // vanilla 255
            Agi = 100, // vanilla 23
            Exp = 56825, // vanilla 3500
            Gold = 0, // vanilla 7460
            FireResist = 8, // vanilla 12
            WaterResist = 11, // vanilla 12
            WindResist = 5, // vanilla 12
            EarthResist = 9, // vanilla 12
            DropItem0 = Item.SpiritArmor, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Dead Circle",
                    Power = 90, // vanilla 145
                    AddAilment = StatusAilment.Stop, // vanilla StatusAilment.None
                    Chance = 40, // vanilla 0
                    AddLevel = 2, // vanilla 0
                }
            ],
        },
        new()
        {
            Species = Species.Eye245,
            Note = "Eye",
            Level = 99, // vanilla 70
            MaxHp = 24000, // vanilla 6785
            Vit = 700, // vanilla 90
            Wit = 280, // vanilla 255
            Exp = 0, // vanilla 3500
            Gold = 0, // vanilla 7460
            FireResist = 8, // vanilla 12
            WaterResist = 11, // vanilla 12
            WindResist = 5, // vanilla 12
            EarthResist = 9, // vanilla 12
            DropItem0 = Item.RingOfProtection, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
        },
        new()
        {
            Species = Species.GaiaSlime,
            Note = "Gaia Slime",
            Level = 90, // vanilla 72
            MaxHp = 7200, // vanilla 331
            Str = 435, // vanilla 170
            Vit = 0, // vanilla 190
            Wit = 500, // vanilla 128
            Agi = 40, // vanilla 18
            Exp = 2836, // vanilla 236
            Gold = 0, // vanilla 238
            FireResist = 5, // vanilla 4
            WaterResist = 7, // vanilla 4
            WindResist = 5, // vanilla 4
            DropItem0 = Item.ResurrectPotion, // vanilla Item.None
            DropRate0 = 60, // vanilla 0
            DropItem1 = Item.DiseaseCharm, // vanilla Item.None
            DropRate1 = 10, // vanilla 0
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
            Species = Species.Combatant,
            Note = "Combatant",
            MaxHp = 2000, // vanilla 344
            Str = 205, // vanilla 125
            Vit = 120, // vanilla 78
            Wit = 275, // vanilla 105
            Agi = 45, // vanilla 25
            Exp = 782, // vanilla 98
            Gold = 612, // vanilla 125
            FireResist = 6, // vanilla 7
            WaterResist = 6, // vanilla 7
            WindResist = 6, // vanilla 7
            EarthResist = 6, // vanilla 7
            DropItem0 = Item.CrimsonPotion, // vanilla Item.RescueSet
            DropRate0 = 10, // vanilla 15
            DropRate1 = 7, // vanilla 5
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
            Species = Species.GaiaTree,
            Note = "Gaia Tree",
            Level = 90, // vanilla 71
            MaxHp = 5300, // vanilla 356
            Str = 430, // vanilla 166
            Vit = 300, // vanilla 170
            Wit = 470, // vanilla 168
            Agi = 40, // vanilla 18
            Exp = 3289, // vanilla 215
            Gold = 0, // vanilla 291
            FireResist = 4, // vanilla 1
            WaterResist = 11, // vanilla 13
            WindResist = 5, // vanilla 8
            EarthResist = 11, // vanilla 13
            DropItem0 = Item.RedMedicine, // vanilla Item.None
            DropRate0 = 50, // vanilla 0
            DropItem1 = Item.BlueMedicine, // vanilla Item.None
            DropRate1 = 40, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Illusion",
                    Power = 5, // vanilla 3
                    Speed = 20, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.GaiaBeetle,
            Note = "Gaia Beetle",
            Level = 95, // vanilla 85
            MaxHp = 2400, // vanilla 308
            Str = 490, // vanilla 152
            Wit = 900, // vanilla 160
            Agi = 100, // vanilla 26
            Exp = 4736, // vanilla 253
            Gold = 0, // vanilla 249
            FireResist = 7, // vanilla 8
            WaterResist = 2, // vanilla 8
            WindResist = 7, // vanilla 8
            EarthResist = 7, // vanilla 11
            DropItem0 = Item.BlueMedicine, // vanilla Item.None
            DropRate0 = 80, // vanilla 0
            DropItem1 = Item.Weeds, // vanilla Item.None
            DropRate1 = 40, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Wing Beat",
                    Power = 79, // vanilla 130
                    Element = CombatElement.Water, // vanilla CombatElement.None
                    Mode = (int)DamageKind.Magic, // vanilla (int)DamageKind.Physical
                    Chance = 40, // vanilla 50
                    AddLevel = 2, // vanilla 3
                }
            ],
        },
        new()
        {
            Species = Species.Leviathan,
            Note = "Leviathan",
            Level = 99, // vanilla 55
            MaxHp = 22568, // vanilla 7869
            Vit = 400, // vanilla 47
            Wit = 450, // vanilla 170
            Exp = 50005, // vanilla 4500
            Skills =
            [
                new SkillChange
                {
                    Name = "Suck In",
                    Speed = 0, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.RightTentacle251,
            Note = "Right Tentacle",
            Level = 99, // vanilla 55
            MaxHp = 12992, // vanilla 4037
            Str = 330, // vanilla 144
            Vit = 200, // vanilla 88
            Wit = 475, // vanilla 175
            Exp = 0, // vanilla 4500
            Gold = 0, // vanilla 6450
            FireResist = 7, // vanilla 13
            WaterResist = 9, // vanilla 13
            WindResist = 7, // vanilla 13
            EarthResist = 7, // vanilla 13
            DropItem0 = Item.AllAroundFruit, // vanilla Item.None
            DropRate0 = 100, // vanilla 0
        },
        new()
        {
            Species = Species.LeftTentacle252,
            Note = "Left Tentacle",
            Level = 99, // vanilla 55
            MaxHp = 13343, // vanilla 3877
            Str = 345, // vanilla 156
            Vit = 200, // vanilla 125
            Wit = 500, // vanilla 161
            Exp = 0, // vanilla 4500
            Gold = 40004, // vanilla 6450
            FireResist = 7, // vanilla 11
            WaterResist = 9, // vanilla 11
            WindResist = 7, // vanilla 11
            EarthResist = 7, // vanilla 11
        },
        new()
        {
            Species = Species.Orc,
            Note = "Orc",
            MaxHp = 120, // vanilla 70
            Str = 36, // vanilla 29
            Wit = 20, // vanilla 15
            Exp = 5, // vanilla 4
            DropItem0 = Item.BaobabFruit, // vanilla Item.None
            DropRate0 = 20, // vanilla 0
        },
        new()
        {
            Species = Species.OrcKing,
            Note = "Orc King",
            MaxHp = 520, // vanilla 385
            Str = 42, // vanilla 32
            Wit = 28, // vanilla 15
            Exp = 50, // vanilla 70
            Skills =
            [
                new SkillChange
                {
                    Name = "Fire Breath",
                    Power = 29, // vanilla 17
                    Speed = 85, // vanilla 30
                }
            ],
        },
        new()
        {
            Species = Species.DomOrc,
            Note = "Dom Orc",
            MaxHp = 350, // vanilla 106
            Str = 61, // vanilla 45
            Wit = 65, // vanilla 32
            Exp = 33, // vanilla 14
            FireResist = 10, // vanilla 7
            WaterResist = 6, // vanilla 7
            WindResist = 10, // vanilla 7
            DropRate0 = 7, // vanilla 10
            DropItem1 = Item.BeefJerky, // vanilla Item.None
            DropRate1 = 15, // vanilla 0
            Skills =
            [
                new SkillChange
                {
                    Name = "Bite",
                    Power = 110, // vanilla 120
                    Speed = 25, // vanilla 30
                    AddAilment = (StatusAilment)15, // vanilla StatusAilment.None
                    Chance = 100, // vanilla 0
                    AddLevel = 1, // vanilla 0
                }
            ],
        }
    ];
}
