using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("gameVisionModeComponent")]
    public class GameVisionModeComponent : GameComponent
    {
        [RealName("defaultHighlightData")]
        public Handle<HighlightEditableData> DefaultHighlightData { get; set; }
        
        [RealName("forcedHighlights")]
        public Handle<FocusForcedHighlightData>[] ForcedHighlights { get; set; }
        
        [RealName("activeForcedHighlight")]
        public Handle<FocusForcedHighlightData> ActiveForcedHighlight { get; set; }
        
        [RealName("currentDefaultHighlight")]
        public Handle<FocusForcedHighlightData> CurrentDefaultHighlight { get; set; }
        
        [RealName("activeRevealRequests")]
        public GameVisionModeSystemRevealIdentifier[] ActiveRevealRequests { get; set; }
        
        [RealName("isFocusModeActive")]
        public bool IsFocusModeActive { get; set; }
        
        [RealName("wasCleanedUp")]
        public bool WasCleanedUp { get; set; }
        
        [RealName("availableVisionModes")]
        public GameVisionModuleParams[] AvailableVisionModes { get; set; }
    }
}
