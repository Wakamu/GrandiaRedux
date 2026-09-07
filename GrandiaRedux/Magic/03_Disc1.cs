using Grandia.Sdk;

namespace GrandiaRedux.Magic;

/// <summary>
/// Disc 1 damage-spell stats. 0.4.9 <c>WINDT.BIN</c> is the disc 2 table;
/// these scale that power by the unofficial 3.0 disc1/disc2 ratio
/// (https://unofficialgrandiaredux.blogspot.com/2022/04/grandia-redux-30-skills.html).
/// Applied when event flag 289 is clear.
/// </summary>
internal static class Disc1
{
    internal static readonly MagicEdit[] All =
    [
        new() { Id = Skill.Tremor, Note = "Tremor", Power = 102 }, // disc2 150; 3.0 75→110
        new() { Id = Skill.Quake, Note = "Quake", Power = 245 }, // disc2 290; 3.0 215→255
        new() { Id = Skill.Burn, Note = "Burn!", Power = 53 }, // disc2 80; 3.0 40→60
        new() { Id = Skill.Burnflame, Note = "Burnflame", Power = 102 }, // disc2 150; 3.0 75→110
        new() { Id = Skill.Burnstrike, Note = "Burnstrike", Power = 259 }, // disc2 365; 3.0 220→310
        new() { Id = Skill.Burnflare, Note = "Burnflare", Power = 176 }, // disc2 230; 3.0 130→170
        new() { Id = Skill.Fireburner, Note = "Fireburner", Power = 450 }, // disc2 570; 3.0 450→570
        new() { Id = Skill.Howl, Note = "Howl", Power = 62 }, // disc2 90; 3.0 45→65
        new() { Id = Skill.Howlslash, Note = "Howlslash", Power = 111 }, // disc2 160; 3.0 80→115
        new() { Id = Skill.Howlnado, Note = "Howlnado", Power = 233 }, // disc2 280; 3.0 200→240
        new() { Id = Skill.Boom, Note = "BOOM!", Power = 148 }, // disc2 175; 3.0 110→130
        new() { Id = Skill.MeteorStrike, Note = "Meteor Strike", Power = 453 }, // disc2 515; 3.0 440→500
        new() { Id = Skill.BoomPow, Note = "BOOM-POW!", Power = 189 }, // disc2 240; 3.0 165→210
        new() { Id = Skill.BaBoom, Note = "BA-BOOM!", Power = 287 }, // disc2 340; 3.0 270→320
        new() { Id = Skill.Crackle, Note = "Crackle", Power = 178 }, // disc2 235; 3.0 140→185
        new() { Id = Skill.Crackling, Note = "Crackling", Power = 203 }, // disc2 260; 3.0 180→230
        new() { Id = Skill.Zap, Note = "Zap!", Power = 164 }, // disc2 190; 3.0 125→145
        new() { Id = Skill.GadZap, Note = "GadZap", Power = 565 }, // disc2 700; 3.0 565→700
        new() { Id = Skill.ZapAll, Note = "Zap All", Power = 210 }, // disc2 260; 3.0 190→235
        new() { Id = Skill.DragonZap, Note = "DragonZap", Power = 299 }, // disc2 350; 3.0 290→340
        new() { Id = Skill.Diggin, Note = "Diggin'", Cost = 5 }, // disc2 15; 3.0 5→15
    ];
}
