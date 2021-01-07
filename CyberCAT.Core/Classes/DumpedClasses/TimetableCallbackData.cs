using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("TimetableCallbackData")]
    public class TimetableCallbackData : IScriptable
    {
        [RealName("time")]
        public SSimpleGameTime Time { get; set; }
        
        [RealName("recipients")]
        public RecipientData[] Recipients { get; set; }
        
        [RealName("callbackID")]
        [RealType("Uint32")]
        public uint CallbackID { get; set; }
    }
}
