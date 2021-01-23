using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("LiftSetup")]
    public class LiftSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("startingFloorTerminal")]
        public int StartingFloorTerminal { get; set; }
        
        [RealName("liftSpeed")]
        public float LiftSpeed { get; set; }
        
        [RealName("liftStartingDelay")]
        public float LiftStartingDelay { get; set; }
        
        [RealName("liftTravelTimeOverride")]
        public float LiftTravelTimeOverride { get; set; }
        
        [RealName("isLiftTravelTimeOverride")]
        public bool IsLiftTravelTimeOverride { get; set; }
        
        [RealName("emptyLiftSpeedMultiplier")]
        public float EmptyLiftSpeedMultiplier { get; set; }
        
        [RealName("radioStationNumer")]
        public int RadioStationNumer { get; set; }
        
        [RealName("speakerDestroyedQuestFact")]
        public CName SpeakerDestroyedQuestFact { get; set; }
        
        [RealName("speakerDestroyedVFX")]
        public CName SpeakerDestroyedVFX { get; set; }
        
        [RealName("authorizationTextOverride")]
        public string AuthorizationTextOverride { get; set; }
    }
}
