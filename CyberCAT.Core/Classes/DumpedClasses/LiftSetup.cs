using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("LiftSetup")]
    public class LiftSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("startingFloorTerminal")]
        [RealType("Int32")]
        public int StartingFloorTerminal { get; set; }
        
        [RealName("liftSpeed")]
        [RealType("Float")]
        public float LiftSpeed { get; set; }
        
        [RealName("liftStartingDelay")]
        [RealType("Float")]
        public float LiftStartingDelay { get; set; }
        
        [RealName("liftTravelTimeOverride")]
        [RealType("Float")]
        public float LiftTravelTimeOverride { get; set; }
        
        [RealName("isLiftTravelTimeOverride")]
        [RealType("Bool")]
        public bool IsLiftTravelTimeOverride { get; set; }
        
        [RealName("emptyLiftSpeedMultiplier")]
        [RealType("Float")]
        public float EmptyLiftSpeedMultiplier { get; set; }
        
        [RealName("radioStationNumer")]
        [RealType("Int32")]
        public int RadioStationNumer { get; set; }
        
        [RealName("speakerDestroyedQuestFact")]
        [RealType("CName")]
        public string SpeakerDestroyedQuestFact { get; set; }
        
        [RealName("speakerDestroyedVFX")]
        [RealType("CName")]
        public string SpeakerDestroyedVFX { get; set; }
        
        [RealName("authorizationTextOverride")]
        [RealType("String")]
        public string AuthorizationTextOverride { get; set; }
    }
}
