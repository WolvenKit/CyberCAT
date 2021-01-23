using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkTweakDBIDSelector")]
    public class InkTweakDBIDSelector : IScriptable
    {
        [RealName("baseTweakID")]
        public TweakDbId BaseTweakID { get; set; }
    }
}
