using Newtonsoft.Json;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    [JsonObject]
    public class GameSessionConfig : NodeRepresentation
    {
        private ulong _hash1;
        private ulong _hash2;
        private string _textValue;
        private ulong _hash3;
        private byte[] _trailingBytes;

        public ulong Hash1
        {
            get => _hash1;
            set
            {
                _hash1 = value;
                OnPropertyChanged();
            }
        }

        public ulong Hash2
        {
            get => _hash2;
            set
            {
                _hash2 = value;
                OnPropertyChanged();
            }
        }

        public string TextValue
        {
            get => _textValue;
            set
            {
                _textValue = value;
                OnPropertyChanged();
            }
        }

        public ulong Hash3
        {
            get => _hash3;
            set
            {
                _hash3 = value;
                OnPropertyChanged();
            }
        }

        public byte[] TrailingBytes
        {
            get => _trailingBytes;
            set
            {
                _trailingBytes = value;
                OnPropertyChanged();
            }
        }
    }
}
