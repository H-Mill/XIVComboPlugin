using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Melee
{
    [Flags]
    public enum MNKCombos : long
    {
        None = 0,

        [CustomComboInfo("Monk Fury Combo", "Replaces Bootshine, True Strike, and Snap Punch when no Fury charges are available", 20)]
        MonkFuryCombo = 1L << 1,

        [CustomComboInfo("Perfect Balance on Masterful Blitz", "Replaces Masterful Blitz with Perfect Balance when no Blitz moves are available", 20)]
        MonkPerfectBlitz = 1L << 2,
    }
}
