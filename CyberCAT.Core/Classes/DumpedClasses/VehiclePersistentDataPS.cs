using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("vehiclePersistentDataPS")]
    public class VehiclePersistentDataPS : GameComponentPS
    {
        [RealName("flags")]
        public uint Flags { get; set; }
        
        [RealName("autopilotPos")]
        public float AutopilotPos { get; set; }
        
        [RealName("autopilotCurrentSpeed")]
        public float AutopilotCurrentSpeed { get; set; }
        
        [RealName("wheelRuntimeData")]
        [RealType("vehicleWheelRuntimePSData", IsStatic = true)]
        public VehicleWheelRuntimePSData[] WheelRuntimeData { get; set; }
        
        [RealName("questEnforcedTransform")]
        public Transform QuestEnforcedTransform { get; set; }
        
        [RealName("destruction")]
        public VehicleDestructionPSData Destruction { get; set; }
        
        [RealName("audio")]
        public VehicleAudioPSData Audio { get; set; }
    }
}
