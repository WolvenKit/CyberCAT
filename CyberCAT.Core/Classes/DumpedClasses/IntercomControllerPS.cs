using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("IntercomControllerPS")]
    public class IntercomControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isCalling")]
        [RealType("Bool")]
        public bool IsCalling { get; set; }
        
        [RealName("sceneStarted")]
        [RealType("Bool")]
        public bool SceneStarted { get; set; }
        
        [RealName("endingCall")]
        [RealType("Bool")]
        public bool EndingCall { get; set; }
        
        [RealName("forceLookAt")]
        public EntEntityID ForceLookAt { get; set; }
        
        [RealName("forceFollow")]
        [RealType("Bool")]
        public bool ForceFollow { get; set; }
    }
}
