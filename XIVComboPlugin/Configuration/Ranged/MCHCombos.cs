using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Ranged
{
    [Flags]
    public enum MCHCombos : long
    {
        None = 0,

        [CustomComboInfo("(Heated) Shot Combo", "Replace either form of Clean Shot with its combo chain", 31)]
        MachinistMainCombo = 1L << 1,

        [CustomComboInfo("Spread Shot Heat", "Replace Spread Shot or Scattergun with Auto Crossbow when overheated", 31)]
        MachinistSpreadShotFeature = 1L << 2,

        [CustomComboInfo("Heat Blast when overheated", "Replace Hypercharge with Heat Blast when overheated", 31)]
        MachinistOverheatFeature = 1L << 3,
    }
}
