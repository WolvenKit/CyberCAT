using System;

namespace CyberCAT.Core.DumpedEnums
{
	[Flags]
	public enum gameuiContext
	{
		Default = 1 << 0,
		QuickHack = 1 << 1,
		Scanning = 1 << 2,
		DeviceZoom = 1 << 3,
		BraindanceEditor = 1 << 4,
		BraindancePlayback = 1 << 5,
		VehicleMounted = 1 << 6,
		ModalPopup = 1 << 7,
		RadialWheel = 1 << 8,
		VehicleRace = 1 << 9,
		MAX = 1 << 31
	}
}