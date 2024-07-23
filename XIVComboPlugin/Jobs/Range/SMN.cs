using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Range
{
    public static class SMN
    {
        public const uint
            Deathflare = 3582,
            EnkindlePhoenix = 16516,
            EnkindleBahamut = 7429,
            DWT = 3581,
            SummonBahamut = 7427,
            FBTLow = 16513,
            FBTHigh = 16549,
            Ruin1 = 163,
            Ruin3 = 3579,
            BrandOfPurgatory = 16515,
            FountainOfFire = 16514,
            Fester = 181,
            Necrotize = 36990,
            EnergyDrain = 16508,
            Painflare = 3578,
            EnergySyphon = 16510,
            LuxSolaris = 36997,
            SummonSolarBahamut = 36992;
        public static class Buffs
        {
            public const ushort
                RefulgentLux = 3874;
        }

        [Flags]
        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("ED Fester/Necrotize", "Change Fester/Necrotize into Energy Drain when out of Aetherflow stacks", 27)]
            SummonerEDFesterCombo = 1L << 1,

            [CustomComboInfo("ES Painflare", "Change Painflare into Energy Syphon when out of Aetherflow stacks", 27)]
            SummonerESPainflareCombo = 1L << 2,

            [CustomComboInfo("Solar Bahamut Lux", "Change Summon Solar Bahamut into Lux Solaris after summoning", 27)]
            SummonerSolarBahamutLuxSolaris = 1L << 3,
        }
    }
}
