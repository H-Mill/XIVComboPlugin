using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Melee
{
    [Flags]
    public enum VPRCombos : long
    {
        None = 0,

        [CustomComboInfo("Death Rattle Finisher", "Replace Steel Fangs/Dread Fangs with Death Rattle when available", 41)]
        ViperDeathRattleCombo = 1L << 1,

        [CustomComboInfo("Last Lash Finisher", "Replace Steel Maw/Dread Maw with Last Lash when available", 41)]
        ViperLastLashCombo = 1L << 2,

        [CustomComboInfo("Generational Legacy", "Legacy moves replace Generation moves when usable", 41)]
        ViperLegacyCombo = 1L << 3,
    }
}
