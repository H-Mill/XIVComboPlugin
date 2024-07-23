using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Healers
{
    [Flags]
    public enum WHMCombos : long
    {
        None = 0,

        [CustomComboInfo("Solace into Misery", "Replaces Afflatus Solace with Afflatus Misery when Misery is ready to be used", 24)]
        WhiteMageSolaceMiseryFeature = 1L << 1,

        [CustomComboInfo("Rapture into Misery", "Replaces Afflatus Rapture with Afflatus Misery when Misery is ready to be used", 24)]
        WhiteMageRaptureMiseryFeature = 1L << 2,
    }
}
