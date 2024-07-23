using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Range
{
    public static class DNC
    {
        public const uint
            Bladeshower = 15994,
            Bloodshower = 15996,
            Windmill = 15993,
            RisingWindmill = 15995,
            StandardStep = 15997,
            FanDance1 = 16007,
            FanDance2 = 16008,
            FanDance3 = 16009,
            FanDance4 = 25791,
            Flourish = 16013,
            Devilment = 16011,
            StarfallDance = 25792,
            LastDance = 36983;

        public const ushort
            BuffFlourishingSymmetry = 3017,
            BuffFlourishingFlow = 3018,
            BuffThreefoldFanDance = 1820,
            BuffFourfoldFanDance = 2699,
            BuffStarfallDanceReady = 2700,
            BuffSilkenSymmetry = 2693,
            BuffSilkenFlow = 2694,
            BuffLastDance = 3867;

        [Flags]
        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("AoE GCD procs", "DNC AoE procs turn into their normal abilities when not procced", 38)]
            DancerAoeGcdFeature = 1L << 1,

            [CustomComboInfo("Fan Dance Combos", "Change Fan Dance and Fan Dance 2 into Fan Dance 3 while flourishing", 38)]
            DancerFanDanceCombo = 1L << 2,

            [CustomComboInfo("Fan Dance IV", "Change Flourish into Fan Dance IV while flourishing", 38)]
            DancerFanDance4Combo = 1L << 3,

            [CustomComboInfo("Devilment into Starfall", "Change Devilment into Starfall Dance while under the effect of Flourishing Starfall", 38)]
            DancerDevilmentCombo = 1L << 4,

            [CustomComboInfo("Standard Last Dance", "Change Standard Step into Last Dance when ready", 38)]
            DancerLastDanceCombo = 1L << 5,
        }
    }
}
