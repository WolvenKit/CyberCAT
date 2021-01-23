using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("GenericDeviceControllerPS")]
    public class GenericDeviceControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isRecognizableBySenses")]
        public bool IsRecognizableBySenses { get; set; }
        
        [RealName("genericDeviceActionsSetup")]
        public GenericDeviceActionsData GenericDeviceActionsSetup { get; set; }
        
        [RealName("genericDeviceSkillChecks")]
        public Handle<GenericContainer> GenericDeviceSkillChecks { get; set; }
        
        [RealName("deviceWidgetRecord")]
        public TweakDbId DeviceWidgetRecord { get; set; }
        
        [RealName("thumbnailWidgetRecord")]
        public TweakDbId ThumbnailWidgetRecord { get; set; }
        
        [RealName("performedCustomActionsIDs")]
        public CName[] PerformedCustomActionsIDs { get; set; }

        public GenericDeviceControllerPS()
        {
            AutoToggleQuestMark = true;
        }
    }
}
