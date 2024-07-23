using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Ranged
{
    [Flags]
    public enum BRDCombos : long
    {
        None = 0,

        [CustomComboInfo("Heavy Shot into Straight Shot", "Replaces Heavy Shot/Burst Shot with Straight Shot/Refulgent Arrow when procced", 23)]
        BardStraightShotUpgradeFeature = 1L << 1,

        [CustomComboInfo("Quick Nock into Shadowbite", "Replaces Quick Nock/Ladonsbite with Wide Volley/Shadowbite when procced", 23)]
        BardAoEUpgradeFeature = 1L << 2,
    }
}
