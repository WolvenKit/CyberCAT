using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SBraindanceInputMask")]
    public class SBraindanceInputMask : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("pauseAction")]
        public bool PauseAction { get; set; }
        
        [RealName("playForwardAction")]
        public bool PlayForwardAction { get; set; }
        
        [RealName("playBackwardAction")]
        public bool PlayBackwardAction { get; set; }
        
        [RealName("restartAction")]
        public bool RestartAction { get; set; }
        
        [RealName("switchLayerAction")]
        public bool SwitchLayerAction { get; set; }
        
        [RealName("cameraToggleAction")]
        public bool CameraToggleAction { get; set; }
    }
}
