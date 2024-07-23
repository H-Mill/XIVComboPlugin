using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Ranged
{
    [Flags]
    public enum SMNCombos : long
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
