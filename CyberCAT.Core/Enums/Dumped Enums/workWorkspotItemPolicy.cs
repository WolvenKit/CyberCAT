using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum workWorkspotItemPolicy
	{
		ItemPolicy_SpawnItemOnIdleChange = 1 << 0,
		ItemPolicy_DespawnItemOnIdleChange = 1 << 1,
		ItemPolicy_DespawnItemOnReaction = 1 << 2
	}
}