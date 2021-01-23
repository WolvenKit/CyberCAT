using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("LcdScreenControllerPS")]
    public class LcdScreenControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("messageRecordID")]
        public TweakDbId MessageRecordID { get; set; }
        
        [RealName("replaceTextWithCustomNumber")]
        public bool ReplaceTextWithCustomNumber { get; set; }
        
        [RealName("customNumber")]
        public int CustomNumber { get; set; }
        
        [RealName("messageRecordSelector")]
        public Handle<ScreenMessageSelector> MessageRecordSelector { get; set; }
    }
}
