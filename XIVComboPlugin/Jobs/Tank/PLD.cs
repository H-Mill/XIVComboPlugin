using System;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Tank
{
    public static class PLD
    {
        public const uint
            GoringBlade = 3538,
            FastBlade = 9,
            RiotBlade = 15,
            RoyalAuthority = 3539,
            RageOfHalone = 21,
            Prominence = 16457,
            TotalEclipse = 7381,
            Requiescat = 7383,
            Confiteor = 16459,
            Imperator = 36921,
            BladeOfFaith = 25748,
            BladeOfTruth = 25749,
            BladeOfValor = 25750;

        public const ushort
            BuffRequiescat = 1368,
            BuffBladeOfFaithReady = 3019;

        [Flags]
        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("Royal Authority Combo", "Replace Royal Authority/Rage of Halone with its combo chain", 19)]
            PaladinRoyalAuthorityCombo = 1L << 1,

            [CustomComboInfo("Prominence Combo", "Replace Prominence with its combo chain", 19)]
            PaladinProminenceCombo = 1L << 2,

            [CustomComboInfo("Requiescat/Imperator Confiteor", "Replace Requiescat/Imperator with Confiteor while under the effect of Requiescat", 19)]
            PaladinRequiescatCombo = 1L << 3,
        }
    }
}
