using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Melee
{
    [Flags]
    public enum RPRCombos : long
    {
        None = 0,

        [CustomComboInfo("Slice Combo", "Replace Slice with its combo chain", 39)]
        ReaperSliceCombo = 1L << 1,

        [CustomComboInfo("Scythe Combo", "Replace Spinning Scythe with its combo chain", 39)]
        ReaperScytheCombo = 1L << 2,

        [CustomComboInfo("Double Regress", "Regress always replaces both Hell's Egress and Hell's Ingress", 39)]
        ReaperRegressFeature = 1L << 3,

        [CustomComboInfo("Enshroud Combo", "Replace Enshroud with Communio while you are Enshrouded", 39)]
        ReaperEnshroudCombo = 1L << 4,

        [CustomComboInfo("Arcane Circle Combo", "Replace Arcane Circle with Plentiful Harvest while you have Immortal Sacrifice", 39)]
        ReaperArcaneFeature = 1L << 5,
    }
}
