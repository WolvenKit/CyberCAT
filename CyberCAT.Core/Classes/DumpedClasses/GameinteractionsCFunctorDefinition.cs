using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameinteractionsCFunctorDefinition")]
    public class GameinteractionsCFunctorDefinition : GameinteractionsIFunctorDefinition
    {
        [RealName("predicate")]
        public GameinteractionsCPredicateDefinition Predicate { get; set; }
        
        [RealName("unaryOperator")]
        public DumpedEnums.gameinteractionsEUnaryOperator? UnaryOperator { get; set; }
    }
}
