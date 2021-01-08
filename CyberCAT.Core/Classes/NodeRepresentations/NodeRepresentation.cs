using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Annotations;
using Newtonsoft.Json;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class NodeRepresentation : INotifyPropertyChanged
    {
        [JsonIgnore]
        public NodeEntry Node { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
