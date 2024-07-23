using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Tank
{
    public static class WAR
    {
        public const uint
            StormsPath = 42,
            HeavySwing = 31,
            Maim = 37,
            StormsEye = 45,
            MythrilTempest = 16462,
            Overpower = 41,
            InnerRelease = 7389,
            PrimalRend = 25753,
            Berserk = 38;

        public const ushort
            BuffPrimalRendReady = 2624;

        [Flags]
        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("Storms Path Combo", "Replace Storms Path with its combo chain", 21)]
            WarriorStormsPathCombo = 1L << 1,

            [CustomComboInfo("Storms Eye Combo", "Replace Storms Eye with its combo chain", 21)]
            WarriorStormsEyeCombo = 1L << 2,

            [CustomComboInfo("Mythril Tempest Combo", "Replace Mythril Tempest with its combo chain", 21)]
            WarriorMythrilTempestCombo = 1L << 3,
        }
    }
}
