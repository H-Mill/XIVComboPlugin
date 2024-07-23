using System;
using XIVCombo.Jobs;
using XIVComboPlugin;

namespace XIVCombo.Jobs.Heal
{
    public class AST : IJob
    {
        uint IJob.JobId => 33;
        string IJob.FriendlyName => "Astrologian";

        public const uint
            Play1 = 37019,
            Play2 = 37020,
            Play3 = 37021,
            AstralDraw = 37017,
            UmbralDraw = 37018,
            Balance = 4401,
            Bole = 4404,
            Arrow = 4402,
            Spear = 4403,
            Ewer = 4405,
            Spire = 4406,
            MinorArcana = 7443,
            CrownPlay = 25869;

        public const ushort
            BuffLordOfCrownsDrawn = 2054,
            BuffLadyOfCrownsDrawn = 2055;

        [Flags]
        public enum Combos : long
        {
            None = 0,

            [CustomComboInfo("Astral/Umbral Draw on Play 1/2/3", "Play actions turn into Draw actions after playing a card, while keeping the the usual Play behavior", 33)]
            AstrologianCardsOnDrawFeature = 1L << 1,
        }
    }
}
