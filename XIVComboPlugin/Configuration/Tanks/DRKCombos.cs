using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Tanks
{
    [Flags]
    public enum DRKCombos : long
    {
        None = 0,
        [CustomComboInfo("Souleater Combo", "Replace Souleater with its combo chain", 32)]
        DarkSouleaterCombo = 1L << 1,

        [CustomComboInfo("Stalwart Soul Combo", "Replace Stalwart Soul with its combo chain", 32)]
        DarkStalwartSoulCombo = 1L << 2,
    }
}
