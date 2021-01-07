using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Annotations;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class NodeRepresentation : INotifyPropertyChanged
    {
        public NodeEntry Node { get; set; }

        protected void UpdateNodeSize()
        {
            Node?.MySizeChanged();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            UpdateNodeSize();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
