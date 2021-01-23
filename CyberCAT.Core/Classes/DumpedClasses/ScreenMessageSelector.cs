using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ScreenMessageSelector")]
    public class ScreenMessageSelector : InkTweakDBIDSelector
    {
        [RealName("replaceTextWithCustomNumber")]
        public bool ReplaceTextWithCustomNumber { get; set; }
        
        [RealName("customNumber")]
        public int CustomNumber { get; set; }
    }
}
