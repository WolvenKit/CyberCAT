using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum gameEItemDynamicTags
	{
		Quest = 1 << 0,
		UnequipBlocked = 1 << 1
	}
}