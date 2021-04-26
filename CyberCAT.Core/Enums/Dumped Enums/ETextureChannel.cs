using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum ETextureChannel
	{
		TextureChannel_R = 1 << 0,
		TextureChannel_G = 1 << 1,
		TextureChannel_B = 1 << 2,
		TextureChannel_A = 1 << 3
	}
}