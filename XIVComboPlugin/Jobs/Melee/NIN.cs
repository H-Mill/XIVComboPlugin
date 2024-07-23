using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Melee
{
    public static class NIN
    {
        public const uint
            ArmorCrush = 3563,
            SpinningEdge = 2240,
            GustSlash = 2242,
            AeolianEdge = 2255,
            HakkeM = 16488,
            DeathBlossom = 2254,
            DWAD = 3566,
            Assassinate = 2246,
            Bunshin = 16493,
            PhantomK = 25774;

        public const ushort
            BuffPhantomKReady = 2723;

        [Flags]
        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("Armor Crush Combo", "Replace Armor Crush with its combo chain", 30)]
            NinjaArmorCrushCombo = 1L << 1,

            [CustomComboInfo("Aeolian Edge Combo", "Replace Aeolian Edge with its combo chain", 30)]
            NinjaAeolianEdgeCombo = 1L << 2,

            [CustomComboInfo("Hakke Mujinsatsu Combo", "Replace Hakke Mujinsatsu with its combo chain", 30)]
            NinjaHakkeMujinsatsuCombo = 1L << 3,
        }
    }
}
