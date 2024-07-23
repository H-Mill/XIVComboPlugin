using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Range
{
    public static class MCH
    {
        public const uint
            CleanShot = 2873,
            HeatedCleanShot = 7413,
            SplitShot = 2866,
            HeatedSplitShot = 7411,
            SlugShot = 2868,
            HeatedSlugshot = 7412,
            Hypercharge = 17209,
            HeatBlast = 7410,
            BlazingShot = 36978,
            SpreadShot = 2870,
            AutoCrossbow = 16497,
            Scattergun = 25786;

        [Flags]
        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("(Heated) Shot Combo", "Replace either form of Clean Shot with its combo chain", 31)]
            MachinistMainCombo = 1L << 1,

            [CustomComboInfo("Spread Shot Heat", "Replace Spread Shot or Scattergun with Auto Crossbow when overheated", 31)]
            MachinistSpreadShotFeature = 1L << 2,

            [CustomComboInfo("Heat Blast when overheated", "Replace Hypercharge with Heat Blast when overheated", 31)]
            MachinistOverheatFeature = 1L << 3,
        }
    }
}
