using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("ItemRecipe")]
    public class ItemRecipe : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("targetItem")]
        [RealType("TweakDBID")]
        public TweakDbId TargetItem { get; set; }
        
        [RealName("isHidden")]
        [RealType("Bool")]
        public bool IsHidden { get; set; }
        
        [RealName("amount")]
        [RealType("Int32")]
        public int Amount { get; set; }
    }
}
