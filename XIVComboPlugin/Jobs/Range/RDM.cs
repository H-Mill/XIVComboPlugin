using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Range
{
    public static class RDM
    {
        public const uint
            Veraero2 = 16525,
            Verthunder2 = 16524,
            Impact = 16526,
            Redoublement = 7516,
            ERedoublement = 7529,
            Zwerchhau = 7512,
            EZwerchhau = 7528,
            Riposte = 7504,
            ERiposte = 7527,
            Scatter = 7509,
            Verstone = 7511,
            Verfire = 7510,
            Jolt = 7503,
            Jolt2 = 7524,
            Jolt3 = 37004,
            Verholy = 7526,
            Verflare = 7525,
            Scorch = 16530,
            Resolution = 25858;

        public const ushort
            BuffSwiftcast = 167,
            BuffDualcast = 1249,
            BuffAcceleration = 1238,
            BuffChainspell = 2560,
            BuffVerstoneReady = 1235,
            BuffVerfireReady = 1234,
            BuffGrandImpactReady = 3877,
            BuffMagickedSwordplay = 3875;

        [Flags]
        public enum Combos : long
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
}
