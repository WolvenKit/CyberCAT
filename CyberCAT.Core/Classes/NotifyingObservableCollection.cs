using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    internal sealed class NotifyingObservableCollection<T> : ObservableCollection<T> where T : INotifyPropertyChanged
    {
        public NotifyingObservableCollection()
        {
            CollectionChanged += ItemChanged;
        }


        public NotifyingObservableCollection(IEnumerable<T> collection) : base(collection)
        {
            CollectionChanged += ItemChanged;
            foreach (var item in collection)
            {
                item.PropertyChanged += ItemPropertyChanged;
            }

        }

        private void ItemChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e == null)
            {
                return;
            }

            if (e.OldItems != null)
            {
                foreach (INotifyPropertyChanged item in e.OldItems)
                {
                    item.PropertyChanged -= ItemPropertyChanged;
                }
            }

            if (e.NewItems != null)
            {
                foreach (INotifyPropertyChanged item in e.NewItems)
                {
                    item.PropertyChanged += ItemPropertyChanged;
                }
            }
        }

        private void ItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // Not the real reason, but whatever
            var args = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
            OnCollectionChanged(args);
        }
    }
}
