using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Melee
{
    [Flags]
    public enum DRGCombos : long
    {
        None = 0,
        [CustomComboInfo("Coerthan Torment Combo", "Replace Coerthan Torment with its combo chain", 22)]
        DragoonCoerthanTormentCombo = 1L << 1,

        [CustomComboInfo("Chaos Thrust Combo", "Replace Chaos Thrust with its combo chain", 22)]
        DragoonChaosThrustCombo = 1L << 2,

        [CustomComboInfo("Full Thrust Combo", "Replace Full Thrust with its combo chain", 22)]
        DragoonFullThrustCombo = 1L << 3,
    }
}
