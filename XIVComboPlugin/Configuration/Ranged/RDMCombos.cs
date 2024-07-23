using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Ranged
{
    [Flags]
    public enum RDMCombos : long
    {
        None = 0,

        [CustomComboInfo("Red Mage AoE Combo", "Replaces Veraero/thunder 2 with Impact when Dualcast or Swiftcast are active", 35)]
        RedMageAoECombo = 1L << 1,

        [CustomComboInfo("Redoublement combo", "Replaces Redoublement with its combo chain, following enchantment rules", 35)]
        RedMageMeleeCombo = 1L << 2,

        [CustomComboInfo("Verproc into Jolt", "Replaces Verstone/Verfire with Jolt/Scorch when no proc is available", 35)]
        RedMageVerprocCombo = 1L << 3,
    }
}
