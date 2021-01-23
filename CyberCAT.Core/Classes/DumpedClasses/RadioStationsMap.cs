using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("RadioStationsMap")]
    public class RadioStationsMap : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("soundEvent")]
        public CName SoundEvent { get; set; }
        
        [RealName("channelName")]
        public string ChannelName { get; set; }
        
        [RealName("stationID")]
        public DumpedEnums.ERadioStationList? StationID { get; set; }
    }
}
