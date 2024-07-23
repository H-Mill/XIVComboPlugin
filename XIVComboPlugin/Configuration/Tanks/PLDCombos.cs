using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Tanks
{
    [Flags]
    public enum PLDCombos : long
    {
        None = 0,

        [CustomComboInfo("Royal Authority Combo", "Replace Royal Authority/Rage of Halone with its combo chain", 19)]
        PaladinRoyalAuthorityCombo = 1L << 1,

        [CustomComboInfo("Prominence Combo", "Replace Prominence with its combo chain", 19)]
        PaladinProminenceCombo = 1L << 2,

        [CustomComboInfo("Requiescat/Imperator Confiteor", "Replace Requiescat/Imperator with Confiteor while under the effect of Requiescat", 19)]
        PaladinRequiescatCombo = 1L << 3,
    }
}
