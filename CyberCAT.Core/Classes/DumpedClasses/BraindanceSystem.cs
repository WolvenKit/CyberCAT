using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("BraindanceSystem")]
    public class BraindanceSystem : GameScriptableSystem
    {
        [RealName("inputMask")]
        public SBraindanceInputMask InputMask { get; set; }
        
        [RealName("requestCameraToggle")]
        [RealType("Bool")]
        public bool RequestCameraToggle { get; set; }
        
        [RealName("requestEditorState")]
        [RealType("Bool")]
        public bool RequestEditorState { get; set; }
        
        [RealName("pauseBraindanceRequest")]
        [RealType("Bool")]
        public bool PauseBraindanceRequest { get; set; }
        
        [RealName("isInBraindance")]
        [RealType("Bool")]
        public bool IsInBraindance { get; set; }
        
        [RealName("debugFFSceneThrehsold")]
        [RealType("Int32")]
        public int DebugFFSceneThrehsold { get; set; }
    }
}
