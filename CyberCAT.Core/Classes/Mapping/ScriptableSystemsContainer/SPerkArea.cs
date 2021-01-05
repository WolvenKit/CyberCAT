using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("SPerkArea")]
    public class SPerkArea : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("type")]
        public DumpedEnums.gamedataPerkArea? Type { get; set; }
        
        [RealName("unlocked")]
        [RealType("Bool")]
        public bool Unlocked { get; set; }
        
        [RealName("boughtPerks")]
        public SPerk[] BoughtPerks { get; set; }
    }
}
