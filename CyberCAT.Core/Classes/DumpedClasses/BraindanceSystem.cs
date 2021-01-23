using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("BraindanceSystem")]
    public class BraindanceSystem : GameScriptableSystem
    {
        [RealName("inputMask")]
        public SBraindanceInputMask InputMask { get; set; }
        
        [RealName("requestCameraToggle")]
        public bool RequestCameraToggle { get; set; }
        
        [RealName("requestEditorState")]
        public bool RequestEditorState { get; set; }
        
        [RealName("pauseBraindanceRequest")]
        public bool PauseBraindanceRequest { get; set; }
        
        [RealName("isInBraindance")]
        public bool IsInBraindance { get; set; }
        
        [RealName("debugFFSceneThrehsold")]
        public int DebugFFSceneThrehsold { get; set; }
    }
}
