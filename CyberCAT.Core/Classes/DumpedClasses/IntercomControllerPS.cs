using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("IntercomControllerPS")]
    public class IntercomControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("isCalling")]
        public bool IsCalling { get; set; }
        
        [RealName("sceneStarted")]
        public bool SceneStarted { get; set; }
        
        [RealName("endingCall")]
        public bool EndingCall { get; set; }
        
        [RealName("forceLookAt")]
        public EntEntityID ForceLookAt { get; set; }
        
        [RealName("forceFollow")]
        public bool ForceFollow { get; set; }
    }
}
