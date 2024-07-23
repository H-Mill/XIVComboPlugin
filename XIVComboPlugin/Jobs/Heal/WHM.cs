using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Heal
{
    public static class WHM
    {
        public const uint
            Solace = 16531,
            Rapture = 16534,
            Misery = 16535;

        [Flags]
        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("Solace into Misery", "Replaces Afflatus Solace with Afflatus Misery when Misery is ready to be used", 24)]
            WhiteMageSolaceMiseryFeature = 1L << 1,

            [CustomComboInfo("Rapture into Misery", "Replaces Afflatus Rapture with Afflatus Misery when Misery is ready to be used", 24)]
            WhiteMageRaptureMiseryFeature = 1L << 2,
        }
    }
}
