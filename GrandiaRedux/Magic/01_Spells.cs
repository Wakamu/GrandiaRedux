using Grandia.Sdk;

namespace GrandiaRedux.Magic;

/// <summary>
/// Values that differ between HD Remaster <c>FIELD/WINDT.BIN</c> sec7/sec8
/// and Redux 0.4.9. Unlisted fields stay vanilla.
/// </summary>
internal static class Spells
{
    internal static readonly MagicEdit[] All =
    [
        new()
        {
            Id = Skill.DefLoss,
            Note = "Def-Loss",
            Power = -5, // vanilla -1
            Cost = 6, // vanilla 3
            Speed = 25, // vanilla 30
            CharacterMask = 0x1D, // vanilla 0x1C
            Requirements =
            [
                new(LearnKind.Earth, 4),
            ],
        },
        new()
        {
            Id = Skill.Tremor,
            Note = "Tremor",
            Power = 150, // vanilla 70
            Cost = 7, // vanilla 3
            Speed = 50, // vanilla 60
            IpKnockback = 800, // vanilla 1500
            Exp = 12, // vanilla 10
        },
        new()
        {
            Id = Skill.Gravity,
            Note = "Gravity",
            Power = 14, // vanilla -7
            Speed = 15, // vanilla 75
            CharacterMask = 0x9A, // vanilla 0x98
            Effect = EffectType.Status, // vanilla EffectType.PowerUpDown
            Requirements =
            [
                new(LearnKind.Earth, 8),
            ],
        },
        new()
        {
            Id = Skill.Quake,
            Note = "Quake",
            Power = 290, // vanilla 250
            Cost = 16, // vanilla 12
            Speed = 75, // vanilla 120
            IpKnockback = 400, // vanilla 2000
            CancelChance = 14, // vanilla 35
        },
        new()
        {
            Id = Skill.Heal,
            Note = "Heal",
            Power = 50, // vanilla 30
            Cost = 4, // vanilla 1
            Speed = 60, // vanilla 30
            Exp = 15, // vanilla 8
            CharacterMask = 0x87, // vanilla 0x97
        },
        new()
        {
            Id = Skill.Alheal,
            Note = "Alheal",
            Power = 30, // vanilla 40
            Cost = 6, // vanilla 4
            Exp = 7, // vanilla 5
            CharacterMask = 0x03, // vanilla 0x07
            Requirements =
            [
                new(LearnKind.Water, 3),
            ],
        },
        new()
        {
            Id = Skill.Snooze,
            Note = "Snooze",
            Cost = 8, // vanilla 2
            CharacterMask = 0x03, // vanilla 0x17
            Requirements =
            [
                new(LearnKind.Water, 7),
            ],
        },
        new()
        {
            Id = Skill.Healer,
            Note = "Healer",
            Power = 110, // vanilla 80
            Cost = 7, // vanilla 3
            Speed = 60, // vanilla 75
            Exp = 15, // vanilla 8
            CharacterMask = 0x07, // vanilla 0x13
        },
        new()
        {
            Id = Skill.Alhealer,
            Note = "Alhealer",
            Power = 60, // vanilla 80
            Cost = 13, // vanilla 8
            Speed = 80, // vanilla 105
            Exp = 7, // vanilla 5
            CharacterMask = 0x83, // vanilla 0x82
            Requirements =
            [
                new(LearnKind.Water, 10),
            ],
        },
        new()
        {
            Id = Skill.AlhealerPlus,
            Note = "Alhealer+",
            Power = 120, // vanilla 150
            Cost = 13, // vanilla 12
            Speed = 80, // vanilla 135
            Exp = 7, // vanilla 5
            CharacterMask = 0x03, // vanilla 0x97
            Requirements =
            [
                new(LearnKind.Water, 18),
            ],
        },
        new()
        {
            Id = Skill.Resurrect,
            Note = "Resurrect",
            Cost = 10, // vanilla 6
            Speed = 50, // vanilla 105
            Requirements =
            [
                new(LearnKind.Water, 14),
            ],
        },
        new()
        {
            Id = Skill.Burn,
            Note = "Burn!",
            Power = 80, // vanilla 40
            Cost = 2, // vanilla 1
            IpKnockback = 1200, // vanilla 1000
            Exp = 12, // vanilla 10
            Radius = 20, // vanilla 15
            CancelChance = 60, // vanilla 15
        },
        new()
        {
            Id = Skill.Burnflame,
            Note = "Burnflame",
            Power = 150, // vanilla 80
            Cost = 8, // vanilla 4
            Speed = 55, // vanilla 45
            IpKnockback = 0, // vanilla 1000
            CancelChance = 16, // vanilla 20
        },
        new()
        {
            Id = Skill.Burnstrike,
            Note = "Burnstrike",
            Power = 365, // vanilla 200
            Cost = 6, // vanilla 5
            Speed = 30, // vanilla 60
            IpKnockback = 8000, // vanilla 2000
            Exp = 22, // vanilla 20
            CancelChance = 55, // vanilla 30
            Requirements =
            [
                new(LearnKind.Fire, 8),
            ],
        },
        new()
        {
            Id = Skill.Burnflare,
            Note = "Burnflare",
            Power = 230, // vanilla 150
            Cost = 9, // vanilla 7
            IpKnockback = 0, // vanilla 1500
            Exp = 8, // vanilla 10
            CancelChance = 0, // vanilla 30
            Requirements =
            [
                new(LearnKind.Fire, 10),
            ],
        },
        new()
        {
            Id = Skill.Fireburner,
            Note = "Fireburner",
            Power = 570, // vanilla 300
            Cost = 13, // vanilla 8
            Speed = 60, // vanilla 105
            IpKnockback = 4000, // vanilla 3000
            CancelChance = 20, // vanilla 50
            Requirements =
            [
                new(LearnKind.Fire, 16),
            ],
        },
        new()
        {
            Id = Skill.Howl,
            Note = "Howl",
            Power = 90, // vanilla 40
            Cost = 3, // vanilla 2
            Speed = 35, // vanilla 45
            IpKnockback = 1000, // vanilla 2000
            Exp = 14, // vanilla 10
            CancelChance = 50, // vanilla 15
        },
        new()
        {
            Id = Skill.Runner,
            Note = "Runner",
            Power = 100, // vanilla 2
            Cost = 16, // vanilla 1
            Speed = 50, // vanilla 15
            Exp = 12, // vanilla 8
            Effect = EffectType.Special, // vanilla EffectType.PowerUpDown
            Mode = 7, // vanilla 3
            Requirements =
            [
                new(LearnKind.Wind, 9),
            ],
        },
        new()
        {
            Id = Skill.Howlslash,
            Note = "Howlslash",
            Power = 160, // vanilla 80
            Cost = 10, // vanilla 6
            Speed = 65, // vanilla 75
            IpKnockback = 0, // vanilla 2000
            Exp = 12, // vanilla 10
            CancelChance = 18, // vanilla 20
            CharacterMask = 0x85, // vanilla 0x87
            Requirements =
            [
                new(LearnKind.Wind, 5),
            ],
        },
        new()
        {
            Id = Skill.Shhh,
            Note = "Shhh!",
            Power = 6, // vanilla 4
            Speed = 30, // vanilla 60
            Exp = 24, // vanilla 20
            Requirements =
            [
                new(LearnKind.Wind, 3),
            ],
        },
        new()
        {
            Id = Skill.Howlnado,
            Note = "Howlnado",
            Power = 280, // vanilla 250
            Cost = 14, // vanilla 8
            Speed = 60, // vanilla 120
            IpKnockback = 0, // vanilla 3000
            CancelChance = 0, // vanilla 35
            Requirements =
            [
                new(LearnKind.Wind, 21),
            ],
        },
        new()
        {
            Id = Skill.Poizn,
            Note = "Poizn",
            Power = 9, // vanilla 2
            Cost = 5, // vanilla 2
            IpKnockback = 500, // vanilla 1000
            Exp = 20, // vanilla 10
            CharacterMask = 0x94, // vanilla 0x90
            Requirements =
            [
                new(LearnKind.Water, 5),
                new(LearnKind.Earth, 5),
            ],
        },
        new()
        {
            Id = Skill.Cure,
            Note = "Cure",
            Speed = 10, // vanilla 30
            Exp = 20, // vanilla 10
            CharacterMask = 0x16, // vanilla 0x07
            Requirements =
            [
                new(LearnKind.Water, 2),
                new(LearnKind.Earth, 2),
            ],
        },
        new()
        {
            Id = Skill.Stram,
            Note = "Stram",
            Cost = 10, // vanilla 3
            Exp = 24, // vanilla 20
            CharacterMask = 0x91, // vanilla 0x90
            Requirements =
            [
                new(LearnKind.Water, 8),
                new(LearnKind.Earth, 6),
            ],
        },
        new()
        {
            Id = Skill.Craze,
            Note = "Craze",
            Power = 9, // vanilla 3
            Cost = 2, // vanilla 1
            Speed = 15, // vanilla 30
            IpKnockback = 0, // vanilla 500
            Exp = 24, // vanilla 20
            CharacterMask = 0x94, // vanilla 0x90
            Requirements =
            [
                new(LearnKind.Water, 5),
                new(LearnKind.Earth, 7),
            ],
        },
        new()
        {
            Id = (Skill)27,
            Note = "Skill 27",
            Cost = 5, // vanilla 3
            Speed = 40, // vanilla 60
            Exp = 20, // vanilla 10
            CharacterMask = 0x16, // vanilla 0x06
            Mode = 8, // vanilla 6
            Requirements =
            [
                new(LearnKind.Water, 7),
                new(LearnKind.Earth, 9),
            ],
        },
        new()
        {
            Id = (Skill)28,
            Note = "Skill 28",
            Cost = 12, // vanilla 4
            Exp = 20, // vanilla 10
        },
        new()
        {
            Id = Skill.Halvah,
            Note = "Halvah",
            Power = 2, // vanilla 7
            Cost = 26, // vanilla 5
            Speed = 60, // vanilla 120
            Exp = 20, // vanilla 10
            CharacterMask = 0x16, // vanilla 0x17
            Effect = EffectType.PowerUpDown, // vanilla EffectType.ClearStatus
            Mode = 5, // vanilla 8
            Requirements =
            [
                new(LearnKind.Water, 26),
                new(LearnKind.Earth, 28),
            ],
        },
        new()
        {
            Id = Skill.Boom,
            Note = "BOOM!",
            Power = 175, // vanilla 120
            Cost = 14, // vanilla 7
            IpKnockback = 0, // vanilla 3000
            Exp = 16, // vanilla 10
            CancelChance = 40, // vanilla 35
            CharacterMask = 0x9D, // vanilla 0x8D
            Requirements =
            [
                new(LearnKind.Earth, 8),
                new(LearnKind.Fire, 6),
            ],
        },
        new()
        {
            Id = Skill.Wow,
            Note = "WOW!",
            Power = 2, // vanilla 1
            Cost = 4, // vanilla 3
            Speed = 10, // vanilla 30
            Exp = 20, // vanilla 10
            Requirements =
            [
                new(LearnKind.Earth, 2),
                new(LearnKind.Fire, 4),
            ],
        },
        new()
        {
            Id = Skill.MeteorStrike,
            Note = "Meteor Strike",
            Power = 515, // vanilla 450
            Cost = 20, // vanilla 10
            IpKnockback = 4500, // vanilla 5000
            CancelChance = 40, // vanilla 80
        },
        new()
        {
            Id = Skill.BoomPow,
            Note = "BOOM-POW!",
            Power = 240, // vanilla 220
            Cost = 19, // vanilla 10
            IpKnockback = 0, // vanilla 3500
            Exp = 14, // vanilla 10
            CancelChance = 16, // vanilla 40
            Requirements =
            [
                new(LearnKind.Earth, 10),
                new(LearnKind.Fire, 12),
            ],
        },
        new()
        {
            Id = Skill.BaBoom,
            Note = "BA-BOOM!",
            Power = 340, // vanilla 400
            Cost = 25, // vanilla 18
            IpKnockback = 0, // vanilla 4000
            Exp = 12, // vanilla 10
            CancelChance = 0, // vanilla 50
            CharacterMask = 0x9C, // vanilla 0x9F
            Requirements =
            [
                new(LearnKind.Earth, 25),
                new(LearnKind.Fire, 23),
            ],
        },
        new()
        {
            Id = Skill.Crackle,
            Note = "Crackle",
            Power = 235, // vanilla 120
            Cost = 7, // vanilla 2
            Exp = 26, // vanilla 20
            CancelChance = 52, // vanilla 30
            CharacterMask = 0x03, // vanilla 0x07
            Requirements =
            [
                new(LearnKind.Wind, 4),
                new(LearnKind.Water, 2),
            ],
        },
        new()
        {
            Id = Skill.Freeze,
            Note = "Freeze!",
            Power = 135, // vanilla -2
            Cost = 11, // vanilla 3
            Speed = 50, // vanilla 60
            IpKnockback = 0, // vanilla 1000
            Exp = 14, // vanilla 10
            CharacterMask = 0x84, // vanilla 0x81
            Effect = EffectType.Damage, // vanilla EffectType.PowerUpDown
            Mode = 1, // vanilla 3
            Requirements =
            [
                new(LearnKind.Wind, 4),
                new(LearnKind.Water, 6),
            ],
        },
        new()
        {
            Id = Skill.Cold,
            Note = "Cold",
            Cost = 9, // vanilla 3
            Exp = 22, // vanilla 20
            CharacterMask = 0x94, // vanilla 0x81
            Requirements =
            [
                new(LearnKind.Wind, 8),
                new(LearnKind.Water, 10),
            ],
        },
        new()
        {
            Id = Skill.Fiora,
            Note = "Fiora",
            Power = 6, // vanilla 4
            Cost = 3, // vanilla 2
            Exp = 22, // vanilla 20
            CharacterMask = 0x12, // vanilla 0x16
            Requirements =
            [
                new(LearnKind.Wind, 7),
                new(LearnKind.Water, 5),
            ],
        },
        new()
        {
            Id = Skill.Crackling,
            Note = "Crackling",
            Power = 260, // vanilla 220
            Cost = 21, // vanilla 14
            Speed = 95, // vanilla 120
            IpKnockback = 0, // vanilla 5000
            Exp = 14, // vanilla 10
            CancelChance = 16, // vanilla 35
            CharacterMask = 0x83, // vanilla 0x97
            Requirements =
            [
                new(LearnKind.Wind, 12),
                new(LearnKind.Water, 12),
            ],
        },
        new()
        {
            Id = Skill.Zap,
            Note = "Zap!",
            Power = 190, // vanilla 180
            Cost = 18, // vanilla 11
            IpKnockback = 0, // vanilla 2500
            Exp = 16, // vanilla 10
            CancelChance = 34, // vanilla 35
            Requirements =
            [
                new(LearnKind.Fire, 6),
                new(LearnKind.Wind, 8),
            ],
        },
        new()
        {
            Id = Skill.GadZap,
            Note = "GadZap",
            Power = 700, // vanilla 550
            Cost = 20, // vanilla 13
            Speed = 80, // vanilla 120
            IpKnockback = 3500, // vanilla 7000
            Exp = 26, // vanilla 30
            CancelChance = 40, // vanilla 100
            Requirements =
            [
                new(LearnKind.Fire, 22),
                new(LearnKind.Wind, 22),
            ],
        },
        new()
        {
            Id = Skill.ZapAll,
            Note = "Zap All",
            Power = 260, // vanilla 280
            Cost = 23, // vanilla 13
            IpKnockback = 0, // vanilla 3000
            Exp = 14, // vanilla 10
            CancelChance = 14, // vanilla 40
            CharacterMask = 0x91, // vanilla 0x95
            Requirements =
            [
                new(LearnKind.Fire, 14),
                new(LearnKind.Wind, 12),
            ],
        },
        new()
        {
            Id = Skill.DragonZap,
            Note = "DragonZap",
            Power = 350, // vanilla 450
            Cost = 27, // vanilla 20
            IpKnockback = 0, // vanilla 4000
            Exp = 12, // vanilla 10
            CancelChance = 0, // vanilla 60
            CharacterMask = 0x83, // vanilla 0x93
            Requirements =
            [
                new(LearnKind.Fire, 27),
                new(LearnKind.Wind, 25),
            ],
        },
        new()
        {
            Id = Skill.MagicArt,
            Note = "Magic Art",
            Power = 580, // vanilla 400
            Cost = 33, // vanilla 11
            Exp = 24, // vanilla 20
            CancelChance = 45, // vanilla 50
        },
        new()
        {
            Id = Skill.StarSymphony,
            Note = "Star Symphony",
            Power = 2, // vanilla 1
            Speed = 60, // vanilla 90
            Exp = 8, // vanilla 5
            Mode = 4, // vanilla 5
        },
        new()
        {
            Id = (Skill)46,
            Note = "Skill 46",
            Power = 14, // vanilla 450
            Cost = 30, // vanilla 26
            Speed = 90, // vanilla 120
            Exp = 10, // vanilla 18
            Radius = 30, // vanilla 0
            Effect = EffectType.Status, // vanilla EffectType.Special
            Mode = 3, // vanilla 8
            Requirements =
            [
                new(LearnKind.Fire, 27),
                new(LearnKind.Wind, 29),
            ],
        },
        new()
        {
            Id = (Skill)47,
            Note = "Skill 47",
            Cost = 90, // vanilla 25
            Speed = 200, // vanilla 90
            Requirements =
            [
                new(LearnKind.Wind, 31),
                new(LearnKind.Water, 33),
            ],
        },
        new()
        {
            Id = (Skill)48,
            Note = "Skill 48",
            Cost = 42, // vanilla 28
            Speed = 120, // vanilla 90
            Requirements =
            [
                new(LearnKind.Water, 24),
                new(LearnKind.Earth, 22),
            ],
        },
        new()
        {
            Id = (Skill)49,
            Note = "Skill 49",
            Cost = 40, // vanilla 33
            Speed = 140, // vanilla 120
            IpKnockback = 0, // vanilla 9999
            Exp = 8, // vanilla 10
            CancelChance = 0, // vanilla 100
            Requirements =
            [
                new(LearnKind.Fire, 30),
            ],
        }
    ];
}
