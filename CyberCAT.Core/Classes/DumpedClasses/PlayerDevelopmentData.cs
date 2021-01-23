using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("PlayerDevelopmentData")]
    public class PlayerDevelopmentData : IScriptable
    {
        [RealName("ownerID")]
        public EntEntityID OwnerID { get; set; }
        
        [RealName("queuedCombatExp")]
        public SExperiencePoints[] QueuedCombatExp { get; set; }
        
        [RealName("proficiencies")]
        public SProficiency[] Proficiencies { get; set; }
        
        [RealName("attributes")]
        public SAttribute[] Attributes { get; set; }
        
        [RealName("perkAreas")]
        public SPerkArea[] PerkAreas { get; set; }
        
        [RealName("traits")]
        public STrait[] Traits { get; set; }
        
        [RealName("devPoints")]
        public SDevelopmentPoints[] DevPoints { get; set; }
        
        [RealName("skillPrereqs")]
        public Handle<SkillCheckPrereqState>[] SkillPrereqs { get; set; }
        
        [RealName("statPrereqs")]
        public Handle<StatCheckPrereqState>[] StatPrereqs { get; set; }
        
        [RealName("knownRecipes")]
        public ItemRecipe[] KnownRecipes { get; set; }
        
        [RealName("highestCompletedMinigameLevel")]
        public int HighestCompletedMinigameLevel { get; set; }
        
        [RealName("startingLevel")]
        public int StartingLevel { get; set; }
        
        [RealName("startingExperience")]
        public int StartingExperience { get; set; }
        
        [RealName("lifePath")]
        public DumpedEnums.gamedataLifePath? LifePath { get; set; }
        
        [RealName("displayActivityLog")]
        public bool DisplayActivityLog { get; set; }
    }
}
