using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ComputerQuickHackData")]
    public class ComputerQuickHackData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("alternativeName")]
        [RealType("TweakDBID")]
        public TweakDbId AlternativeName { get; set; }
        
        [RealName("factName")]
        [RealType("CName")]
        public string FactName { get; set; }
        
        [RealName("factValue")]
        [RealType("Int32")]
        public int FactValue { get; set; }
        
        [RealName("operationType")]
        public DumpedEnums.EMathOperationType? OperationType { get; set; }
    }
}
