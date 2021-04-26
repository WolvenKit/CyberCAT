using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum TriggerChannel
	{
		TC_Default = 1 << 0,
		TC_Player = 1 << 1,
		TC_Camera = 1 << 2,
		TC_Human = 1 << 3,
		TC_SoundReverbArea = 1 << 4,
		TC_SoundAmbientArea = 1 << 5,
		TC_Quest = 1 << 6,
		TC_Projectiles = 1 << 7,
		TC_Vehicle = 1 << 8,
		TC_Environment = 1 << 9,
		TC_WaterNullArea = 1 << 10,
		TC_Custom0 = 1 << 16,
		TC_Custom1 = 1 << 17,
		TC_Custom2 = 1 << 18,
		TC_Custom3 = 1 << 19,
		TC_Custom4 = 1 << 20,
		TC_Custom5 = 1 << 21,
		TC_Custom6 = 1 << 22,
		TC_Custom7 = 1 << 23,
		TC_Custom8 = 1 << 24,
		TC_Custom9 = 1 << 25,
		TC_Custom10 = 1 << 26,
		TC_Custom11 = 1 << 27,
		TC_Custom12 = 1 << 28,
		TC_Custom13 = 1 << 29,
		TC_Custom14 = 1 << 30
	}
}