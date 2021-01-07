using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameUILocalizationDataPackage")]
    public class GameUILocalizationDataPackage : IScriptable
    {
        [RealName("floatValues")]
        [RealType("Float")]
        public float[] FloatValues { get; set; }
        
        [RealName("intValues")]
        [RealType("Int32")]
        public int[] IntValues { get; set; }
        
        [RealName("nameValues")]
        [RealType("CName")]
        public string[] NameValues { get; set; }
        
        [RealName("statValues")]
        [RealType("Float")]
        public float[] StatValues { get; set; }
        
        [RealName("statNames")]
        [RealType("CName")]
        public string[] StatNames { get; set; }
        
        [RealName("paramsCount")]
        [RealType("Int32")]
        public int ParamsCount { get; set; }
        
        [RealName("textParams")]
        public Handle<TextTextParameterSet> TextParams { get; set; }
    }
}
