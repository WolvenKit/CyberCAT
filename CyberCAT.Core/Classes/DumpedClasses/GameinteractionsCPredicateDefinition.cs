using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsCPredicateDefinition")]
    public class GameinteractionsCPredicateDefinition : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("predicateType")]
        public Handle<GameinteractionsIPredicateType> PredicateType { get; set; }
        
        [RealName("binaryOperator")]
        public DumpedEnums.gameinteractionsEBinaryOperator? BinaryOperator { get; set; }
        
        [RealName("functor1DataDefinition")]
        public Handle<GameinteractionsCFunctorDefinition> Functor1DataDefinition { get; set; }
        
        [RealName("functor2DataDefinition")]
        public Handle<GameinteractionsCFunctorDefinition> Functor2DataDefinition { get; set; }
    }
}
