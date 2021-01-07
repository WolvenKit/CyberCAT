using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("GenericDeviceControllerPS")]
    public class GenericDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isRecognizableBySenses")]
        [RealType("Bool")]
        public bool IsRecognizableBySenses { get; set; }
        
        [RealName("genericDeviceActionsSetup")]
        public GenericDeviceActionsData GenericDeviceActionsSetup { get; set; }
        
        [RealName("genericDeviceSkillChecks")]
        public Handle<GenericContainer> GenericDeviceSkillChecks { get; set; }
        
        [RealName("deviceWidgetRecord")]
        [RealType("TweakDBID")]
        public TweakDbId DeviceWidgetRecord { get; set; }
        
        [RealName("thumbnailWidgetRecord")]
        [RealType("TweakDBID")]
        public TweakDbId ThumbnailWidgetRecord { get; set; }
        
        [RealName("performedCustomActionsIDs")]
        [RealType("CName")]
        public string[] PerformedCustomActionsIDs { get; set; }

        public GenericDeviceControllerPS()
        {
            AutoToggleQuestMark = true;
        }
    }
}
