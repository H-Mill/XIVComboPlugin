using System;
using System.Collections.Generic;
using Dalamud.Configuration;
using XIVCombo.Configuration.Healers;
using XIVCombo.Configuration.Melee;
using XIVCombo.Configuration.Ranged;
using XIVCombo.Configuration.Tanks;

namespace XIVComboPlugin
{
    [Serializable]
    public class XIVComboConfiguration : IPluginConfiguration
    {
        //Healers
        public ASTCombos ASTCombos { get; set; }
        public SCHCombos SCHCombos { get; set; }
        public WHMCombos WHMCombos { get; set; }

        //Melee
        public DRGCombos DRGCombos { get; set; }
        public MNKCombos MNKCombos { get; set; }
        public NINCombos NINCombos { get; set; }
        public RPRCombos RPRCombos { get; set; }
        public SAMCombos SAMCombos { get; set; }
        public VPRCombos VPRCombos { get; set; }

        //Ranged
        public BLMCombos BLMCombos { get; set; }
        public BRDCombos BRDCombos { get; set; }
        public DNCCombos DNCCombos { get; set; }
        public MCHCombos MCHCombos { get; set; }
        public PCTCombos PCTCombos { get; set; }
        public RDMCombos RDMCombos { get; set; }
        public SMNCombos SMNCombos { get; set; }

        //Tanks
        public DRKCombos DRKCombos { get; set; }
        public GNBCombos GNBCombos { get; set; }
        public PLDCombos PLDCombos { get; set; }
        public WARCombos WARCombos { get; set; }

        public int Version { get; set; }

        public List<bool> HiddenActions;

    }
}
