using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum rendLightChannel
	{
		LC_Channel1 = 1 << 0,
		LC_Channel2 = 1 << 1,
		LC_Channel3 = 1 << 2,
		LC_Channel4 = 1 << 3,
		LC_Channel5 = 1 << 4,
		LC_Channel6 = 1 << 5,
		LC_Channel7 = 1 << 6,
		LC_Channel8 = 1 << 7,
		LC_ChannelWorld = 1 << 8,
		LC_Character = 1 << 9,
		LC_Player = 1 << 10,
		LC_Automated = 1 << 15
	}
}