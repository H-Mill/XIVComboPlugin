using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Healers
{
    [Flags]
    public enum SCHCombos : long
    {
        None = 0,

        [CustomComboInfo("ED Aetherflow", "Change Energy Drain into Aetherflow when you have no more Aetherflow stacks", 28)]
        ScholarEnergyDrainFeature = 1L << 1,
    }
}
