using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("LcdScreenControllerPS")]
    public class LcdScreenControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("messageRecordID")]
        [RealType("TweakDBID")]
        public TweakDbId MessageRecordID { get; set; }
        
        [RealName("replaceTextWithCustomNumber")]
        [RealType("Bool")]
        public bool ReplaceTextWithCustomNumber { get; set; }
        
        [RealName("customNumber")]
        [RealType("Int32")]
        public int CustomNumber { get; set; }
        
        [RealName("messageRecordSelector")]
        public Handle<ScreenMessageSelector> MessageRecordSelector { get; set; }
    }
}
