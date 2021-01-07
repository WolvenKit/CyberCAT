using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ArcadeMachineControllerPS")]
    public class ArcadeMachineControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("gameVideosPaths")]
        public RedResourceReferenceScriptToken[] GameVideosPaths { get; set; }
    }
}
