using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Melee
{
    public static class MNK
    {
        public const uint
            Bootshine = 53,
            TrueStrike = 54,
            SnapPunch = 56,
            DragonKick = 74,
            TwinSnakes = 61,
            Demolish = 66,
            LeapingOpo = 36945,
            RisingRaptor = 36946,
            PouncingCoeurl = 36947,
            PerfectBalance = 69,
            MasterfulBlitz = 25764;

        [Flags]
        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("Monk Fury Combo", "Replaces Bootshine, True Strike, and Snap Punch when no Fury charges are available", 20)]
            MonkFuryCombo = 1L << 1,

            [CustomComboInfo("Perfect Balance on Masterful Blitz", "Replaces Masterful Blitz with Perfect Balance when no Blitz moves are available", 20)]
            MonkPerfectBlitz = 1L << 2,
        }
    }
}
