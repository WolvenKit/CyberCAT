using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ScriptedPuppet")]
    public class ScriptedPuppet : GamePuppet
    {
        [RealName("aiController")]
        public Handle<AIHumanComponent> AiController { get; set; }
        
        [RealName("movePolicies")]
        public Handle<MovePoliciesComponent> MovePolicies { get; set; }
        
        [RealName("aiStateHandlerComponent")]
        public Handle<AIPhaseStateEventHandlerComponent> AiStateHandlerComponent { get; set; }
        
        [RealName("hitReactionComponent")]
        public Handle<HitReactionComponent> HitReactionComponent { get; set; }
        
        [RealName("signalHandlerComponent")]
        public Handle<AISignalHandlerComponent> SignalHandlerComponent { get; set; }
        
        [RealName("reactionComponent")]
        public Handle<ReactionManagerComponent> ReactionComponent { get; set; }
        
        [RealName("dismembermentComponent")]
        public Handle<GameDismembermentComponent> DismembermentComponent { get; set; }
        
        [RealName("hitRepresantation")]
        public Handle<EntSlotComponent> HitRepresantation { get; set; }
        
        [RealName("interactionComponent")]
        public Handle<GameinteractionsComponent> InteractionComponent { get; set; }
        
        [RealName("slotComponent")]
        public Handle<EntSlotComponent> SlotComponent { get; set; }
        
        [RealName("sensesComponent")]
        public Handle<SenseComponent> SensesComponent { get; set; }
        
        [RealName("visibleObjectComponent")]
        public Handle<SenseVisibleObjectComponent> VisibleObjectComponent { get; set; }
        
        [RealName("sensorObjectComponent")]
        public Handle<SenseSensorObjectComponent> SensorObjectComponent { get; set; }
        
        [RealName("targetTrackerComponent")]
        public Handle<AITargetTrackerComponent> TargetTrackerComponent { get; set; }
        
        [RealName("targetingComponentsArray")]
        public Handle<GameTargetingComponent>[] TargetingComponentsArray { get; set; }
        
        [RealName("statesComponent")]
        public Handle<NPCStatesComponent> StatesComponent { get; set; }
        
        [RealName("fxResourceMapper")]
        public Handle<FxResourceMapperComponent> FxResourceMapper { get; set; }
        
        [RealName("linkedStatusEffect")]
        public LinkedStatusEffect LinkedStatusEffect { get; set; }
        
        [RealName("resourceLibraryComponent")]
        public Handle<ResourceLibraryComponent> ResourceLibraryComponent { get; set; }
        
        [RealName("crowdMemberComponent")]
        public Handle<CrowdMemberBaseComponent> CrowdMemberComponent { get; set; }
        
        [RealName("inventoryComponent")]
        public Handle<GameInventory> InventoryComponent { get; set; }
        
        [RealName("objectSelectionComponent")]
        public Handle<AIObjectSelectionComponent> ObjectSelectionComponent { get; set; }
        
        [RealName("transformHistoryComponent")]
        public Handle<EntTransformHistoryComponent> TransformHistoryComponent { get; set; }
        
        [RealName("animationControllerComponent")]
        public Handle<EntAnimationControllerComponent> AnimationControllerComponent { get; set; }
        
        [RealName("bumpComponent")]
        public Handle<GameinfluenceBumpComponent> BumpComponent { get; set; }
        
        [RealName("isCrowd")]
        public bool IsCrowd { get; set; }
        
        [RealName("incapacitatedOnAttach")]
        public bool IncapacitatedOnAttach { get; set; }
        
        [RealName("isIconic")]
        public bool IsIconic { get; set; }
        
        [RealName("combatHUDManager")]
        public Handle<CombatHUDManager> CombatHUDManager { get; set; }
        
        [RealName("exposePosition")]
        public bool ExposePosition { get; set; }
        
        [RealName("puppetStateBlackboard")]
        public Handle<GameIBlackboard> PuppetStateBlackboard { get; set; }
        
        [RealName("customBlackboard")]
        public Handle<GameIBlackboard> CustomBlackboard { get; set; }
        
        [RealName("securityAreaCallbackID")]
        public uint SecurityAreaCallbackID { get; set; }
        
        [RealName("customAIComponents")]
        public Handle<AICustomComponents>[] CustomAIComponents { get; set; }
        
        [RealName("listeners")]
        public Handle<PuppetListener>[] Listeners { get; set; }
        
        [RealName("securitySupportListener")]
        public Handle<SecuritySupportListener> SecuritySupportListener { get; set; }
        
        [RealName("shouldBeRevealedStorage")]
        public Handle<RevealRequestsStorage> ShouldBeRevealedStorage { get; set; }
        
        [RealName("inputProcessed")]
        public bool InputProcessed { get; set; }
        
        [RealName("targetedBlackBoard")]
        public Handle<GameIBlackboard> TargetedBlackBoard { get; set; }
        
        [RealName("shouldSpawnBloodPuddle")]
        public bool ShouldSpawnBloodPuddle { get; set; }
        
        [RealName("bloodPuddleSpawned")]
        public bool BloodPuddleSpawned { get; set; }
        
        [RealName("skipDeathAnimation")]
        public bool SkipDeathAnimation { get; set; }
        
        [RealName("hitHistory")]
        public Handle<HitHistory> HitHistory { get; set; }
        
        [RealName("currentWorkspotTags")]
        public CName[] CurrentWorkspotTags { get; set; }
        
        [RealName("lootQuality")]
        public DumpedEnums.gamedataQuality? LootQuality { get; set; }
        
        [RealName("hasQuestItems")]
        public bool HasQuestItems { get; set; }
        
        [RealName("activeQualityRangeInteraction")]
        public CName ActiveQualityRangeInteraction { get; set; }
        
        [RealName("weakspotComponent")]
        public Handle<GameWeakspotComponent> WeakspotComponent { get; set; }
        
        [RealName("highlightData")]
        public Handle<FocusForcedHighlightData> HighlightData { get; set; }
        
        [RealName("killer")]
        public EntEntity Killer { get; set; }
        
        [RealName("objectActionsCallbackCtrl")]
        public Handle<GameObjectActionsCallbackController> ObjectActionsCallbackCtrl { get; set; }
        
        [RealName("isActiveCached")]
        public AIUtilsCachedBoolValue IsActiveCached { get; set; }
        
        [RealName("isCyberpsycho")]
        public bool IsCyberpsycho { get; set; }
        
        [RealName("isCivilian")]
        public bool IsCivilian { get; set; }
        
        [RealName("isPolice")]
        public bool IsPolice { get; set; }
        
        [RealName("isGanger")]
        public bool IsGanger { get; set; }
        
        [RealName("attemptedShards")]
        public GameItemID[] AttemptedShards { get; set; }
    }
}
