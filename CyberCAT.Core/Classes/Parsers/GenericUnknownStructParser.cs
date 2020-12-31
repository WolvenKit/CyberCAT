using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class GenericUnknownStructParser
    {
        public const bool DEBUG_WRITING = false;

        private string ReadStringAtOffset(BinaryReader reader, long baseAddress, uint offset, int length)
        {
            var origPos = reader.BaseStream.Position;
            reader.BaseStream.Position = baseAddress + offset;
            var bytes = reader.ReadBytes(length);
            reader.BaseStream.Position = origPos;

            return Encoding.ASCII.GetString(bytes);
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new GenericUnknownStruct();

            reader.Skip(4); //skip Id

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
            var dataBuffer = reader.ReadBytes(readSize);

            if (DEBUG_WRITING)
            {
                File.WriteAllBytes($"C:\\Dev\\T1\\{node.Name}.bin", dataBuffer);
            }

            using (var ms = new MemoryStream(dataBuffer))
            {
                using (var br = new BinaryReader(ms))
                {
                    result.TotalLength = br.ReadUInt32();
                    result.Unknown1 = br.ReadBytes(4);
                    result.Unknown2 = br.ReadUInt32();
                    result.Unknown3 = br.ReadBytes(4);

                    var stringListOffset = br.ReadUInt32();
                    var dataIndexListOffset = br.ReadUInt32();
                    var dataListOffset = br.ReadUInt32();

                    if (result.Unknown2 > 1)
                    {
                        var count1 = br.ReadInt32();

                        result.CNameHashes1 = new ulong[count1];
                        for (int i = 0; i < count1; i++)
                        {
                            result.CNameHashes1[i] = br.ReadUInt64();
                        }
                    }

                    var stringIndexListPosition = br.BaseStream.Position;
                    var stringListPosition = stringIndexListPosition + stringListOffset;
                    var dataIndexListPosition = stringIndexListPosition + dataIndexListOffset;
                    var dataListPosition = stringIndexListPosition + dataListOffset;

                    // start of stringIndexList
                    var stringInfoList = new List<KeyValuePair<uint, byte>>();
                    for (int i = 0; i < (stringListPosition - stringIndexListPosition) / 4; i++)
                    {
                        stringInfoList.Add(new KeyValuePair<uint, byte>(br.ReadUInt24(), br.ReadByte()));
                    }

                    // start of stringList
                    Debug.Assert(br.BaseStream.Position == stringListPosition);

                    var stringList = new List<string>();
                    foreach (var pair in stringInfoList)
                    {
                        Debug.Assert(br.BaseStream.Position == stringIndexListPosition + pair.Key);
                        stringList.Add(br.ReadString(pair.Value - 1));
                        br.Skip(1); // null terminator
                    }

                    // start of dataIndexList
                    Debug.Assert(br.BaseStream.Position == dataIndexListPosition);

                    var pointerList = new List<KeyValuePair<uint, uint>>();
                    for (int i = 0; i < (dataListPosition - dataIndexListPosition) / 8; i++)
                    {
                        pointerList.Add(new KeyValuePair<uint, uint>(br.ReadUInt32(), br.ReadUInt32()));
                    }

                    // start of dataList
                    Debug.Assert(br.BaseStream.Position == dataListPosition);

                    result.ClassList = new GenericUnknownStruct.ClassEntry[pointerList.Count];
                    for (int i = 0; i < pointerList.Count; i++)
                    {
                        var classEntry = new GenericUnknownStruct.ClassEntry();
                        classEntry.Name = stringList[(int)pointerList[i].Key];

                        br.BaseStream.Position = stringIndexListPosition + pointerList[i].Value;
                        classEntry.Fields = ReadFields(br, stringList);

                        result.ClassList[i] = classEntry;
                    }

                    // end of mainData
                    Debug.Assert((br.BaseStream.Position - 4) == result.TotalLength);

                    readSize = (int) (br.BaseStream.Length - br.BaseStream.Position);
                    if (readSize > 0)
                    {
                        var count1 = br.ReadInt32();

                        result.CNameHashes2 = new ulong[count1];
                        for (int i = 0; i < count1; i++)
                        {
                            result.CNameHashes2[i] = br.ReadUInt64();
                        }
                    }
                }
            }

            readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
            Debug.Assert(readSize == 0);

            return result;
        }

        public GenericUnknownStruct.BaseGenericField[] ReadFields(BinaryReader reader, List<string> stringList)
        {
            var startPos = reader.BaseStream.Position;

            // Testing time
            var fieldCount = reader.ReadUInt16();

            var fieldArray = new GenericUnknownStruct.BaseGenericField[fieldCount];
            var offsetList = new uint[fieldCount];
            for (int i = 0; i < fieldCount; i++)
            {
                fieldArray[i] = new GenericUnknownStruct.BaseGenericField();

                fieldArray[i].Name = stringList[reader.ReadUInt16()];
                fieldArray[i].Type = stringList[reader.ReadUInt16()];
                offsetList[i] = reader.ReadUInt32();
            }

            for (int i = 0; i < fieldArray.Length; i++)
            {
                reader.BaseStream.Position = startPos + offsetList[i];

                var val = ReadFieldValue(reader, fieldArray[i].Name, fieldArray[i].Type, stringList);

                var type = typeof(GenericUnknownStruct.GenericField<>).MakeGenericType(val.GetType());
                dynamic field = Activator.CreateInstance(type, val);
                field.Name = fieldArray[i].Name;
                field.Type = fieldArray[i].Type;

                fieldArray[i] = field;
            }

            return fieldArray;
        }

        public static List<string> KnownFieldTypes = new List<string>();
        public static List<string> KnownEnumTypes = new List<string>();

        public object ReadFieldValue(BinaryReader reader, string fieldName, string fieldType, List<string> stringList)
        {
            if (fieldType.StartsWith("array:") || fieldType.StartsWith("static:") || fieldType.StartsWith("["))
            {
                if (fieldType.StartsWith("array:"))
                    fieldType = fieldType.Substring("array:".Length);
                else if (fieldType.StartsWith("static:"))
                    fieldType = fieldType.Substring(fieldType.IndexOf(',') + 1);
                else
                    fieldType = fieldType.Substring(fieldType.IndexOf(']') + 1);

                var arraySize = reader.ReadUInt32();
                object result = null;
                for (int i = 0; i < arraySize; i++)
                {
                    var val = ReadFieldValue(reader, fieldName, fieldType, stringList);

                    if (i == 0)
                        result = Array.CreateInstance(val.GetType(), arraySize);
                    ((Array)result).SetValue(val, i);
                }

                return result;
            }

            if (fieldType.StartsWith("script_ref:"))
            {
                throw new Exception();
            }

            if (fieldType.StartsWith("handle:"))
            {
                return reader.ReadUInt32();
            }

            switch (fieldType)
            {
                case "Bool":
                    return reader.ReadByte() != 0;

                case "Int32":
                    return reader.ReadInt32();

                case "Uint32":
                    return reader.ReadUInt32();

                case "Int64":
                    return reader.ReadInt64();

                case "Uint64":
                case "TweakDBID":
                    return reader.ReadUInt64();

                case "Float":
                    return reader.ReadSingle();

                case "NodeRef":
                    var size = reader.ReadUInt16();
                    var buffer = reader.ReadBytes(size);
                    return Encoding.ASCII.GetString(buffer);

                case "CName":
                    return stringList[reader.ReadUInt16()];

                // Not needed, but why not
                case "vehicleVehicleDoorInteractionState":
                case "gameEHotkey":
                case "gameStatIDType":
                case "gameStatPoolDataValueChangeMode":
                case "gameStatPoolDataStatPoolModificationStatus":
                case "gameuiHackingMinigameState":
                case "vehicleVehicleDoorState":
                case "vehicleEVehicleWindowState":
                case "vehicleCameraPerspective":
                    var val = stringList[reader.ReadUInt16()];
                    return val;

                // TODO: special cases
                case "KEEP_FOR_DEBUG":
                    var cPos = reader.BaseStream.Position;
                    var buffer2 = reader.ReadBytes(256);
                    var debugStr = BitConverter.ToString(buffer2).Replace("-", " ");
                    reader.BaseStream.Position = cPos;
                    return new byte[2];
            }

            if (ENUMS.Contains(fieldType))
                return stringList[reader.ReadUInt16()];

            if (KnownFieldTypes.Contains(fieldType))
                return ReadFields(reader, stringList);

            if (KnownEnumTypes.Contains(fieldType))
                return stringList[reader.ReadUInt16()];

            // TODO:
            var pos2 = reader.BaseStream.Position;
            try
            {
                var val = ReadFields(reader, stringList);
                if (!KnownFieldTypes.Contains(fieldType))
                {
                    KnownFieldTypes.Add(fieldType);
                }
                return val;
            }
            catch (Exception)
            {
                reader.BaseStream.Position = pos2;

                var stringValue = stringList[reader.ReadUInt16()];
                if (!KnownEnumTypes.Contains(fieldType))
                {
                    KnownEnumTypes.Add(fieldType);
                }
                return stringValue;
            }
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            byte[] result;
            var data = (GenericUnknownStruct)node.Value;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(new byte[4]);
                    writer.Write(data.Unknown1);
                    writer.Write(data.Unknown2);
                    writer.Write(data.Unknown3);
                    writer.Write(new byte[12]);

                    if (data.Unknown2 > 1)
                    {
                        writer.Write(data.CNameHashes1.Length);
                        foreach (var hash in data.CNameHashes1)
                        {
                            writer.Write(hash);
                        }
                    }

                    var pos = writer.BaseStream.Position;

                    var stringList = GenerateStringList(data);

                    var offset = stringList.Count * 4;
                    foreach (var str in stringList)
                    {
                        writer.WriteInt24(offset);
                        writer.Write((byte)(str.Length + 1));
                        offset += (short)(str.Length + 1);
                    }

                    var stringTableOffset = writer.BaseStream.Position - pos;

                    foreach (var str in stringList)
                    {
                        var bytes = Encoding.ASCII.GetBytes(str);
                        writer.Write(bytes);
                        writer.Write(new byte[1]);
                    }

                    var indexTableOffset = writer.BaseStream.Position - pos;

                    foreach (var classEntry in data.ClassList)
                    {
                        var strId = stringList.IndexOf(classEntry.Name);
                        writer.Write(strId);
                        writer.Write(new byte[4]);
                    }

                    var dataTableOffset = writer.BaseStream.Position - pos;

                    for (int i = 0; i < data.ClassList.Length; i++)
                    {
                        var classEntry = data.ClassList[i];

                        var buffer = GenerateDataFromFields(classEntry.Fields, stringList);

                        var classOffset = writer.BaseStream.Position - pos;
                        writer.Write(buffer);
                        var currentPos = writer.BaseStream.Position;

                        writer.BaseStream.Position = pos + indexTableOffset + (i * 8) + 4;
                        writer.Write((uint)classOffset);
                        writer.BaseStream.Position = currentPos;
                    }

                    writer.BaseStream.Position = 0;
                    writer.Write((int)writer.BaseStream.Length - 4);
                    writer.BaseStream.Position += 12;
                    writer.Write((int)stringTableOffset);
                    writer.Write((int)indexTableOffset);
                    writer.Write((int)dataTableOffset);
                }

                result = stream.ToArray();
            }

            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(node.Id);
                    writer.Write(result);
                    if (data.CNameHashes2 != null && data.CNameHashes2.Length > 0)
                    {
                        writer.Write(data.CNameHashes2.Length);
                        foreach (var hash in data.CNameHashes2)
                        {
                            writer.Write(hash);
                        }
                    }
                }
                result = stream.ToArray();
                node.Size = result.Length;
                node.TrueSize = result.Length;
            }

            if (DEBUG_WRITING)
            {
                var buffer = new byte[result.Length - 4];
                Array.Copy(result, 4, buffer, 0, buffer.Length);
                File.WriteAllBytes($"C:\\Dev\\T1\\{node.Name}_new.bin", buffer);
            }

            return result;
        }

        private List<string> GenerateStringList(GenericUnknownStruct data)
        {
            var result = new List<string>();

            foreach (var classEntry in data.ClassList)
            {
                if (!result.Contains(classEntry.Name))
                {
                    result.Add(classEntry.Name);
                }

                GenerateStringListFromFields(classEntry.Fields, ref result);
            }

            return result;
        }

        private void GenerateStringListFromFields(GenericUnknownStruct.BaseGenericField[] fields, ref List<string> strings)
        {
            foreach (dynamic field in fields)
            {
                if (!strings.Contains(field.Name))
                {
                    strings.Add(field.Name);
                }

                if (!strings.Contains(field.Type))
                {
                    strings.Add(field.Type);
                }

                if (field.Type == "NodeRef" || field.Type == "array:NodeRef")
                {
                    continue;
                }
                else if (field.Value is IList)
                {
                    if (field.Value is GenericUnknownStruct.BaseGenericField[] subFields1)
                    {
                        GenerateStringListFromFields(subFields1, ref strings);
                    }
                    else
                    {
                        var subList = (IList)field.Value;
                        foreach (var t1 in subList)
                        {
                            if (t1 is GenericUnknownStruct.BaseGenericField[] subFields2)
                            {
                                GenerateStringListFromFields(subFields2, ref strings);
                            }
                            else if (t1 is String)
                            {
                                var strVal = (string)t1;
                                if (!strings.Contains(strVal))
                                {
                                    strings.Add(strVal);
                                }
                            }
                        }
                    }
                }
                else if (field.Value is String)
                {
                    var strVal = (string)field.Value;
                    if (!strings.Contains(strVal))
                    {
                        strings.Add(strVal);
                    }
                }
            }
        }

        private byte[] GenerateDataFromFields(GenericUnknownStruct.BaseGenericField[] fields, List<string> stringList)
        {
            byte[] result;

            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write((ushort)fields.Length);
                    foreach (var field in fields)
                    {
                        writer.Write((ushort)stringList.IndexOf(field.Name));
                        writer.Write((ushort)stringList.IndexOf(field.Type));
                        writer.Write(new byte[4]); // offset
                    }

                    for (int i = 0; i < fields.Length; i++)
                    {
                        var pos = writer.BaseStream.Position;
                        writer.BaseStream.Position = 6 + (i * 8);
                        writer.Write((uint)pos);
                        writer.BaseStream.Position = pos;

                        dynamic field = fields[i];
                        if (field.Type == "NodeRef")
                        {
                            var valStr = (string)field.Value;
                            var valBytes = Encoding.ASCII.GetBytes(valStr);

                            writer.Write((ushort)valStr.Length);
                            writer.Write(valBytes);
                        }
                        else if (field.Value is IList)
                        {
                            if (field.Value is GenericUnknownStruct.BaseGenericField[] subFields1)
                            {
                                var buffer = GenerateDataFromFields(subFields1, stringList);
                                writer.Write(buffer);
                            }
                            else
                            {
                                var subList = (IList)field.Value;
                                writer.Write(subList.Count);
                                foreach (var t1 in subList)
                                {
                                    if (field.Type == "array:NodeRef")
                                    {
                                        var valStr = (string)t1;
                                        var valBytes = Encoding.ASCII.GetBytes(valStr);

                                        writer.Write((ushort)valStr.Length);
                                        writer.Write(valBytes);
                                    }
                                    else if (t1 is GenericUnknownStruct.BaseGenericField[] subFields2)
                                    {
                                        var buffer = GenerateDataFromFields(subFields2, stringList);
                                        writer.Write(buffer);
                                    }
                                    else if (t1 is String)
                                    {
                                        writer.Write((ushort)stringList.IndexOf((string)t1));
                                    }
                                    else
                                    {
                                        WriteValue(writer, t1);
                                    }
                                }
                            }
                        }
                        else if (field.Value is String)
                        {
                            writer.Write((ushort)stringList.IndexOf((string)field.Value));
                        }
                        else
                        {
                            WriteValue(writer, field.Value);
                        }
                    }
                }

                result = stream.ToArray();
            }

            return result;
        }

        private void WriteValue(BinaryWriter writer, object value)
        {
            var type = value.GetType();
            var typeStr = type.FullName;

            switch (typeStr)
            {
                case "System.Byte":
                    writer.Write((byte)value);
                    break;

                case "System.Int16":
                    writer.Write((short)value);
                    break;

                case "System.UInt16":
                    writer.Write((ushort)value);
                    break;

                case "System.Int32":
                    writer.Write((int)value);
                    break;

                case "System.UInt32":
                    writer.Write((uint)value);
                    break;

                case "System.Int64":
                    writer.Write((long)value);
                    break;

                case "System.UInt64":
                    writer.Write((ulong)value);
                    break;

                case "System.Boolean":
                    writer.Write((bool)value);
                    break;

                case "System.Single":
                    writer.Write((float)value);
                    break;

                default:
                    throw new Exception();
            }
        }

        private readonly List<string> ENUMS = new List<string>
        {
            "ActiveMode", "ActorVisibilityStatus", "AdditionalTraceType", "AIactionParamsPackageTypes",
            "AIArgumentType", "AIbehaviorCompletionStatus", "AIbehaviorConditionOutcomes", "AIbehaviorUpdateOutcome",
            "AICombatSectorType", "AICombatSpaceSize", "AICommandState", "AICoverExposureMethod", "AIEExecutionOutcome",
            "AIEInterruptionOutcome", "aimTypeEnum", "AIParameterizationType", "AIReactionCountOutcome",
            "AISignalFlags", "AISquadType", "AIThreatPersistenceStatus", "AITrackedStatusType",
            "AIUninterruptibleActionType", "animAimState", "animCoverAction", "animCoverState", "animHitReactionType",
            "animLookAtChestMode", "animLookAtEyesMode", "animLookAtHeadMode", "animLookAtLeftHandedMode",
            "animLookAtLimitDegreesType", "animLookAtLimitDistanceType", "animLookAtRightHandedMode",
            "animLookAtStatus", "animLookAtStyle", "animLookAtTwoHandedMode", "animNPCVehicleDeathType",
            "animStanceState", "animWeaponOwnerType", "AttitudeChange", "AttributeButtonState", "audioAudioEventFlags",
            "audioEventActionType", "BlacklistReason", "braindanceVisionMode", "ButtonStatus", "CharacterScreenType",
            "ClueState", "CodexCategoryType", "CodexDataSource", "CodexImageType", "coverLeanDirection",
            "CrafringMaterialItemHighlight", "CraftingCommands", "CraftingInfoType", "CraftingMode",
            "CraftingNotificationType", "CustomButtonType", "CustomWeaponWheelSlot", "CyberwareInfoType",
            "CyberwareScreenType", "DamageEffectDisplayType", "damageSystemLogFlags", "DerivedFilterResult",
            "DeviceStimType", "DMGPipelineType", "DronePose", "DropdownDisplayContext", "DropdownItemDirection",
            "DropPointPackageStatus", "EActionContext", "EActionInactivityReson", "EActionsSequencerMode",
            "EActionType", "EActivationState", "EAIActionPhase", "EAIActionState", "EAIActionTarget", "EAIAttitude",
            "EAIBackgroundCombatStep", "EAICombatPreset", "EAICoverAction", "EAICoverActionDirection",
            "EAIDismembermentBodyPart", "EAIGateEventFlags", "EAIGateSignalFlags", "EAIHitBodyPart", "EAIHitDirection",
            "EAIHitIntensity", "EAIHitSource", "EAILastHitReactionPlayed", "EAimAssistLevel", "EAIPlayerSquadOrder",
            "EAIRole", "EAIShootingPatternRange", "EAISquadAction", "EAISquadChoiceAlgorithm", "EAISquadRing",
            "EAISquadTactic", "EAISquadVerb", "EAITargetType", "EAIThreatCalculationType", "EAITicketStatus",
            "EAllowedTo", "EAnimationType", "EArgumentType", "EAttackType", "EAxisType", "EBarkList", "EBeamStyle",
            "EBinkOperationType", "EBOOL", "EBreachOrigin", "EBroadcasteingType", "ECallbackExpressionActions",
            "ECameraDirectionFunctionalTestsUtil", "ECarryState", "ECartOperationResult", "ECentaurShieldState",
            "ECLSForcedState", "ECompanionDistancePreset", "ECompanionPositionPreset", "ECompareOp",
            "EComparisonOperator", "EComparisonType", "EComponentOperation", "EComputerAnimationState",
            "EComputerMenuType", "EConclusionQuestState", "ECooldownGameControllerMode", "ECooldownIndicatorState",
            "ECoverSpecialAction", "ECraftingIconPositioning", "EDeathType", "EDebuggerColor",
            "EDeviceChallengeAttribute", "EDeviceChallengeSkill", "EDeviceDurabilityState", "EDeviceDurabilityType",
            "EDeviceStatus", "EDocumentType", "EDodgeMovementInput", "EDoorOpeningType", "EDoorSkillcheckSide",
            "EDoorStatus", "EDoorTriggerSide", "EDoorType", "EDownedType", "EDPadSlot", "EDrillMachineRewireState",
            "EEffectOperationType", "EEquipmentSetType", "EEquipmentSide", "EEquipmentState",
            "EExplosiveAdditionalGameEffectType", "EFastTravelSystemInstruction", "EFastTravelTriggerType",
            "EFilterType", "EFocusClueInvestigationState", "EFocusForcedHighlightType", "EFocusOutlineType",
            "EForcedElevatorArrowsState", "EGameplayChallengeLevel", "EGameplayRole", "EGameSessionDataType",
            "EGenericNotificationPriority", "EGlitchState", "EGravityType", "EGrenadeType", "EHandEquipSlot",
            "EHitReactionMode", "EHitReactionZone", "EHitShapeType", "EHotkey", "EHotkeyRequestType", "EHudAvatarMode",
            "EHudPhoneFunction", "EHudPhoneVisibility", "EIndustrialArmAnimations", "EInitReactionAnim",
            "EInkAnimationPlaybackOption", "EInputCustomKey", "EInputKey", "EInventoryComboBoxMode",
            "EInventoryDataStatDisplayType", "EItemOperationType", "EItemSlotCheckType", "EJuryrigTrapState",
            "EKnockdownStates", "ELastUsed", "ELauncherActionType", "ELaunchMode", "ELayoutType", "ELightSequenceStage",
            "ELightSwitchRandomizerType", "ELinkType", "ELogicOperator", "ELogType", "EMagazineAmmoState",
            "EMappinDisplayMode", "EMappinVisualState", "EMathOperationType", "EMathOperator", "EMeasurementSystem",
            "EMeasurementUnit", "EMeleeAttacks", "EMeleeAttackType", "EMissileRainPhase", "EMoveAssistLevel",
            "EMovementDirection", "ENetworkRelation", "ENeutralizeType", "ENPCPhaseState", "ENPCTelemetryData",
            "entAttachmentTarget", "entAudioDismembermentPart", "EntityNotificationType",
            "entragdollActivationRequestType", "EOperationClassType", "EOutlineType", "EPaymentSchedule",
            "EPermissionSource", "EPersonalLinkConnectionStatus", "EPersonalLinkSlotSide", "EPingType",
            "EPlayerMovementDirection", "EPlaystyle", "EPlaystyleType", "EPowerDifferential",
            "EPreventionDebugProcessReason", "EPreventionHeatStage", "EPreventionPsychoLogicType",
            "EPreventionSystemInstruction", "EPriority", "EProgressBarContext", "EProgressBarType", "EQuestFilterType",
            "EQuestVehicleDoorState", "EQuestVehicleWindowState", "EquipmentManipulationAction",
            "EquipmentManipulationRequestSlot", "EquipmentManipulationRequestType", "EquipmentPriority", "ERadialMode",
            "ERadioStationList", "EReactionValue", "ERenderingPlane", "ERentStatus", "EReprimandInstructions",
            "ERevealDurationType", "ERevealPlayerType", "ERevealState", "EScreenRatio", "ESecurityAccessLevel",
            "ESecurityAreaType", "ESecurityGateEntranceType", "ESecurityGateResponseType",
            "ESecurityGateScannerIssueType", "ESecurityGateStatus", "ESecurityNotificationType", "ESecuritySystemState",
            "ESecurityTurretStatus", "ESecurityTurretType", "ESensorDeviceStates", "ESensorDeviceWakeState",
            "EShouldChangeAttitude", "ESlotState", "ESmartBulletPhase", "ESmartHousePreset", "ESoundStatusEffects",
            "ESpaceFillMode", "EStatProviderDataSource", "EStatusEffectBehaviorType", "EStatusEffects",
            "EstatusEffectsState", "ESurveillanceCameraState", "ESurveillanceCameraStatus", "ESwitchAction", "ESystems",
            "ETakedownActionType", "ETakedownBossName", "ETargetManagerAnimGraphState", "ETauntType", "ETelemetryData",
            "EToggleActivationTypeComputer", "EToggleOperationType", "ETooltipsStyle",
            "ETransformAnimationOperationType", "ETransitionMode", "ETrap", "ETrapEffects", "ETriggerOperationType",
            "ETVChannel", "ETweakAINodeType", "EUIActionState", "EUIStealthIconType", "EUploadProgramState",
            "EVarDBMode", "EVehicleDoor", "EVehicleWindowState", "EVendorMode", "EViabilityDecision", "EVirtualSystem",
            "EVisualizerActivityState", "EVisualizerType", "EWeaponNamesList", "EWidgetPlacementType", "EWidgetState",
            "EWindowBlindersStates", "EWorkspotOperationType", "EWorldMapView", "EWoundedBodyPart",
            "ExplosiveTriggerDeviceLaserState", "ExtraEffect", "Ft_Result", "Ft_TakedownStage", "Ft_TakedownType",
            "FTNpcMountingState", "FTScriptState", "FunctionalTestsResultCode", "gameaudioeventsSurfaceDirection",
            "gamecheatsystemFlag", "gameCityAreaType", "gameCombinedStatOperation", "gameContactType",
            "gameCoverHeight", "gameDamageCallbackType", "gameDamagePipelineStage", "gamedataAchievement",
            "gamedataAffiliation", "gamedataAIActionSecurityAreaType", "gamedataAIActionSecurityNotificationType",
            "gamedataAIActionTarget", "gamedataAIActionType", "gamedataAIAdditionalTraceType",
            "gamedataAIDirectorEntryStartType", "gamedataAIExposureMethodType", "gamedataAimAssistType",
            "gamedataAIRingType", "gamedataAIRole", "gamedataAISmartCompositeType", "gamedataAISquadType",
            "gamedataAITacticType", "gamedataAITicketType", "gamedataArchetypeType", "gamedataAttackSubtype",
            "gamedataAttackType", "gamedataBuildType", "gamedataChargeStep", "gamedataChoiceCaptionPartType",
            "gamedataCompanionDistancePreset", "gamedataConsumableBaseName", "gamedataConsumableType",
            "gamedataDamageType", "gamedataDefenseMode", "gamedataDevelopmentPointType", "gamedataDistrict",
            "gamedataEquipmentArea", "gamedataEthnicity", "gamedataFxAction", "gamedataFxActionType", "gamedataGender",
            "gamedataGrenadeDeliveryMethodType", "gamedataHitPrereqConditionType", "gamedataImprovementRelation",
            "gamedataItemCategory", "gamedataItemStructure", "gamedataItemType", "gamedataLifePath",
            "gamedataLocomotionMode", "gamedataMappinPhase", "gamedataMappinVariant", "gamedataMeleeAttackDirection",
            "gamedataMetaQuest", "gamedataMovementType", "gamedataNPCBehaviorState", "gamedataNPCHighLevelState",
            "gamedataNPCQuestAffiliation", "gamedataNPCRarity", "gamedataNPCStanceState", "gamedataNPCType",
            "gamedataNPCUpperBodyState", "gamedataObjectActionReference", "gamedataObjectActionType", "gamedataOutput",
            "gamedataParentAttachmentType", "gamedataPerkArea", "gamedataPerkType", "gamedataPerkUtility",
            "gamedataPingType", "gamedataPlayerBuild", "gamedataPlayerPossesion", "gamedataProficiencyType",
            "gamedataProjectileLaunchMode", "gamedataProjectileOnCollisionAction", "gamedataQuality",
            "gamedataReactionPresetType", "gamedataSenseObjectType", "gamedataSpawnableObjectPriority",
            "gamedataStatPoolType", "gamedataStatType", "gamedataStatusEffectAIBehaviorFlag",
            "gamedataStatusEffectAIBehaviorType", "gamedataStatusEffectType", "gamedataStatusEffectVariation",
            "gamedataStimPriority", "gamedataStimPropagation", "gamedataStimType", "gamedataSubCharacter",
            "gamedataTrackingMode", "gamedataTraitType", "gamedataTriggerMode", "gamedataUICondition",
            "gamedataUIIconCensorFlag", "gamedataUINameplateDisplayType", "gamedataVehicleManufacturer",
            "gamedataVehicleModel", "gamedataVehicleType", "gamedataVendorType", "gamedataWeaponEvolution",
            "gamedataWeaponManufacturer", "gamedataWorkspotActionType", "gamedataWorkspotCategory",
            "gamedataWorkspotReactionType", "gamedataWorldMapFilter", "gameDebugViewETextAlignment",
            "gamedeviceActionPropertyFlags", "gamedeviceRequestType", "gameDifficulty", "gameDismBodyPart",
            "gameDismWoundType", "gameEActionStatus", "gameEContinuousMode", "gameEEquipmentManagerState",
            "gameEnemyStealthAwarenessState", "gameEntitySpawnerEventType", "gameEPrerequisiteType",
            "gameEquipAnimationType", "gameEStatFlags", "gameeventsDeathDirection", "gameGodModeType",
            "gameGrenadeThrowStartType", "gameinfluenceCollisionTestOutcome", "gameinfluenceTestLineResult",
            "gameinputActionType", "gameinteractionsBumpIntensity", "gameinteractionsBumpLocation",
            "gameinteractionsBumpSide", "gameinteractionsChoiceType", "gameinteractionsEInteractionEventType",
            "gameinteractionsELootChoiceType", "gameinteractionsELootVisualiserControlOperation",
            "gameinteractionsReactionState", "gameItemEquipContexts", "gameItemUnequipContexts",
            "gameJournalBriefingContentType", "gameJournalEntryState", "gameJournalListenerType",
            "gameJournalQuestType", "gameKillType", "gameLoSMode", "gamemappinsMappinTargetType",
            "gamemappinsVerticalPositioning", "gameMessageSender", "gameMountingObjectType",
            "gameMountingRelationshipType", "gameMountingSlotRole", "gameMovingPlatformLoopType",
            "gameMovingPlatformMovementInitializationType", "gamePlatformMovementState", "gamePlayerCoverDirection",
            "gamePlayerCoverMode", "gamePlayerObstacleSystemQueryType", "gamePlayerStateMachine", "GameplayTier",
            "gameprojectileELaunchMode", "gameprojectileOnCollisionAction", "gamePSMBodyCarrying",
            "gamePSMBodyCarryingLocomotion", "gamePSMBodyCarryingStyle", "gamePSMCombat", "gamePSMCombatGadget",
            "gamePSMCrosshairStates", "gamePSMDetailedBodyDisposal", "gamePSMDetailedLocomotionStates",
            "gamePSMFallStates", "gamePSMHighLevel", "gamePSMLandingState", "gamePSMLeftHandCyberware",
            "gamePSMLocomotionStates", "gamePSMMelee", "gamePSMMeleeWeapon", "gamePSMNanoWireLaunchMode",
            "gamePSMRangedWeaponStates", "gamePSMReaction", "gamePSMStamina", "gamePSMSwimming", "gamePSMTakedown",
            "gamePSMTimeDilation", "gamePSMUIState", "gamePSMUpperBodyStates", "gamePSMVehicle", "gamePSMVision",
            "gamePSMVisionDebug", "gamePSMVitals", "gamePSMWeaponStates", "gamePSMWhip", "gamePSMWorkspotState",
            "gamePSMZones", "gameReprimandMappinAnimationState", "gameSaveLockReason", "gameScanningMode",
            "gameScanningState", "gameSceneAnimationMotionActionParamsPlacementMode", "gameScriptedBlackboardStorage",
            "gameSharedInventoryTag", "gamesmartGunTargetState", "gamestateMachineParameterAspect",
            "gameStatModifierType", "gameStatObjectsRelation", "gameStatPoolModificationTypes", "gameStoryTier",
            "gametargetingSystemETargetFilterStatus", "gameTelemetryDamageSituation", "gameTickableEventState",
            "gameTutorialBracketType", "gameuiAuthorisationNotificationType", "gameuiCharacterCustomizationPart",
            "gameuiDamageDigitsMode", "gameuiDamageDigitsStickingMode", "gameuiDamageIndicatorMode",
            "gameuiEBraindanceLayer", "gameuiEClueDescriptorMode", "gameuiEWorldMapDistrictView", "gameuiHitType",
            "gameuiMappinGroupState", "gameVisionModeType", "gameweaponReloadStatus",
            "GenericMessageNotificationResult", "GenericMessageNotificationType", "GenericNotificationType",
            "GOGRewardsSystemErrors", "GOGRewardsSystemStatus", "GrenadeDamageType", "grsHeistStatus",
            "HackingMinigameState", "HighlightContext", "HighlightMode", "hitFlag", "HitShape_Type", "HoverStatus",
            "HubMenuCharacterItems", "HubMenuCraftingItems", "HubMenuDatabaseItems", "HubMenuInventoryItems",
            "HubMenuItems", "HubVendorMenuItems", "HUDActorStatus", "HUDActorType", "HUDContext", "HUDState",
            "inkEButtonState", "inkEScrollDirection", "inkESliderDirection", "inkEToggleState", "inkIconResult",
            "inkLoadingScreenType", "inkMenuMode", "inkMenuState", "inkSelectorChangeDirection", "inputContextType",
            "InstanceState", "IntercomStatus", "InventoryItemAttachmentType", "InventoryModes",
            "InventoryPaperdollZoomArea", "InventoryTooltipDisplayContext", "ItemAdditionalInfoType",
            "ItemComparisonState", "ItemDisplayContext", "ItemDisplayType", "ItemFilterCategory", "ItemFilterType",
            "ItemLabelType", "ItemSortMode", "ItemViewModes", "JournalChangeType", "JournalNotifyOption", "LandingType",
            "LaserTargettingState", "MechanicalScanType", "meleeMoveDirection", "meleeQueuedAttack", "MessageViewType",
            "MinigameActionType", "ModuleState", "moveCirclingDirection", "moveExplorationType", "moveLineOfSight",
            "moveMovementType", "moveSecureFootingFailureReason", "moveSecureFootingFailureType", "NavGenAgentSize",
            "navNaviPositionType", "operationsMode", "OutcomeMessage", "PackageStatus", "panzerBootupUI",
            "PaperdollPositionAnimation", "PauseMenuAction", "PaymentStatus", "PerkMenuAttribute", "PersistenceSource",
            "physicsStateValue", "PlayerVisionModeControllerRefreshPolicyEnum", "PopupPosition", "ProgramEffect",
            "ProgramType", "ProximityProgressBarOrientation", "ProximityProgressBarState", "PuppetVehicleState",
            "QuantityPickerActionType", "questJournalAlignmentEventType", "questJournalSizeEventType",
            "questObjectInspectEventType", "questPhoneCallMode", "questPhoneCallPhase", "questPhoneStatus",
            "questPhoneTalkingState", "QuickSlotActionType", "QuickSlotItemType", "ReactionZones_Humanoid_Side",
            "Ref_1_3_3_Colors", "Ref_1_3_3_CustomSize_2", "Ref_2_3_3_Enum32Bit", "RequestType", "RipperdocFilter",
            "RipperdocModes", "ScannerDataType", "ScannerNetworkState", "ScannerObjectType", "scnDialogLineLanguage",
            "scnDialogLineType", "scnFastForwardMode", "scnPlayDirection", "scnPlaySpeed", "SecurityEventScopeSettings",
            "senseEShapeType", "SettingsType", "SignalType", "SignShape", "SignType", "SlotType",
            "TargetComponentFilterType", "TargetingSet", "telemetryInitalChoiceStage", "telemetryLevelGainReason",
            "ThrowType", "Tier2WalkType", "TSFMV", "TweakWeaponPose", "UIGameContext", "UIInGameNotificationType",
            "UIMenuNotificationType", "UIObjectiveEntryType", "vehicleAudioEventAction", "vehicleCameraType",
            "VehicleDoorInteractionState", "VehicleDoorState", "vehicleELightMode", "vehicleELightType",
            "vehicleEState", "vehicleExitDirection", "vehicleGarageState", "vehicleQuestUIEnable",
            "vehicleQuestWindowDestruction", "vehicleRaceUI", "vehicleSummonState", "VendorConfirmationPopupType",
            "VisionModePatternType", "VisualState", "WeaponPartType", "WorkspotConditionOperators",
            "WorkspotSlidingBehaviour", "WorkspotWeaponConditionEnum", "workWorkspotDebugMode",
            "worldgeometryaverageNormalDetectionHelperQueryStatus", "worldgeometryDescriptionQueryFlags",
            "worldgeometryDescriptionQueryStatus", "worldgeometryProbingStatus", "WorldMapTooltipType",
            "worldNavigationRequestStatus", "worldOffMeshConnectionType", "worldRainIntensity", "worldTrafficLightColor"
        };
    }
}