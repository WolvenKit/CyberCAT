using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ApartmentScreenControllerPS")]
    public class ApartmentScreenControllerPS : LcdScreenControllerPS
    {
        [RealName("initialRentStatus")]
        public DumpedEnums.ERentStatus? InitialRentStatus { get; set; }
        
        [RealName("overdueMessageRecordID")]
        [RealType("TweakDBID")]
        public TweakDbId OverdueMessageRecordID { get; set; }
        
        [RealName("paidMessageRecordID")]
        [RealType("TweakDBID")]
        public TweakDbId PaidMessageRecordID { get; set; }
        
        [RealName("evictionMessageRecordID")]
        [RealType("TweakDBID")]
        public TweakDbId EvictionMessageRecordID { get; set; }
        
        [RealName("paymentSchedule")]
        public DumpedEnums.EPaymentSchedule? PaymentSchedule { get; set; }
        
        [RealName("randomizeInitialOverdue")]
        [RealType("Bool")]
        public bool RandomizeInitialOverdue { get; set; }
        
        [RealName("initialOverdue")]
        [RealType("Int32")]
        public int InitialOverdue { get; set; }
        
        [RealName("allowAutomaticRentStatusChange")]
        [RealType("Bool")]
        public bool AllowAutomaticRentStatusChange { get; set; }
        
        [RealName("maxDays")]
        [RealType("Int32")]
        public int MaxDays { get; set; }
        
        [RealName("currentOverdue")]
        [RealType("Int32")]
        public int CurrentOverdue { get; set; }
        
        [RealName("isInitialRentStateSet")]
        [RealType("Bool")]
        public bool IsInitialRentStateSet { get; set; }
        
        [RealName("currentRentStatus")]
        public DumpedEnums.ERentStatus? CurrentRentStatus { get; set; }
        
        [RealName("lastStatusChangeDay")]
        [RealType("Int32")]
        public int LastStatusChangeDay { get; set; }
    }
}
