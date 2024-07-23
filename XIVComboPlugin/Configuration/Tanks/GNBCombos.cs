using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Tanks
{
    [Flags]
    public enum GNBCombos : long
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
