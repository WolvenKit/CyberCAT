using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("ApartmentScreenControllerPS")]
    public class ApartmentScreenControllerPS : LcdScreenControllerPS
    {
        [RealName("initialRentStatus")]
        public DumpedEnums.ERentStatus? InitialRentStatus { get; set; }
        
        [RealName("overdueMessageRecordID")]
        public TweakDbId OverdueMessageRecordID { get; set; }
        
        [RealName("paidMessageRecordID")]
        public TweakDbId PaidMessageRecordID { get; set; }
        
        [RealName("evictionMessageRecordID")]
        public TweakDbId EvictionMessageRecordID { get; set; }
        
        [RealName("paymentSchedule")]
        public DumpedEnums.EPaymentSchedule? PaymentSchedule { get; set; }
        
        [RealName("randomizeInitialOverdue")]
        public bool RandomizeInitialOverdue { get; set; }
        
        [RealName("initialOverdue")]
        public int InitialOverdue { get; set; }
        
        [RealName("allowAutomaticRentStatusChange")]
        public bool AllowAutomaticRentStatusChange { get; set; }
        
        [RealName("maxDays")]
        public int MaxDays { get; set; }
        
        [RealName("currentOverdue")]
        public int CurrentOverdue { get; set; }
        
        [RealName("isInitialRentStateSet")]
        public bool IsInitialRentStateSet { get; set; }
        
        [RealName("currentRentStatus")]
        public DumpedEnums.ERentStatus? CurrentRentStatus { get; set; }
        
        [RealName("lastStatusChangeDay")]
        public int LastStatusChangeDay { get; set; }
    }
}
