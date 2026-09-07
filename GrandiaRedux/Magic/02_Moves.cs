using Grandia.Sdk;

namespace GrandiaRedux.Magic;

/// <summary>
/// Values that differ between HD Remaster <c>FIELD/WINDT.BIN</c> sec7/sec8
/// and Redux 0.4.9. Unlisted fields stay vanilla.
/// </summary>
internal static class Moves
{
    internal static readonly MagicEdit[] All =
    [
        new()
        {
            Id = Skill.VSlash,
            Note = "V-Slash",
            IpKnockback = 4000, // vanilla 3500
        },
        new()
        {
            Id = Skill.WBreak,
            Note = "W-Break",
            Power = 300, // vanilla 260
            Cost = 28, // vanilla 20
            Speed = 40, // vanilla 60
            IpKnockback = 3000, // vanilla 7500
            CancelChance = 50, // vanilla 75
        },
        new()
        {
            Id = Skill.Shockwave,
            Note = "Shockwave",
            Power = 140, // vanilla 200
            Cost = 22, // vanilla 30
            Speed = 50, // vanilla 90
            IpKnockback = 0, // vanilla 3000
            CancelChance = 5, // vanilla 10
        },
        new()
        {
            Id = Skill.MidairCut,
            Note = "Midair Cut",
            Power = 315, // vanilla 350
            Cost = 40, // vanilla 32
            Exp = 20, // vanilla 30
            CancelChance = 50, // vanilla 100
        },
        new()
        {
            Id = Skill.ImmortalAura,
            Note = "Immortal Aura",
            Cost = 80, // vanilla 45
            Exp = 20, // vanilla 10
        },
        new()
        {
            Id = Skill.IceSlash,
            Note = "Ice Slash",
            Power = 370, // vanilla 400
            Cost = 45, // vanilla 36
            Speed = 60, // vanilla 120
            IpKnockback = 3500, // vanilla 8500
            Exp = 20, // vanilla 50
            CancelChance = 40, // vanilla 60
        },
        new()
        {
            Id = Skill.LotusCut,
            Note = "Lotus Cut",
            Cost = 40, // vanilla 32
            Speed = 60, // vanilla 120
            IpKnockback = 3500, // vanilla 8500
            Exp = 20, // vanilla 40
            CancelChance = 40, // vanilla 60
        },
        new()
        {
            Id = Skill.ThorCut,
            Note = "Thor Cut",
            Power = 390, // vanilla 450
            Cost = 50, // vanilla 40
            Speed = 60, // vanilla 120
            Exp = 20, // vanilla 50
            CancelChance = 40, // vanilla 80
        },
        new()
        {
            Id = (Skill)58,
            Note = "Skill 58",
            Power = 200, // vanilla 250
            Speed = 80, // vanilla 120
            IpKnockback = 0, // vanilla 5000
            Exp = 8, // vanilla 20
            CancelChance = 20, // vanilla 50
        },
        new()
        {
            Id = Skill.HeavenAndEarth,
            Note = "Heaven and Earth",
            Power = 335, // vanilla 500
            Cost = 140, // vanilla 90
            IpKnockback = 0, // vanilla 9999
            Exp = 10, // vanilla 20
            CancelChance = 50, // vanilla 100
            Requirements =
            [
                new(LearnKind.Sword, 38),
                new(LearnKind.Mace, 35),
                new(LearnKind.Ax, 36),
            ],
        },
        new()
        {
            Id = Skill.KnifeHurl,
            Note = "Knife Hurl",
            Power = 300, // vanilla 200
            CancelChance = 75, // vanilla 50
        },
        new()
        {
            Id = Skill.RandomHurl,
            Note = "Random Hurl",
            Power = 200, // vanilla 180
            Cost = 22, // vanilla 28
            Speed = 60, // vanilla 90
            IpKnockback = 0, // vanilla 2500
            CancelChance = 20, // vanilla 10
        },
        new()
        {
            Id = Skill.ParalyzeWhip,
            Note = "Paralyze Whip",
            Power = 340, // vanilla 150
            Cost = 20, // vanilla 15
        },
        new()
        {
            Id = Skill.FireWhip,
            Note = "Fire Whip",
            Power = 255, // vanilla 200
            Speed = 50, // vanilla 75
            IpKnockback = 0, // vanilla 3000
            Exp = 12, // vanilla 30
            Requirements =
            [
                new(LearnKind.Whip, 10),
                new(LearnKind.Fire, 8),
            ],
        },
        new()
        {
            Id = Skill.ZapWhip,
            Note = "Zap! Whip",
            Power = 550, // vanilla 450
            Speed = 60, // vanilla 120
            IpKnockback = 4500, // vanilla 9000
            Exp = 20, // vanilla 50
            Requirements =
            [
                new(LearnKind.Whip, 15),
                new(LearnKind.Fire, 12),
                new(LearnKind.Wind, 12),
            ],
        },
        new()
        {
            Id = Skill.FireAway,
            Note = "Fire Away",
            Power = 145, // vanilla 180
            Cost = 26, // vanilla 28
            Speed = 70, // vanilla 90
            IpKnockback = 0, // vanilla 2500
            CancelChance = 5, // vanilla 10
            Requirements =
            [
                new(LearnKind.Bow, 8),
            ],
        },
        new()
        {
            Id = Skill.RoundWhacker,
            Note = "Round Whacker",
            Power = 150, // vanilla 200
            Cost = 22, // vanilla 30
            Speed = 60, // vanilla 75
            IpKnockback = 0, // vanilla 3000
        },
        new()
        {
            Id = Skill.PuffyFire,
            Note = "Puffy Fire",
            Power = 180, // vanilla 250
            Cost = 30, // vanilla 36
            Speed = 65, // vanilla 75
            IpKnockback = 0, // vanilla 3500
            Exp = 12, // vanilla 20
            CancelChance = 15, // vanilla 30
            Requirements =
            [
                new(LearnKind.Bow, 12),
                new(LearnKind.Fire, 6),
            ],
        },
        new()
        {
            Id = Skill.Yawn,
            Note = "Yawn",
            Power = 4, // vanilla 3
            Cost = 8, // vanilla 5
            Speed = 45, // vanilla 60
            Exp = 16, // vanilla 20
            Requirements =
            [
                new(LearnKind.Mace, 10),
                new(LearnKind.Water, 4),
                new(LearnKind.Earth, 6),
            ],
        },
        new()
        {
            Id = Skill.PuffyKick,
            Note = "Puffy Kick",
            Power = 170, // vanilla 200
            CancelChance = 75, // vanilla 10
        },
        new()
        {
            Id = (Skill)70,
            Note = "Skill 70",
            Cost = 16, // vanilla 18
            Exp = 5, // vanilla 3
        },
        new()
        {
            Id = (Skill)71,
            Note = "Skill 71",
            Power = 2, // vanilla 1
            Cost = 24, // vanilla 16
            Exp = 4, // vanilla 8
            Requirements =
            [
                new(LearnKind.Mace, 8),
                new(LearnKind.Earth, 5),
                new(LearnKind.Fire, 5),
            ],
        },
        new()
        {
            Id = Skill.EruptionCut,
            Note = "Eruption Cut",
            Power = 260, // vanilla 200
            IpKnockback = 4000, // vanilla 3000
            Exp = 20, // vanilla 30
            CancelChance = 50, // vanilla 100
        },
        new()
        {
            Id = Skill.FlyingDragonCut,
            Note = "Flying Dragon Cut",
            Power = 150, // vanilla 160
            Cost = 20, // vanilla 14
            IpKnockback = 1000, // vanilla 3500
            Exp = 18, // vanilla 10
            Radius = 20, // vanilla 15
            CancelChance = 10, // vanilla 30
        },
        new()
        {
            Id = Skill.DragonCut,
            Note = "Dragon Cut",
            Power = 230, // vanilla 250
            IpKnockback = 0, // vanilla 5000
            Exp = 8, // vanilla 20
            CancelChance = 20, // vanilla 50
        },
        new()
        {
            Id = Skill.MistHide,
            Note = "Mist Hide",
            Exp = 8, // vanilla 5
        },
        new()
        {
            Id = Skill.Doppelganger,
            Note = "Doppelganger",
            Power = 460, // vanilla 300
            Cost = 70, // vanilla 27
            Speed = 140, // vanilla 90
        },
        new()
        {
            Id = Skill.Dethsword,
            Note = "Dethsword",
            Power = 510, // vanilla 100
            Cost = 100, // vanilla 25
            Speed = 140, // vanilla 60
            Effect = EffectType.Damage, // vanilla EffectType.ProbDamage
            Requirements =
            [
                new(LearnKind.Dagger, 33),
            ],
        },
        new()
        {
            Id = Skill.Missile,
            Note = "Missile",
            IpKnockback = 3000, // vanilla 3500
        },
        new()
        {
            Id = Skill.Fireball,
            Note = "Fireball",
            Power = 200, // vanilla 250
            IpKnockback = 0, // vanilla 3500
            Exp = 10, // vanilla 20
            CancelChance = 20, // vanilla 30
        },
        new()
        {
            Id = Skill.Sidethrow,
            Note = "Sidethrow",
            Power = 140, // vanilla 200
            Cost = 28, // vanilla 40
            Speed = 50, // vanilla 120
            IpKnockback = 0, // vanilla 5000
            CancelChance = 0, // vanilla 50
        },
        new()
        {
            Id = Skill.Discutter,
            Note = "Discutter",
            Power = 195, // vanilla 180
            Cost = 34, // vanilla 30
            Speed = 40, // vanilla 90
            IpKnockback = 1000, // vanilla 3500
            Exp = 14, // vanilla 10
            CancelChance = 50, // vanilla 25
        },
        new()
        {
            Id = Skill.DemonBall,
            Note = "Demon Ball",
            Power = 340, // vanilla 400
            Cost = 45, // vanilla 40
            IpKnockback = 6000, // vanilla 7500
            Exp = 12, // vanilla 50
            CancelChance = 65, // vanilla 100
        },
        new()
        {
            Id = Skill.NeoDemonBall,
            Note = "Neo Demon Ball",
            Power = 325, // vanilla 450
            Cost = 130, // vanilla 85
            IpKnockback = 0, // vanilla 9000
            Exp = 8, // vanilla 20
            CancelChance = 50, // vanilla 100
            Requirements =
            [
                new(LearnKind.Dagger, 29),
                new(LearnKind.Sword, 28),
                new(LearnKind.Bow, 37),
            ],
        },
        new()
        {
            Id = (Skill)84,
            Note = "Skill 84",
            Power = 155, // vanilla 200
            Cost = 35, // vanilla 40
            Speed = 70, // vanilla 120
            IpKnockback = 0, // vanilla 5000
        },
        new()
        {
            Id = (Skill)87,
            Note = "Skill 87",
            IpKnockback = 3500, // vanilla 4000
        },
        new()
        {
            Id = Skill.MogayShot,
            Note = "Mogay Shot",
            Power = 360, // vanilla 250
            Cost = 18, // vanilla 14
            IpKnockback = 3500, // vanilla 2500
        },
        new()
        {
            Id = Skill.MogayBomb,
            Note = "Mogay Bomb",
            Power = 180, // vanilla 150
            Cost = 32, // vanilla 38
            Speed = 60, // vanilla 90
            IpKnockback = 0, // vanilla 9999
        },
        new()
        {
            Id = Skill.MogayHypo,
            Note = "Mogay Hypo",
            Power = 50, // vanilla 45
            Cost = 15, // vanilla 45
        },
        new()
        {
            Id = Skill.PowerUp,
            Note = "Power Up",
            Power = 2, // vanilla 1
            Cost = 30, // vanilla 20
            Speed = 40, // vanilla 60
        },
        new()
        {
            Id = Skill.MogayPickpocket,
            Note = "Mogay Pickpocket",
            Power = 75, // vanilla 50
            Cost = 5, // vanilla 10
        },
        new()
        {
            Id = Skill.Redshock,
            Note = "Redshock",
            Power = 680, // vanilla 400
            IpKnockback = 5000, // vanilla 7000
            Exp = 40, // vanilla 30
        },
        new()
        {
            Id = Skill.EnchantmentDance,
            Note = "Enchantment Dance",
            Power = 30, // vanilla 4
            Cost = 42, // vanilla 34
            Speed = 30, // vanilla 90
            Exp = 35, // vanilla 20
            Requirements =
            [
                new(LearnKind.Mace, 12),
            ],
        },
        new()
        {
            Id = Skill.Protect,
            Note = "Protect",
            Cost = 50, // vanilla 21
            Requirements =
            [
                new(LearnKind.Wind, 28),
                new(LearnKind.Water, 30),
            ],
        },
        new()
        {
            Id = Skill.Diggin,
            Note = "Diggin'",
            Cost = 15, // vanilla 1
            Exp = 18, // vanilla 7
            Radius = 20, // vanilla 15
        },
        new()
        {
            Id = (Skill)116,
            Note = "Skill 116",
            Cost = 10, // vanilla 0
        }
    ];
}
