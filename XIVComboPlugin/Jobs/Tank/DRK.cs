using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Tank
{
    public static class DRK
    {
        public const uint
            Souleater = 3632,
            HardSlash = 3617,
            SyphonStrike = 3623,
            StalwartSoul = 16468,
            Unleash = 3621;

        [Flags]
        public enum Combos : long
        {
            None = 0,
            [CustomComboInfo("Souleater Combo", "Replace Souleater with its combo chain", 32)]
            DarkSouleaterCombo = 1L << 1,

            [CustomComboInfo("Stalwart Soul Combo", "Replace Stalwart Soul with its combo chain", 32)]
            DarkStalwartSoulCombo = 1L << 2,
        }
    }
}
