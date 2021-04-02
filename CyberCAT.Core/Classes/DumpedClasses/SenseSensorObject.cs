using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("senseSensorObject")]
    public class SenseSensorObject : ISerializable
    {
        [RealName("hearingEnabled")]
        public bool HearingEnabled { get; set; }
        
        [RealName("sensorObjectType")]
        public DumpedEnums.gamedataSenseObjectType? SensorObjectType { get; set; }
        
        [RealName("presetID")]
        public TweakDbId PresetID { get; set; }
        
        [RealName("detectionFactor")]
        public float DetectionFactor { get; set; }
        
        [RealName("detectionDropFactor")]
        public float DetectionDropFactor { get; set; }
        
        [RealName("detectionCoolDownTime")]
        public float DetectionCoolDownTime { get; set; }
        
        [RealName("detectionPartCoolDownTime")]
        public float DetectionPartCoolDownTime { get; set; }
    }
}
