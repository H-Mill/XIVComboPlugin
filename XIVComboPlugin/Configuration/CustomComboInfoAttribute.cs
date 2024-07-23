using System;
using XIVCombo.Configuration.Healers;
using XIVCombo.Configuration.Melee;
using XIVCombo.Configuration.Ranged;
using XIVCombo.Configuration.Tanks;

namespace XIVComboPlugin
{
    public class CustomComboInfoAttribute : Attribute
    {
        internal CustomComboInfoAttribute(string fancyName, string description, byte classJob)
        {
            FancyName = fancyName;
            Description = description;
            ClassJob = classJob;
        }

        public string FancyName { get; }
        public string Description { get; }
        public byte ClassJob { get; }

    }
}
