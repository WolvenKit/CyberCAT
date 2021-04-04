using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ChestPressControllerPS")]
    public class ChestPressControllerPS : ScriptableDeviceComponentPS
    {
        [RealName("chestPressSkillChecks")]
        public Handle<EngDemoContainer> ChestPressSkillChecks { get; set; }

        [RealName("factOnQHack")]
        public CName FactOnQHack { get; set; }

        [RealName("wasWeighHacked")]
        public bool WasWeighHacked { get; set; }
    }
}