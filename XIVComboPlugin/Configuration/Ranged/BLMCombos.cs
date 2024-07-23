using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Ranged
{
    [Flags]
    public enum BLMCombos : long
    {
        None = 0,

        [CustomComboInfo("Enochian Stance Switcher", "Change Fire 4, Blizzard 4, Flare, and Freeze to the appropriate element depending on stance", 25)]
        BlackEnochianFeature = 1L << 1,
    }
}
