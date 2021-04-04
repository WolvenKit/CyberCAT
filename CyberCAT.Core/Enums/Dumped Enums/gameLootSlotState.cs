using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum gameLootSlotState
	{
		Looted = 1 << 0,
		Unavailable = 1 << 1
	}
}