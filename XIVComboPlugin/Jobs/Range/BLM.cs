using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Range
{
    public static class BLM
    {
        public const uint
            Blizzard4 = 3576,
            Fire4 = 3577,
            Transpose = 149,
            UmbralSoul = 16506,
            LeyLines = 3573,
            BTL = 7419,
            Flare = 162,
            Freeze = 159;

        public const ushort
            BuffLeyLines = 737;

        [Flags]
        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("Enochian Stance Switcher", "Change Fire 4, Blizzard 4, Flare, and Freeze to the appropriate element depending on stance", 25)]
            BlackEnochianFeature = 1L << 1,
        }
    }
}
