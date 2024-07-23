using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Ranged
{
    [Flags]
    public enum PCTCombos : long
    {
        None = 0,

        [CustomComboInfo("Additive to Subtractive Combo", "Replace Additive combo with Subtractive combo when Subtractive Pallet is active", 42)]
        PictoSubtractivePallet = 1L << 1,

        [CustomComboInfo("Motifs and Muses", "Replace Motifs with their relevant Muses", 42)]
        PictoMotifMuseFeature = 1L << 2,

        [CustomComboInfo("Landscape and Steel follow-ups", "Additionally replace Landscape Motif with Star Prism and Weapon Motif with Hammer Stamp when appropriate", 42)]
        PictoMuseCombo = 1L << 3,

        [CustomComboInfo("Holy White to Comet Black", "Replace Holy in White with Comet in Black when Monochrome Tones is active", 42)]
        PictoHolyWhiteCombo = 1L << 4,
    }
}
