using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gameinteractionsChoiceMetaData")]
    public class GameinteractionsChoiceMetaData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("tweakDBName")]
        [RealType("String")]
        public string TweakDBName { get; set; }
        
        [RealName("tweakDBID")]
        [RealType("TweakDBID")]
        public ulong TweakDBID { get; set; }
        
        [RealName("type")]
        public GameinteractionsChoiceTypeWrapper Type { get; set; }
    }
}
