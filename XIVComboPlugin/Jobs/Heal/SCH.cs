using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Heal
{
    public static class SCH
    {
        public const uint
            FeyBless = 16543,
            Consolation = 16546,
            EnergyDrain = 167,
            Aetherflow = 166;

        [Flags]
        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("ED Aetherflow", "Change Energy Drain into Aetherflow when you have no more Aetherflow stacks", 28)]
            ScholarEnergyDrainFeature = 1L << 1,
        }
    }
}
