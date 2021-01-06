using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CyberCAT.Core.Annotations;
using Newtonsoft.Json;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    [JsonObject]
    public class ItemData : NodeRepresentation
    {
        private TweakDbId _itemTdbId;
        private HeaderThing _header;
        private ItemFlags _flags;
        private uint _creationTime;
        private ItemInnerData _data;

        public class NextItemEntry : INotifyPropertyChanged
        {
            private TweakDbId _itemTdbId;
            private HeaderThing _header;

            public TweakDbId ItemTdbId
            {
                get => _itemTdbId;
                set
                {
                    if (_itemTdbId != null)
                    {
                        _itemTdbId.PropertyChanged -= ItemTdbIdChanged;
                    }
                    _itemTdbId = value;
                    if (_itemTdbId != null)
                    {
                        _itemTdbId.PropertyChanged += ItemTdbIdChanged;
                    }
                    OnPropertyChanged();
                }
            }

            private void ItemTdbIdChanged(object sender, PropertyChangedEventArgs args)
            {
                OnPropertyChanged(nameof(ItemTdbId));
            }

            public string ItemName => NameResolver.GetName(ItemTdbId);
            public string ItemGameName => NameResolver.GetGameName(ItemTdbId);
            public string ItemGameDescription => NameResolver.GetGameDescription(ItemTdbId);

            public HeaderThing Header
            {
                get => _header;
                set
                {
                    if (_header != null)
                    {
                        _header.PropertyChanged -= HeaderChanged;
                    }
                    _header = value;
                    if (_header != null)
                    {
                        _header.PropertyChanged += HeaderChanged;
                    }
                    OnPropertyChanged();
                }
            }

            private void HeaderChanged(object sender, PropertyChangedEventArgs args)
            {
                OnPropertyChanged(nameof(Header));
            }

            public override string ToString()
            {
                return $"{ItemName} ({ItemGameName})";
            }

            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            public bool BelongsToItemData(ItemData item)
            {
                return _itemTdbId.Equals(item.ItemTdbId) && _header.Equals(item.Header);
            }

            public static NextItemEntry GenerateFromItem(ItemData item)
            {
                return new NextItemEntry { _itemTdbId = item.ItemTdbId, Header = item.Header };
            }
        }

        [JsonObject]
        public class ItemFlags : INotifyPropertyChanged
        {
            private byte _raw;

            public byte Raw
            {
                get => _raw;
                set
                {
                    _raw = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(IsQuestItem));
                    OnPropertyChanged(nameof(Unknown2));
                }
            }

            public bool IsQuestItem
            {
                get => (Raw & 0x01) == 0x01;
                set
                {
                    if (value)
                    {
                        Raw |= 0x01;
                    } else {
                        Raw &= byte.MaxValue ^ (0x01);
                    }
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Raw));
                } 
            }
            public bool Unknown2
            {
                get => (Raw & 0x02) == 0x02;
                set
                {
                    if (value)
                    {
                        Raw |= 0x02;
                    }
                    else
                    {
                        Raw &= byte.MaxValue ^ (0x02);
                    }
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Raw));
                }
            }

            public ItemFlags(byte raw)
            {
                _raw = raw;
            }

            public override string ToString()
            {
                return $"[......{(Unknown2 ? '?' : '.')}{(IsQuestItem ? 'Q' : '.')}]";
            }

            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [JsonObject]
        public class ItemInnerData : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [JsonObject]
        public class SimpleItemData : ItemInnerData
        {
            private uint _quantity;

            public uint Quantity
            {
                get => _quantity;
                set
                {
                    _quantity = value;
                    OnPropertyChanged();
                }
            }

            public override string ToString()
            {
                return $"{Quantity}x";
            }
        }

        [JsonObject]
        public class ModableItemData : ItemInnerData
        {
            private TweakDbId _tdbId1;
            private uint _unknown2;
            private uint _unknown3;
            private ItemModData _rootNode;

            public TweakDbId TdbId1
            {
                get => _tdbId1;
                set
                {
                    if (_tdbId1 != null)
                    {
                        _tdbId1.PropertyChanged -= ItemTdbIdChanged;
                    }
                    _tdbId1 = value;
                    if (_tdbId1 != null)
                    {
                        _tdbId1.PropertyChanged += ItemTdbIdChanged;
                    }
                    OnPropertyChanged();
                }
            }

            private void ItemTdbIdChanged(object sender, PropertyChangedEventArgs args)
            {
                OnPropertyChanged(nameof(ItemTdbId));
            }

            public string TdbId1Name => NameResolver.GetName(TdbId1);

            public uint Unknown2
            {
                get => _unknown2;
                set
                {
                    _unknown2 = value;
                    OnPropertyChanged();
                }
            }

            public uint Unknown3
            {
                get => _unknown3;
                set
                {
                    _unknown3 = value;
                    OnPropertyChanged();
                }
            }

            public ItemModData RootNode
            {
                get => _rootNode;
                set
                {
                    if (_rootNode != null)
                    {
                        _rootNode.PropertyChanged -= RootNodeChanged;
                    }
                    _rootNode = value;
                    if (_rootNode != null)
                    {
                        _rootNode.PropertyChanged += RootNodeChanged;
                    }
                    OnPropertyChanged();
                }
            }

            private void RootNodeChanged(object sender, PropertyChangedEventArgs args)
            {
                OnPropertyChanged(nameof(RootNode));
            }

            public override string ToString()
            {
                return $"{TdbId1Name}";
            }
        }

        [JsonObject]
        public class ModableItemWithQuantityData : ModableItemData
        {
            private uint _quantity;

            public uint Quantity
            {
                get => _quantity;
                set
                {
                    _quantity = value;
                    OnPropertyChanged();
                }
            }
        }

        [JsonObject]
        public class ItemModData : INotifyPropertyChanged
        {
            private TweakDbId _itemTdbId;
            private HeaderThing _header;
            private string _unknownString;
            private TweakDbId _attachmentSlotTdbId;
            private ObservableCollection<ItemModData> _children;
            private uint _unknown2;
            private TweakDbId _tdbId2;
            private uint _unknown3;
            private uint _unknown4;

            public TweakDbId ItemTdbId
            {
                get => _itemTdbId;
                set
                {
                    if (_itemTdbId != null)
                    {
                        _itemTdbId.PropertyChanged -= ItemTdbIdChanged;
                    }
                    _itemTdbId = value;
                    if (_itemTdbId != null)
                    {
                        _itemTdbId.PropertyChanged -= ItemTdbIdChanged;
                    }
                    OnPropertyChanged();
                }
            }

            private void ItemTdbIdChanged(object sender, PropertyChangedEventArgs args)
            {
                OnPropertyChanged(nameof(ItemTdbId));
            }

            public string ItemName => NameResolver.GetName(ItemTdbId);
            public string ItemGameName => NameResolver.GetGameName(ItemTdbId);
            public string ItemGameDescription => NameResolver.GetGameDescription(ItemTdbId);

            public HeaderThing Header
            {
                get => _header;
                set
                {
                    if (_header != null)
                    {
                        _header.PropertyChanged -= HeaderChanged;
                    }
                    _header = value;
                    if (_header != null)
                    {
                        _header.PropertyChanged += HeaderChanged;
                    }
                    OnPropertyChanged();
                }
            }

            private void HeaderChanged(object sender, PropertyChangedEventArgs args)
            {
                OnPropertyChanged(nameof(Header));
            }

            public string UnknownString
            {
                get => _unknownString;
                set
                {
                    _unknownString = value;
                    OnPropertyChanged();
                }
            }

            public TweakDbId AttachmentSlotTdbId
            {
                get => _attachmentSlotTdbId;
                set
                {
                    if (_attachmentSlotTdbId != null)
                    {
                        _attachmentSlotTdbId.PropertyChanged -= AttachmentSlotTdbIdChanged;
                    }
                    _attachmentSlotTdbId = value;
                    if (_attachmentSlotTdbId != null)
                    {
                        _attachmentSlotTdbId.PropertyChanged += AttachmentSlotTdbIdChanged;
                    }
                    OnPropertyChanged();
                }
            }

            private void AttachmentSlotTdbIdChanged(object sender, PropertyChangedEventArgs args)
            {
                OnPropertyChanged(nameof(AttachmentSlotTdbId));
            }

            public string AttachmentSlotName => NameResolver.GetName(AttachmentSlotTdbId);
            public int ChildrenCount => Children?.Count ?? 0;

            public ObservableCollection<ItemModData> Children => _children;

            public uint Unknown2
            {
                get => _unknown2;
                set
                {
                    _unknown2 = value;
                    OnPropertyChanged();
                }
            }

            public TweakDbId TdbId2
            {
                get => _tdbId2;
                set
                {
                    if (_tdbId2 != null)
                    {
                        _tdbId2.PropertyChanged -= TdbId2Changed;
                    }
                    _tdbId2 = value;
                    if (_tdbId2 != null)
                    {
                        _tdbId2.PropertyChanged += TdbId2Changed;
                    }
                    OnPropertyChanged();
                }
            }

            private void TdbId2Changed(object sender, PropertyChangedEventArgs args)
            {
                OnPropertyChanged(nameof(TdbId2));
            }

            public string TdbId2Name => NameResolver.GetName(TdbId2);

            public uint Unknown3
            {
                get => _unknown3;
                set
                {
                    _unknown3 = value;
                    OnPropertyChanged();
                }
            }

            public uint Unknown4
            {
                get => _unknown4;
                set
                {
                    _unknown4 = value;
                    OnPropertyChanged();
                }
            }

            public override string ToString()
            {
                return string.IsNullOrWhiteSpace(ItemGameName) ? ItemName : $"{ItemName} ({ItemGameName})";
            }

            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            public ItemModData()
            {
                _children = new NotifyingObservableCollection<ItemModData>();
                _children.CollectionChanged += (sender, args) =>
                {
                    OnPropertyChanged(nameof(Children));
                };
            }
        }

        [JsonObject]
        public class HeaderThing : INotifyPropertyChanged
        {
            private uint _itemId;
            private byte _unknownByte1;
            private ushort _unknownBytes2;

            public uint ItemId
            {
                get => _itemId;
                set
                {
                    _itemId = value;
                    OnPropertyChanged();
                }
            }

            public byte UnknownByte1
            {
                get => _unknownByte1;
                set
                {
                    _unknownByte1 = value;
                    OnPropertyChanged();
                }
            }

            public ushort UnknownBytes2
            {
                get => _unknownBytes2;
                set
                {
                    _unknownBytes2 = value;
                    OnPropertyChanged();
                }
            }

            public byte Kind
            {
                get
                {
                    if (UnknownByte1 == 1)
                        return 2;
                    if (UnknownByte1 == 2)
                        return 1;
                    if (UnknownByte1 == 3)
                        return 0;
                    return (byte)(ItemId != 2 ? 2 : 1);
                }
            }

            public override string ToString()
            {
                return $"Type: {Kind} | {ItemId:X8}";
            }

            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            protected bool Equals(HeaderThing other)
            {
                return _itemId == other._itemId && _unknownByte1 == other._unknownByte1 && _unknownBytes2 == other._unknownBytes2;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((HeaderThing) obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    var hashCode = (int) _itemId;
                    hashCode = (hashCode * 397) ^ _unknownByte1.GetHashCode();
                    hashCode = (hashCode * 397) ^ _unknownBytes2.GetHashCode();
                    return hashCode;
                }
            }
        }

        public TweakDbId ItemTdbId
        {
            get => _itemTdbId;
            set
            {
                if (_itemTdbId != null)
                {
                    _itemTdbId.PropertyChanged -= ItemTdbIdChanged;
                }
                _itemTdbId = value;
                if (_itemTdbId != null)
                {
                    _itemTdbId.PropertyChanged += ItemTdbIdChanged;
                }
                OnPropertyChanged();
            }
        }

        private void ItemTdbIdChanged(object sender, PropertyChangedEventArgs args)
        {
            OnPropertyChanged(nameof(ItemTdbId));
        }

        public string ItemName => NameResolver.GetName(ItemTdbId);
        public string ItemGameName => NameResolver.GetGameName(ItemTdbId);
        public string ItemGameDescription => NameResolver.GetGameDescription(ItemTdbId);

        public HeaderThing Header
        {
            get => _header;
            set
            {
                if (_header != null)
                {
                    _header.PropertyChanged -= HeaderChanged;
                }
                _header = value;
                if (_header != null)
                {
                    _header.PropertyChanged += HeaderChanged;
                }
                OnPropertyChanged();
            }
        }

        private void HeaderChanged(object sender, PropertyChangedEventArgs args)
        {
            OnPropertyChanged(nameof(Header));
        }

        public ItemFlags Flags
        {
            get => _flags;
            set
            {
                if (_flags != null)
                {
                    _flags.PropertyChanged -= FlagsChanged;
                }
                _flags = value;
                if (_flags != null)
                {
                    _flags.PropertyChanged += FlagsChanged;
                }
                OnPropertyChanged();
            }
        }

        private void FlagsChanged(object sender, PropertyChangedEventArgs args)
        {
            OnPropertyChanged(nameof(Flags));
        }

        public uint CreationTime
        {
            get => _creationTime;
            set
            {
                _creationTime = value;
                OnPropertyChanged();
            }
        }

        public ItemInnerData Data
        {
            get => _data;
            set
            {
                if (_data != null)
                {
                    _data.PropertyChanged -= ItemInnerDataChanged;
                }
                _data = value;
                if (_data != null)
                {
                    _data.PropertyChanged += ItemInnerDataChanged;
                }
                OnPropertyChanged();
            }
        }

        private void ItemInnerDataChanged(object sender, PropertyChangedEventArgs args)
        {
            OnPropertyChanged(nameof(ItemInnerData));
        }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(ItemGameName) ? ItemName : $"{ItemName} ({ItemGameName})";
        }
    }
}
