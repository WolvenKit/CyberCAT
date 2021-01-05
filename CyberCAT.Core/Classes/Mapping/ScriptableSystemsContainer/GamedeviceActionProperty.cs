
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("gamedeviceActionProperty")]
    public class GamedeviceActionProperty : IScriptable
    {
        [RealName("name")]
        [RealType("CName")]
        public string Name { get; set; }
        
        [RealName("typeName")]
        [RealType("CName")]
        public string TypeName { get; set; }
        
        [RealName("first")]
        [RealType("Variant")]
        public dynamic First { get; set; }
        
        [RealName("second")]
        [RealType("Variant")]
        public dynamic Second { get; set; }
        
        [RealName("third")]
        [RealType("Variant")]
        public dynamic Third { get; set; }
        
        [RealName("flags")]
        public DumpedEnums.gamedeviceActionPropertyFlags? Flags { get; set; }
    }
}
