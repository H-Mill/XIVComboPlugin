using System;

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
