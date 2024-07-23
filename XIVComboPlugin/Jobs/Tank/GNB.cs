using XIVComboPlugin;

namespace XIVCombo.Jobs.Tank
{
    public static class GNB
    {
        public const uint
            SolidBarrel = 16145,
            KeenEdge = 16137,
            BrutalShell = 16139,
            WickedTalon = 16150,
            GnashingFang = 16146,
            SavageClaw = 16147,
            DemonSlaughter = 16149,
            DemonSlice = 16141,
            Continuation = 16155,
            JugularRip = 16156,
            AbdomenTear = 16157,
            EyeGouge = 16158,
            BurstStrike = 16162,
            Hypervelocity = 25759,
            FatedCircle = 16163,
            FatedBrand = 36936;
        public const ushort
            BuffReadyToRip = 1842,
            BuffReadyToTear = 1843,
            BuffReadyToGouge = 1844,
            BuffReadyToBlast = 2686,
            BuffReadyToRaze = 3839;
        public const byte
            LevelContinuation = 70,
            LevelEnhancedContinuation = 86,
            LevelEnhancedContinuation2 = 96;

        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("Solid Barrel Combo", "Replace Solid Barrel with its combo chain", 37)]
            GunbreakerSolidBarrelCombo = 1L << 1,

            [CustomComboInfo("Gnashing Fang Continuation", "Put Continuation moves on Gnashing Fang when appropriate", 37)]
            GunbreakerGnashingFangCont = 1L << 2,

            [CustomComboInfo("Burst Strike Continuation", "Put Continuation moves on Burst Strike when appropriate", 37)]
            GunbreakerBurstStrikeCont = 1L << 3,

            [CustomComboInfo("Demon Slaughter Combo", "Replace Demon Slaughter with its combo chain", 37)]
            GunbreakerDemonSlaughterCombo = 1L << 4,

            [CustomComboInfo("Fated Circle Continuation", "Put Continuation moves on Fated Circle when appropriate", 37)]
            GunbreakerFatedCircleCont = 1L << 5,
        }
    }
}
