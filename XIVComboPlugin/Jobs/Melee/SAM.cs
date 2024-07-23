using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Melee
{
    public static class SAM
    {
        public const uint
            Yukikaze = 7480,
            Hakaze = 7477,
            Gekko = 7481,
            Jinpu = 7478,
            Kasha = 7482,
            Shifu = 7479,
            Mangetsu = 7484,
            Fuga = 7483,
            Oka = 7485,
            ThirdEye = 7498,
            Iaijutsu = 7867,
            Tsubame = 16483,
            OgiNamikiri = 25781,
            Ikishoten = 16482,
            KaeshiNamikiri = 25782,
            Fuko = 25780,
            Gyofu = 36963;

        public const ushort
            BuffOgiNamikiriReady = 2959,
            BuffMeikyoShisui = 1233;

        [Flags]
        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("Yukikaze Combo", "Replace Yukikaze with its combo chain", 34)]
            SamuraiYukikazeCombo = 1L << 1,

            [CustomComboInfo("Gekko Combo", "Replace Gekko with its combo chain", 34)]
            SamuraiGekkoCombo = 1L << 2,

            [CustomComboInfo("Kasha Combo", "Replace Kasha with its combo chain", 34)]
            SamuraiKashaCombo = 1L << 3,

            [CustomComboInfo("Mangetsu Combo", "Replace Mangetsu with its combo chain", 34)]
            SamuraiMangetsuCombo = 1L << 4,

            [CustomComboInfo("Oka Combo", "Replace Oka with its combo chain", 34)]
            SamuraiOkaCombo = 1L << 5,

            [CustomComboInfo("Iaijutsu into Tsubame", "Replace Iaijutsu with Tsubame after using an Iaijutsu", 34)]
            SamuraiTsubameCombo = 1L << 6,
        }
    }
}
