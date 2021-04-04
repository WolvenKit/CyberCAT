using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.DumpedEnums
{
	public enum questVehicleCommandType
	{
		[RealName("Move On Spline")] Move_On_Spline = 0,
		Follow = 1,
		[RealName("Move To")] Move_To = 2,
		Racing = 3,
		[RealName("Join Traffic")] Join_Traffic = 4
	}
}
