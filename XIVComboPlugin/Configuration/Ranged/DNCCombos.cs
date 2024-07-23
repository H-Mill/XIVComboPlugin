using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Ranged
{
    [Flags]
    public enum DNCCombos : long
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
