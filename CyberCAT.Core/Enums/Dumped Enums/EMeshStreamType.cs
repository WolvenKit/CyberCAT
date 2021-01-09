namespace CyberCAT.Core.DumpedEnums
{
public enum EMeshStreamType
{
	MST_Position_3F = 1,
	MST_SkinningIndices_4U8 = 2,
	MST_SkinningWeights_4F = 4,
	MST_Color_U32 = 8,
	MST_TexCoord0_2F = 16,
	MST_TexCoord1_2F = 32,
	MST_Normal_3F = 64,
	MST_Tangent_3F = 128,
	MST_Binormal_3F = 256,
	MST_Index_U16 = 512,
	MST_WindBranchData_4F = 1024,
	MST_BranchData_7F = 16384,
	MST_SkinningIndicesExt_4U8 = 262144,
	MST_SkinningWeightsExt_4F = 524288,
	MST_DestructionIndices_2U16 = 1048576,
	MST_Multilayer_1F = 2097152,
	MST_GarmentFlags_U32 = 4194304,
	MST_MorphOffset_3F = 8388608,
	MST_VehicleDmgNormalFront_3F = 16777216,
	MST_VehicleDmgNormalSides_3F = 33554432,
	MST_VehicleDmgPosFront_3F = 67108864,
	MST_VehicleDmgPosSides_3F = 134217728,
	MST_MorphVertexData_3F = 268435456,
	MST_FoliageBoneId_I16 = 536870912,
	MST_LightBlockerIntensity_1F = 1073741824
}
}
