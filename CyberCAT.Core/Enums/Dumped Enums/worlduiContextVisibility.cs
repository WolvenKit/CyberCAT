using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum worlduiContextVisibility
	{
		SceneDefault = 1 << 0,
		SceneTier1 = 1 << 8,
		SceneTier2 = 1 << 16,
		SceneTier3 = 1 << 24,
		SceneTier4 = 1 << 32,
		SceneTier5 = 1 << 40
	}
}