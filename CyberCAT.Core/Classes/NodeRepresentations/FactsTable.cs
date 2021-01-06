using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CyberCAT.Core.Annotations;
using Newtonsoft.Json;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    [JsonObject]
    public class FactsTable : NodeRepresentation
    {
        private ObservableCollection<FactEntry> _factEntries;

        [JsonObject]
        public class FactEntry : INotifyPropertyChanged
        {
            private uint _hash;
            private uint _value;

            public uint Hash
            {
                get => _hash;
                set
                {
                    _hash = value;
                    OnPropertyChanged();
                }
            }

            public string FactName => FactResolver.GetName(Hash);

            public uint Value
            {
                get => _value;
                set
                {
                    _value = value;
                    OnPropertyChanged();
                }
            }

            public override string ToString()
            {
                return $"{FactName}";
            }

            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<FactEntry> FactEntries
        {
            get => _factEntries;
            set
            {
                _factEntries = value;
                OnPropertyChanged();
            }
        }

        public FactsTable()
        {
            _factEntries = new NotifyingObservableCollection<FactEntry>();
            _factEntries.CollectionChanged += (sender, args) =>
            {
                OnPropertyChanged(nameof(FactEntries));
            };
        }
    }
}