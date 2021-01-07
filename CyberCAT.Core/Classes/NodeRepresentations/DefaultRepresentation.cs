using Newtonsoft.Json;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    [JsonObject]
    public class DefaultRepresentation : NodeRepresentation
    {
        private byte[] _headerBlob;
        private byte[] _trailingBlob;

        public byte[] HeaderBlob
        {
            get => _headerBlob;
            set
            {
                _headerBlob = value;
                OnPropertyChanged();
            }
        }

        public byte[] TrailingBlob
        {
            get => _trailingBlob;
            set
            {
                _trailingBlob = value;
                OnPropertyChanged();
            }
        }
    }
}
