using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    [JsonObject]
    public class FactsDB : NodeRepresentation
    {
        private ObservableCollection<FactsTable> _factsTables;
        private byte[] _trailingBytes;

        public byte FactsTableCount => (byte)_factsTables.Count;

        public ObservableCollection<FactsTable> FactsTables
        {
            get => _factsTables;
            set
            {
                _factsTables = value;
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

        public FactsDB()
        {
            _factsTables = new NotifyingObservableCollection<FactsTable>();
            _factsTables.CollectionChanged += (sender, args) =>
            {
                OnPropertyChanged(nameof(FactsTables));
            };
        }
    }
}
