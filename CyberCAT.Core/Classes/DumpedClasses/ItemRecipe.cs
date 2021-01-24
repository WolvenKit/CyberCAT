using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ItemRecipe")]
    public class ItemRecipe : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("targetItem")]
        public TweakDbId TargetItem { get; set; }
        
        [RealName("isHidden")]
        public bool IsHidden { get; set; }
        
        [RealName("amount")]
        public int Amount { get; set; }
    }
}
