using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Range
{
    public static class BRD
    {
        public const uint
            WanderersMinuet = 3559,
            PitchPerfect = 7404,
            HeavyShot = 97,
            BurstShot = 16495,
            StraightShot = 98,
            RefulgentArrow = 7409,
            QuickNock = 106,
            WideVolley = 36974,
            Ladonsbite = 25783,
            Shadowbite = 16494;

        public const ushort
            BuffBarrage = 128,
            BuffHawksEye = 3861;

        [Flags]
        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("Heavy Shot into Straight Shot", "Replaces Heavy Shot/Burst Shot with Straight Shot/Refulgent Arrow when procced", 23)]
            BardStraightShotUpgradeFeature = 1L << 1,

            [CustomComboInfo("Quick Nock into Shadowbite", "Replaces Quick Nock/Ladonsbite with Wide Volley/Shadowbite when procced", 23)]
            BardAoEUpgradeFeature = 1L << 2,
        }
    }
}
