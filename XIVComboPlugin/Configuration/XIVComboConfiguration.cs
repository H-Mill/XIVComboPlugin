using System;
using System.Collections.Generic;
using Dalamud.Configuration;
using XIVCombo.Jobs.Heal;
using XIVCombo.Jobs.Melee;
using XIVCombo.Jobs.Range;
using XIVCombo.Jobs.Tank;

namespace XIVComboPlugin
{
    [Serializable]
    public class XIVComboConfiguration : IPluginConfiguration
    {
        //Healers
        public AST.Combos ASTCombos { get; set; }
        public SCH.Combos SCHCombos { get; set; }
        public WHM.Combos WHMCombos { get; set; }
        
        //Melee
        public DRG.Combos DRGCombos { get; set; }
        public MNK.Combos MNKCombos { get; set; }
        public NIN.Combos NINCombos { get; set; }
        public RPR.Combos RPRCombos { get; set; }
        public SAM.Combos SAMCombos { get; set; }
        public VPR.Combos VPRCombos { get; set; }

        //Ranged
        public BLM.Combos BLMCombos { get; set; }
        public BRD.Combos BRDCombos { get; set; }
        public DNC.Combos DNCCombos { get; set; }
        public MCH.Combos MCHCombos { get; set; }
        public PCT.Combos PCTCombos { get; set; }
        public RDM.Combos RDMCombos { get; set; }
        public SMN.Combos SMNCombos { get; set; }

        //Tanks
        public DRK.Combos DRKCombos { get; set; }
        public GNB.Combos GNBCombos { get; set; }
        public PLD.Combos PLDCombos { get; set; }
        public WAR.Combos WARCombos { get; set; }

        public int Version { get; set; }

        public List<bool> HiddenActions;

    }
}
