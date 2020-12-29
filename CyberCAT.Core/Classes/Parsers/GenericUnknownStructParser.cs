using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Text;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class GenericUnknownStructParser : INodeParser
    {
        public string ParsableNodeName { get; private set; }

        public string DisplayName { get; private set; }

        public Guid Guid { get; private set; }

        public GenericUnknownStructParser()
        {
            ParsableNodeName = Constants.NodeNames.SCRIPTABLE_SYSTEMS_CONTAINER;
            DisplayName = "Generic Unknown Struct Parser";
            Guid = System.Guid.Parse("{CA17650B-E151-4246-A5F4-7834342E3CD1}");
        }

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

            result.TotalLength = reader.ReadUInt32();
            result.Unknown1 = reader.ReadBytes(4);
            result.Unknown2 = reader.ReadUInt32();
            result.Unknown3 = reader.ReadBytes(4);

            var stringTableOffset = reader.ReadUInt32();
            var indexTableOffset = reader.ReadUInt32();
            var dataTableOffset = reader.ReadUInt32();

            if (result.Unknown2 == 16)
            {
                // only for ScriptableSystemsContainer
                var count1 = reader.ReadInt32();
                result.Unknown4 = reader.ReadBytes(count1 * 8);
            }

            var stringTablePosition = reader.BaseStream.Position + stringTableOffset;
            var indexTablePosition = reader.BaseStream.Position + indexTableOffset;
            var dataTablePosition = reader.BaseStream.Position + dataTableOffset;

            // start of stringIndexTable
            var stringList = new List<string>();
            var stringBasePosition = reader.BaseStream.Position;
            var stringOffset = reader.ReadUInt16();
            var count2 = stringOffset / 4 - 1; // there could be another count somewhere...
            reader.Skip(1);
            var stringLength = reader.ReadByte(); // string is null terminated?

            // length - 1 because null terminated...
            // could probably ignore the stringIndexTable and read null terminated strings, then you also don't net the hacky jump after this
            stringList.Add(ReadStringAtOffset(reader, stringBasePosition, stringOffset, stringLength - 1));

            // there could be another count somewhere...
            for (int i = 0; i < count2; i++)
            {
                stringOffset = reader.ReadUInt16();
                reader.Skip(1);
                stringLength = reader.ReadByte();
                stringList.Add(ReadStringAtOffset(reader, stringBasePosition, stringOffset, stringLength - 1));
            }

            // jump straight behind the last string
            reader.BaseStream.Position = stringBasePosition + stringOffset + stringLength;

            Debug.Assert(reader.BaseStream.Position == indexTablePosition);

            var count3 = (dataTableOffset - indexTableOffset) / 8;

            var pointerList = new List<KeyValuePair<uint, uint>>();
            for (int i = 0; i < count3; i++)
            {
                // probably counter, offset
                pointerList.Add(new KeyValuePair<uint, uint>(reader.ReadUInt32(), reader.ReadUInt32()));
            }

            Debug.Assert(reader.BaseStream.Position == dataTablePosition);

            /*int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
            Debug.Assert(readSize >= 0);
            result.TrailingBytes = reader.ReadBytes(readSize);*/

            var pos = reader.BaseStream.Position;
            for (int i = 0; i < pointerList.Count; i++)
            {
                var offset = pointerList[i].Value - pointerList[0].Value;

                var classEntry = new GenericUnknownStruct.ClassEntry();
                classEntry.Name = stringList[(int) pointerList[i].Key];

                int length = 0;
                if (i == pointerList.Count - 1)
                {
                    length = (int)(result.TotalLength - pointerList[i].Value);
                }
                else
                {
                    length = (int)(pointerList[i + 1].Value - pointerList[i].Value);
                }

                reader.BaseStream.Position = pos + offset;
                classEntry.Fields = ReadFields(reader, stringList);

                result.ClassList.Add(classEntry);
            }

            return result;
        }

        public List<GenericUnknownStruct.FieldEntry> ReadFields(BinaryReader reader, List<string> stringList)
        {
            var fieldList = new List<GenericUnknownStruct.FieldEntry>();

            var pos = reader.BaseStream.Position;
            var fieldCount = reader.ReadUInt16();
            for (int i = 0; i < fieldCount; i++)
            {
                var field = new GenericUnknownStruct.FieldEntry();

                /*var pos2 = reader.BaseStream.Position;
                var bytes = reader.ReadBytes(6);
                field.Debug = BitConverter.ToString(bytes).Replace("-", " ");
                reader.BaseStream.Position = pos2;*/

                var s = reader.ReadUInt16();
                field.Name = stringList[s];
                s = reader.ReadUInt16();
                field.Type = stringList[s];
                field.Offset = reader.ReadUInt32();

                fieldList.Add(field);
            }

            foreach (var field in fieldList)
            {
                reader.BaseStream.Position = pos + field.Offset;
                var typeParts = field.Type.Split(':');
                field.Value = ReadValue(reader, stringList, typeParts, 0);
            }

            return fieldList;
        }

        public object ReadValue(BinaryReader reader, List<string> stringList, string[] typeParts, int index)
        {
            var dataType = typeParts[index];
            switch (dataType)
            {
                case "array":
                    object result = new List<object>();
                    var arraySize = reader.ReadUInt32();
                    for (int i = 0; i < arraySize; i++)
                    {
                        ((List<object>)result).Add(ReadValue(reader, stringList, typeParts, index + 1));
                    }
                    return result;

                case "Int32":
                    return reader.ReadInt32();

                case "Uint32":
                case "handle":
                    return reader.ReadUInt32();

                case "Bool":
                    return reader.ReadByte() != 0;

                case "Uint64":
                case "TweakDBID":
                    return reader.ReadUInt64();

                case "Float":
                    return reader.ReadSingle();

                // enums
                case "ActiveMode":
                case "ActorVisibilityStatus":
                case "AdditionalTraceType":
                case "AIactionParamsPackageTypes":
                case "AIArgumentType":
                case "AIbehaviorCompletionStatus":
                case "AIbehaviorConditionOutcomes":
                case "AIbehaviorUpdateOutcome":
                case "AICombatSectorType":
                case "AICombatSpaceSize":
                case "AICommandState":
                case "AICoverExposureMethod":
                case "AIEExecutionOutcome":
                case "AIEInterruptionOutcome":
                case "aimTypeEnum":
                case "AIParameterizationType":
                case "AIReactionCountOutcome":
                case "AISignalFlags":
                case "AISquadType":
                case "AIThreatPersistenceStatus":
                case "AITrackedStatusType":
                case "AIUninterruptibleActionType":
                case "animAimState":
                case "animCoverAction":
                case "animCoverState":
                case "animHitReactionType":
                case "animLookAtChestMode":
                case "animLookAtEyesMode":
                case "animLookAtHeadMode":
                case "animLookAtLeftHandedMode":
                case "animLookAtLimitDegreesType":
                case "animLookAtLimitDistanceType":
                case "animLookAtRightHandedMode":
                case "animLookAtStatus":
                case "animLookAtStyle":
                case "animLookAtTwoHandedMode":
                case "animNPCVehicleDeathType":
                case "animStanceState":
                case "animWeaponOwnerType":
                case "AttitudeChange":
                case "AttributeButtonState":
                case "audioAudioEventFlags":
                case "audioEventActionType":
                case "BlacklistReason":
                case "braindanceVisionMode":
                case "ButtonStatus":
                case "CharacterScreenType":
                case "ClueState":
                case "CodexCategoryType":
                case "CodexDataSource":
                case "CodexImageType":
                case "coverLeanDirection":
                case "CrafringMaterialItemHighlight":
                case "CraftingCommands":
                case "CraftingInfoType":
                case "CraftingMode":
                case "CraftingNotificationType":
                case "CustomButtonType":
                case "CustomWeaponWheelSlot":
                case "CyberwareInfoType":
                case "CyberwareScreenType":
                case "DamageEffectDisplayType":
                case "damageSystemLogFlags":
                case "DerivedFilterResult":
                case "DeviceStimType":
                case "DMGPipelineType":
                case "DronePose":
                case "DropdownDisplayContext":
                case "DropdownItemDirection":
                case "DropPointPackageStatus":
                case "EActionContext":
                case "EActionInactivityReson":
                case "EActionsSequencerMode":
                case "EActionType":
                case "EActivationState":
                case "EAIActionPhase":
                case "EAIActionState":
                case "EAIActionTarget":
                case "EAIAttitude":
                case "EAIBackgroundCombatStep":
                case "EAICombatPreset":
                case "EAICoverAction":
                case "EAICoverActionDirection":
                case "EAIDismembermentBodyPart":
                case "EAIGateEventFlags":
                case "EAIGateSignalFlags":
                case "EAIHitBodyPart":
                case "EAIHitDirection":
                case "EAIHitIntensity":
                case "EAIHitSource":
                case "EAILastHitReactionPlayed":
                case "EAimAssistLevel":
                case "EAIPlayerSquadOrder":
                case "EAIRole":
                case "EAIShootingPatternRange":
                case "EAISquadAction":
                case "EAISquadChoiceAlgorithm":
                case "EAISquadRing":
                case "EAISquadTactic":
                case "EAISquadVerb":
                case "EAITargetType":
                case "EAIThreatCalculationType":
                case "EAITicketStatus":
                case "EAllowedTo":
                case "EAnimationType":
                case "EArgumentType":
                case "EAttackType":
                case "EAxisType":
                case "EBarkList":
                case "EBeamStyle":
                case "EBinkOperationType":
                case "EBOOL":
                case "EBreachOrigin":
                case "EBroadcasteingType":
                case "ECallbackExpressionActions":
                case "ECameraDirectionFunctionalTestsUtil":
                case "ECarryState":
                case "ECartOperationResult":
                case "ECentaurShieldState":
                case "ECLSForcedState":
                case "ECompanionDistancePreset":
                case "ECompanionPositionPreset":
                case "ECompareOp":
                case "EComparisonOperator":
                case "EComparisonType":
                case "EComponentOperation":
                case "EComputerAnimationState":
                case "EComputerMenuType":
                case "EConclusionQuestState":
                case "ECooldownGameControllerMode":
                case "ECooldownIndicatorState":
                case "ECoverSpecialAction":
                case "ECraftingIconPositioning":
                case "EDeathType":
                case "EDebuggerColor":
                case "EDeviceChallengeAttribute":
                case "EDeviceChallengeSkill":
                case "EDeviceDurabilityState":
                case "EDeviceDurabilityType":
                case "EDeviceStatus":
                case "EDocumentType":
                case "EDodgeMovementInput":
                case "EDoorOpeningType":
                case "EDoorSkillcheckSide":
                case "EDoorStatus":
                case "EDoorTriggerSide":
                case "EDoorType":
                case "EDownedType":
                case "EDPadSlot":
                case "EDrillMachineRewireState":
                case "EEffectOperationType":
                case "EEquipmentSetType":
                case "EEquipmentSide":
                case "EEquipmentState":
                case "EExplosiveAdditionalGameEffectType":
                case "EFastTravelSystemInstruction":
                case "EFastTravelTriggerType":
                case "EFilterType":
                case "EFocusClueInvestigationState":
                case "EFocusForcedHighlightType":
                case "EFocusOutlineType":
                case "EForcedElevatorArrowsState":
                case "EGameplayChallengeLevel":
                case "EGameplayRole":
                case "EGameSessionDataType":
                case "EGenericNotificationPriority":
                case "EGlitchState":
                case "EGravityType":
                case "EGrenadeType":
                case "EHandEquipSlot":
                case "EHitReactionMode":
                case "EHitReactionZone":
                case "EHitShapeType":
                case "EHotkey":
                case "EHotkeyRequestType":
                case "EHudAvatarMode":
                case "EHudPhoneFunction":
                case "EHudPhoneVisibility":
                case "EIndustrialArmAnimations":
                case "EInitReactionAnim":
                case "EInkAnimationPlaybackOption":
                case "EInputCustomKey":
                case "EInputKey":
                case "EInventoryComboBoxMode":
                case "EInventoryDataStatDisplayType":
                case "EItemOperationType":
                case "EItemSlotCheckType":
                case "EJuryrigTrapState":
                case "EKnockdownStates":
                case "ELastUsed":
                case "ELauncherActionType":
                case "ELaunchMode":
                case "ELayoutType":
                case "ELightSequenceStage":
                case "ELightSwitchRandomizerType":
                case "ELinkType":
                case "ELogicOperator":
                case "ELogType":
                case "EMagazineAmmoState":
                case "EMappinDisplayMode":
                case "EMappinVisualState":
                case "EMathOperationType":
                case "EMathOperator":
                case "EMeasurementSystem":
                case "EMeasurementUnit":
                case "EMeleeAttacks":
                case "EMeleeAttackType":
                case "EMissileRainPhase":
                case "EMoveAssistLevel":
                case "EMovementDirection":
                case "ENetworkRelation":
                case "ENeutralizeType":
                case "ENPCPhaseState":
                case "ENPCTelemetryData":
                case "entAttachmentTarget":
                case "entAudioDismembermentPart":
                case "EntityNotificationType":
                case "entragdollActivationRequestType":
                case "EOperationClassType":
                case "EOutlineType":
                case "EPaymentSchedule":
                case "EPermissionSource":
                case "EPersonalLinkConnectionStatus":
                case "EPersonalLinkSlotSide":
                case "EPingType":
                case "EPlayerMovementDirection":
                case "EPlaystyle":
                case "EPlaystyleType":
                case "EPowerDifferential":
                case "EPreventionDebugProcessReason":
                case "EPreventionHeatStage":
                case "EPreventionPsychoLogicType":
                case "EPreventionSystemInstruction":
                case "EPriority":
                case "EProgressBarContext":
                case "EProgressBarType":
                case "EQuestFilterType":
                case "EQuestVehicleDoorState":
                case "EQuestVehicleWindowState":
                case "EquipmentManipulationAction":
                case "EquipmentManipulationRequestSlot":
                case "EquipmentManipulationRequestType":
                case "EquipmentPriority":
                case "ERadialMode":
                case "ERadioStationList":
                case "EReactionValue":
                case "ERenderingPlane":
                case "ERentStatus":
                case "EReprimandInstructions":
                case "ERevealDurationType":
                case "ERevealPlayerType":
                case "ERevealState":
                case "EScreenRatio":
                case "ESecurityAccessLevel":
                case "ESecurityAreaType":
                case "ESecurityGateEntranceType":
                case "ESecurityGateResponseType":
                case "ESecurityGateScannerIssueType":
                case "ESecurityGateStatus":
                case "ESecurityNotificationType":
                case "ESecuritySystemState":
                case "ESecurityTurretStatus":
                case "ESecurityTurretType":
                case "ESensorDeviceStates":
                case "ESensorDeviceWakeState":
                case "EShouldChangeAttitude":
                case "ESlotState":
                case "ESmartBulletPhase":
                case "ESmartHousePreset":
                case "ESoundStatusEffects":
                case "ESpaceFillMode":
                case "EStatProviderDataSource":
                case "EStatusEffectBehaviorType":
                case "EStatusEffects":
                case "EstatusEffectsState":
                case "ESurveillanceCameraState":
                case "ESurveillanceCameraStatus":
                case "ESwitchAction":
                case "ESystems":
                case "ETakedownActionType":
                case "ETakedownBossName":
                case "ETargetManagerAnimGraphState":
                case "ETauntType":
                case "ETelemetryData":
                case "EToggleActivationTypeComputer":
                case "EToggleOperationType":
                case "ETooltipsStyle":
                case "ETransformAnimationOperationType":
                case "ETransitionMode":
                case "ETrap":
                case "ETrapEffects":
                case "ETriggerOperationType":
                case "ETVChannel":
                case "ETweakAINodeType":
                case "EUIActionState":
                case "EUIStealthIconType":
                case "EUploadProgramState":
                case "EVarDBMode":
                case "EVehicleDoor":
                case "EVehicleWindowState":
                case "EVendorMode":
                case "EViabilityDecision":
                case "EVirtualSystem":
                case "EVisualizerActivityState":
                case "EVisualizerType":
                case "EWeaponNamesList":
                case "EWidgetPlacementType":
                case "EWidgetState":
                case "EWindowBlindersStates":
                case "EWorkspotOperationType":
                case "EWorldMapView":
                case "EWoundedBodyPart":
                case "ExplosiveTriggerDeviceLaserState":
                case "ExtraEffect":
                case "Ft_Result":
                case "Ft_TakedownStage":
                case "Ft_TakedownType":
                case "FTNpcMountingState":
                case "FTScriptState":
                case "FunctionalTestsResultCode":
                case "gameaudioeventsSurfaceDirection":
                case "gamecheatsystemFlag":
                case "gameCityAreaType":
                case "gameCombinedStatOperation":
                case "gameContactType":
                case "gameCoverHeight":
                case "gameDamageCallbackType":
                case "gameDamagePipelineStage":
                case "gamedataAchievement":
                case "gamedataAffiliation":
                case "gamedataAIActionSecurityAreaType":
                case "gamedataAIActionSecurityNotificationType":
                case "gamedataAIActionTarget":
                case "gamedataAIActionType":
                case "gamedataAIAdditionalTraceType":
                case "gamedataAIDirectorEntryStartType":
                case "gamedataAIExposureMethodType":
                case "gamedataAimAssistType":
                case "gamedataAIRingType":
                case "gamedataAIRole":
                case "gamedataAISmartCompositeType":
                case "gamedataAISquadType":
                case "gamedataAITacticType":
                case "gamedataAITicketType":
                case "gamedataArchetypeType":
                case "gamedataAttackSubtype":
                case "gamedataAttackType":
                case "gamedataBuildType":
                case "gamedataChargeStep":
                case "gamedataChoiceCaptionPartType":
                case "gamedataCompanionDistancePreset":
                case "gamedataConsumableBaseName":
                case "gamedataConsumableType":
                case "gamedataDamageType":
                case "gamedataDefenseMode":
                case "gamedataDevelopmentPointType":
                case "gamedataDistrict":
                case "gamedataEquipmentArea":
                case "gamedataEthnicity":
                case "gamedataFxAction":
                case "gamedataFxActionType":
                case "gamedataGender":
                case "gamedataGrenadeDeliveryMethodType":
                case "gamedataHitPrereqConditionType":
                case "gamedataImprovementRelation":
                case "gamedataItemCategory":
                case "gamedataItemStructure":
                case "gamedataItemType":
                case "gamedataLifePath":
                case "gamedataLocomotionMode":
                case "gamedataMappinPhase":
                case "gamedataMappinVariant":
                case "gamedataMeleeAttackDirection":
                case "gamedataMetaQuest":
                case "gamedataMovementType":
                case "gamedataNPCBehaviorState":
                case "gamedataNPCHighLevelState":
                case "gamedataNPCQuestAffiliation":
                case "gamedataNPCRarity":
                case "gamedataNPCStanceState":
                case "gamedataNPCType":
                case "gamedataNPCUpperBodyState":
                case "gamedataObjectActionReference":
                case "gamedataObjectActionType":
                case "gamedataOutput":
                case "gamedataParentAttachmentType":
                case "gamedataPerkArea":
                case "gamedataPerkType":
                case "gamedataPerkUtility":
                case "gamedataPingType":
                case "gamedataPlayerBuild":
                case "gamedataPlayerPossesion":
                case "gamedataProficiencyType":
                case "gamedataProjectileLaunchMode":
                case "gamedataProjectileOnCollisionAction":
                case "gamedataQuality":
                case "gamedataReactionPresetType":
                case "gamedataSenseObjectType":
                case "gamedataSpawnableObjectPriority":
                case "gamedataStatPoolType":
                case "gamedataStatType":
                case "gamedataStatusEffectAIBehaviorFlag":
                case "gamedataStatusEffectAIBehaviorType":
                case "gamedataStatusEffectType":
                case "gamedataStatusEffectVariation":
                case "gamedataStimPriority":
                case "gamedataStimPropagation":
                case "gamedataStimType":
                case "gamedataSubCharacter":
                case "gamedataTrackingMode":
                case "gamedataTraitType":
                case "gamedataTriggerMode":
                case "gamedataUICondition":
                case "gamedataUIIconCensorFlag":
                case "gamedataUINameplateDisplayType":
                case "gamedataVehicleManufacturer":
                case "gamedataVehicleModel":
                case "gamedataVehicleType":
                case "gamedataVendorType":
                case "gamedataWeaponEvolution":
                case "gamedataWeaponManufacturer":
                case "gamedataWorkspotActionType":
                case "gamedataWorkspotCategory":
                case "gamedataWorkspotReactionType":
                case "gamedataWorldMapFilter":
                case "gameDebugViewETextAlignment":
                case "gamedeviceActionPropertyFlags":
                case "gamedeviceRequestType":
                case "gameDifficulty":
                case "gameDismBodyPart":
                case "gameDismWoundType":
                case "gameEActionStatus":
                case "gameEContinuousMode":
                case "gameEEquipmentManagerState":
                case "gameEnemyStealthAwarenessState":
                case "gameEntitySpawnerEventType":
                case "gameEPrerequisiteType":
                case "gameEquipAnimationType":
                case "gameEStatFlags":
                case "gameeventsDeathDirection":
                case "gameGodModeType":
                case "gameGrenadeThrowStartType":
                case "gameinfluenceCollisionTestOutcome":
                case "gameinfluenceTestLineResult":
                case "gameinputActionType":
                case "gameinteractionsBumpIntensity":
                case "gameinteractionsBumpLocation":
                case "gameinteractionsBumpSide":
                case "gameinteractionsChoiceType":
                case "gameinteractionsEInteractionEventType":
                case "gameinteractionsELootChoiceType":
                case "gameinteractionsELootVisualiserControlOperation":
                case "gameinteractionsReactionState":
                case "gameItemEquipContexts":
                case "gameItemUnequipContexts":
                case "gameJournalBriefingContentType":
                case "gameJournalEntryState":
                case "gameJournalListenerType":
                case "gameJournalQuestType":
                case "gameKillType":
                case "gameLoSMode":
                case "gamemappinsMappinTargetType":
                case "gamemappinsVerticalPositioning":
                case "gameMessageSender":
                case "gameMountingObjectType":
                case "gameMountingRelationshipType":
                case "gameMountingSlotRole":
                case "gameMovingPlatformLoopType":
                case "gameMovingPlatformMovementInitializationType":
                case "gamePlatformMovementState":
                case "gamePlayerCoverDirection":
                case "gamePlayerCoverMode":
                case "gamePlayerObstacleSystemQueryType":
                case "gamePlayerStateMachine":
                case "GameplayTier":
                case "gameprojectileELaunchMode":
                case "gameprojectileOnCollisionAction":
                case "gamePSMBodyCarrying":
                case "gamePSMBodyCarryingLocomotion":
                case "gamePSMBodyCarryingStyle":
                case "gamePSMCombat":
                case "gamePSMCombatGadget":
                case "gamePSMCrosshairStates":
                case "gamePSMDetailedBodyDisposal":
                case "gamePSMDetailedLocomotionStates":
                case "gamePSMFallStates":
                case "gamePSMHighLevel":
                case "gamePSMLandingState":
                case "gamePSMLeftHandCyberware":
                case "gamePSMLocomotionStates":
                case "gamePSMMelee":
                case "gamePSMMeleeWeapon":
                case "gamePSMNanoWireLaunchMode":
                case "gamePSMRangedWeaponStates":
                case "gamePSMReaction":
                case "gamePSMStamina":
                case "gamePSMSwimming":
                case "gamePSMTakedown":
                case "gamePSMTimeDilation":
                case "gamePSMUIState":
                case "gamePSMUpperBodyStates":
                case "gamePSMVehicle":
                case "gamePSMVision":
                case "gamePSMVisionDebug":
                case "gamePSMVitals":
                case "gamePSMWeaponStates":
                case "gamePSMWhip":
                case "gamePSMWorkspotState":
                case "gamePSMZones":
                case "gameReprimandMappinAnimationState":
                case "gameSaveLockReason":
                case "gameScanningMode":
                case "gameScanningState":
                case "gameSceneAnimationMotionActionParamsPlacementMode":
                case "gameScriptedBlackboardStorage":
                case "gameSharedInventoryTag":
                case "gamesmartGunTargetState":
                case "gamestateMachineParameterAspect":
                case "gameStatModifierType":
                case "gameStatObjectsRelation":
                case "gameStatPoolModificationTypes":
                case "gameStoryTier":
                case "gametargetingSystemETargetFilterStatus":
                case "gameTelemetryDamageSituation":
                case "gameTickableEventState":
                case "gameTutorialBracketType":
                case "gameuiAuthorisationNotificationType":
                case "gameuiCharacterCustomizationPart":
                case "gameuiDamageDigitsMode":
                case "gameuiDamageDigitsStickingMode":
                case "gameuiDamageIndicatorMode":
                case "gameuiEBraindanceLayer":
                case "gameuiEClueDescriptorMode":
                case "gameuiEWorldMapDistrictView":
                case "gameuiHitType":
                case "gameuiMappinGroupState":
                case "gameVisionModeType":
                case "gameweaponReloadStatus":
                case "GenericMessageNotificationResult":
                case "GenericMessageNotificationType":
                case "GenericNotificationType":
                case "GOGRewardsSystemErrors":
                case "GOGRewardsSystemStatus":
                case "GrenadeDamageType":
                case "grsHeistStatus":
                case "HackingMinigameState":
                case "HighlightContext":
                case "HighlightMode":
                case "hitFlag":
                case "HitShape_Type":
                case "HoverStatus":
                case "HubMenuCharacterItems":
                case "HubMenuCraftingItems":
                case "HubMenuDatabaseItems":
                case "HubMenuInventoryItems":
                case "HubMenuItems":
                case "HubVendorMenuItems":
                case "HUDActorStatus":
                case "HUDActorType":
                case "HUDContext":
                case "HUDState":
                case "inkEButtonState":
                case "inkEScrollDirection":
                case "inkESliderDirection":
                case "inkEToggleState":
                case "inkIconResult":
                case "inkLoadingScreenType":
                case "inkMenuMode":
                case "inkMenuState":
                case "inkSelectorChangeDirection":
                case "inputContextType":
                case "InstanceState":
                case "IntercomStatus":
                case "InventoryItemAttachmentType":
                case "InventoryModes":
                case "InventoryPaperdollZoomArea":
                case "InventoryTooltipDisplayContext":
                case "ItemAdditionalInfoType":
                case "ItemComparisonState":
                case "ItemDisplayContext":
                case "ItemDisplayType":
                case "ItemFilterCategory":
                case "ItemFilterType":
                case "ItemLabelType":
                case "ItemSortMode":
                case "ItemViewModes":
                case "JournalChangeType":
                case "JournalNotifyOption":
                case "LandingType":
                case "LaserTargettingState":
                case "MechanicalScanType":
                case "meleeMoveDirection":
                case "meleeQueuedAttack":
                case "MessageViewType":
                case "MinigameActionType":
                case "ModuleState":
                case "moveCirclingDirection":
                case "moveExplorationType":
                case "moveLineOfSight":
                case "moveMovementType":
                case "moveSecureFootingFailureReason":
                case "moveSecureFootingFailureType":
                case "NavGenAgentSize":
                case "navNaviPositionType":
                case "operationsMode":
                case "OutcomeMessage":
                case "PackageStatus":
                case "panzerBootupUI":
                case "PaperdollPositionAnimation":
                case "PauseMenuAction":
                case "PaymentStatus":
                case "PerkMenuAttribute":
                case "PersistenceSource":
                case "physicsStateValue":
                case "PlayerVisionModeControllerRefreshPolicyEnum":
                case "PopupPosition":
                case "ProgramEffect":
                case "ProgramType":
                case "ProximityProgressBarOrientation":
                case "ProximityProgressBarState":
                case "PuppetVehicleState":
                case "QuantityPickerActionType":
                case "questJournalAlignmentEventType":
                case "questJournalSizeEventType":
                case "questObjectInspectEventType":
                case "questPhoneCallMode":
                case "questPhoneCallPhase":
                case "questPhoneStatus":
                case "questPhoneTalkingState":
                case "QuickSlotActionType":
                case "QuickSlotItemType":
                case "ReactionZones_Humanoid_Side":
                case "Ref_1_3_3_Colors":
                case "Ref_1_3_3_CustomSize_2":
                case "Ref_2_3_3_Enum32Bit":
                case "RequestType":
                case "RipperdocFilter":
                case "RipperdocModes":
                case "ScannerDataType":
                case "ScannerNetworkState":
                case "ScannerObjectType":
                case "scnDialogLineLanguage":
                case "scnDialogLineType":
                case "scnFastForwardMode":
                case "scnPlayDirection":
                case "scnPlaySpeed":
                case "SecurityEventScopeSettings":
                case "senseEShapeType":
                case "SettingsType":
                case "SignalType":
                case "SignShape":
                case "SignType":
                case "SlotType":
                case "TargetComponentFilterType":
                case "TargetingSet":
                case "telemetryInitalChoiceStage":
                case "telemetryLevelGainReason":
                case "ThrowType":
                case "Tier2WalkType":
                case "TSFMV":
                case "TweakWeaponPose":
                case "UIGameContext":
                case "UIInGameNotificationType":
                case "UIMenuNotificationType":
                case "UIObjectiveEntryType":
                case "vehicleAudioEventAction":
                case "vehicleCameraType":
                case "VehicleDoorInteractionState":
                case "VehicleDoorState":
                case "vehicleELightMode":
                case "vehicleELightType":
                case "vehicleEState":
                case "vehicleExitDirection":
                case "vehicleGarageState":
                case "vehicleQuestUIEnable":
                case "vehicleQuestWindowDestruction":
                case "vehicleRaceUI":
                case "vehicleSummonState":
                case "VendorConfirmationPopupType":
                case "VisionModePatternType":
                case "VisualState":
                case "WeaponPartType":
                case "WorkspotConditionOperators":
                case "WorkspotSlidingBehaviour":
                case "WorkspotWeaponConditionEnum":
                case "workWorkspotDebugMode":
                case "worldgeometryaverageNormalDetectionHelperQueryStatus":
                case "worldgeometryDescriptionQueryFlags":
                case "worldgeometryDescriptionQueryStatus":
                case "worldgeometryProbingStatus":
                case "WorldMapTooltipType":
                case "worldNavigationRequestStatus":
                case "worldOffMeshConnectionType":
                case "worldRainIntensity":
                case "worldTrafficLightColor":
                    return reader.ReadUInt16();

                case "CC_Debug":
                    var pos2 = reader.BaseStream.Position;
                    var bytes = reader.ReadBytes(128);
                    var hex = BitConverter.ToString(bytes).Replace("-", " ");
                    reader.BaseStream.Position = pos2;
                    try
                    {
                        var t1 = ReadFields(reader, stringList);
                    }
                    catch (Exception e)
                    {
                        throw;
                    }
                    return null;

                // unknown, 2 bytes
                case "CName":
                case "gameStatIDType":
                case "gameEHotkey":
                    // what the hell is CName
                    return reader.ReadBytes(2);

                default:
                    return ReadFields(reader, stringList);
            }
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            throw new NotImplementedException();
            /*byte[] result;
            var data = (GenericUnknownStruct)node.Value;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(node.Id);
                    writer.Write(new byte[] { 0, 0, 0, 0 });
                    writer.Write(data.Unknown1);
                    writer.Write(data.Unknown2);
                    writer.Write(data.Unknown3);
                    writer.Write(new byte[12]);

                    if (data.Unknown2 == 16)
                    {
                        var count = data.Unknown4.Length / 8;
                        writer.Write(count);
                        writer.Write(data.Unknown4);
                    }

                    var pos = writer.BaseStream.Position;

                    var offset = (short)(data.StringList.Count * 4);
                    foreach (var str in data.StringList)
                    {
                        writer.Write(offset);
                        writer.Write(new byte[] { 0 });
                        writer.Write((byte)(str.Length + 1));
                        offset += (short)(str.Length + 1);
                    }

                    var stringTableOffset = writer.BaseStream.Position - pos;

                    foreach (var str in data.StringList)
                    {
                        var bytes = Encoding.ASCII.GetBytes(str);
                        writer.Write(bytes);
                        writer.Write(new byte[] { 0 });
                    }

                    var indexTableOffset = writer.BaseStream.Position - pos;

                    foreach (var pair in data.PointerList)
                    {
                        writer.Write(pair.Key);
                        writer.Write(pair.Value);
                    }

                    var dataTableOffset = writer.BaseStream.Position - pos;

                    writer.Write(data.TrailingBytes);

                    writer.BaseStream.Position = 4;
                    writer.Write((int)writer.BaseStream.Length - 8);
                    writer.BaseStream.Position += 12;
                    writer.Write((int)stringTableOffset);
                    writer.Write((int)indexTableOffset);
                    writer.Write((int)dataTableOffset);
                }
                result = stream.ToArray();
            }
            return result;*/
        }
    }
}