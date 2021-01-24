using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameUILocalizationDataPackage")]
    public class GameUILocalizationDataPackage : IScriptable
    {
        [RealName("floatValues")]
        public float[] FloatValues { get; set; }
        
        [RealName("intValues")]
        public int[] IntValues { get; set; }
        
        [RealName("nameValues")]
        public CName[] NameValues { get; set; }
        
        [RealName("statValues")]
        public float[] StatValues { get; set; }
        
        [RealName("statNames")]
        public CName[] StatNames { get; set; }
        
        [RealName("paramsCount")]
        public int ParamsCount { get; set; }
        
        [RealName("textParams")]
        public Handle<TextTextParameterSet> TextParams { get; set; }
    }
}
