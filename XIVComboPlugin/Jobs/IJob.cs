using System;

namespace XIVCombo.Jobs
{
    public interface IJob
    {
        public uint JobId { get; }
        public string FriendlyName { get; }
        public class AbilityIds;
        public class Buffs;
        public class Debuffs;
        public class Levels;
        
        [Flags]
        public enum Combos;
    }
}
