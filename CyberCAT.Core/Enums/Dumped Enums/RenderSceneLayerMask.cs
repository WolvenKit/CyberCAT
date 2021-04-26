using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum RenderSceneLayerMask
	{
		Default = 1 << 0,
		Cyberspace = 1 << 1,
		WorldMap = 1 << 2
	}
}