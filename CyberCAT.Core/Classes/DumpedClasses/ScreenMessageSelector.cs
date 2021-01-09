using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ScreenMessageSelector")]
    public class ScreenMessageSelector : InkTweakDBIDSelector
    {
        [RealName("replaceTextWithCustomNumber")]
        [RealType("Bool")]
        public bool ReplaceTextWithCustomNumber { get; set; }
        
        [RealName("customNumber")]
        [RealType("Int32")]
        public int CustomNumber { get; set; }
    }
}
