using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SBraindanceInputMask")]
    public class SBraindanceInputMask : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("pauseAction")]
        [RealType("Bool")]
        public bool PauseAction { get; set; }
        
        [RealName("playForwardAction")]
        [RealType("Bool")]
        public bool PlayForwardAction { get; set; }
        
        [RealName("playBackwardAction")]
        [RealType("Bool")]
        public bool PlayBackwardAction { get; set; }
        
        [RealName("restartAction")]
        [RealType("Bool")]
        public bool RestartAction { get; set; }
        
        [RealName("switchLayerAction")]
        [RealType("Bool")]
        public bool SwitchLayerAction { get; set; }
        
        [RealName("cameraToggleAction")]
        [RealType("Bool")]
        public bool CameraToggleAction { get; set; }
    }
}
