using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CyberCAT.Core.Annotations;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    [JsonObject]
    public class CharacterCustomizationAppearances : NodeRepresentation
    {
        private bool _dataExists;
        private uint _unknown1;
        private byte[] _unknownFirstBytes;
        private Section _firstSection;
        private Section _secondSection;
        private Section _thirdSection;
        private ObservableCollection<StringTriple> _stringTriples;
        private ObservableCollection<string> _strings;

        [JsonObject]
        public class StringTriple : INotifyPropertyChanged
        {
            private string _firstString;
            private string _secondString;
            private string _thirdString;

            public string FirstString
            {
                get => _firstString;
                set
                {
                    _firstString = value;
                    OnPropertyChanged();
                }
            }

            public string SecondString
            {
                get => _secondString;
                set
                {
                    _secondString = value;
                    OnPropertyChanged();
                }
            }

            public string ThirdString
            {
                get => _thirdString;
                set
                {
                    _thirdString = value;
                    OnPropertyChanged();
                }
            }

            public StringTriple()
            {
                _firstString = "";
                _secondString = "";
                _thirdString = "";
            }

            public override string ToString()
            {
                return $"{FirstString} / {SecondString} / {ThirdString}";
            }

            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [JsonObject]
        public class HashValueEntry : INotifyPropertyChanged
        {
            private ulong _hash;
            private string _firstString;
            private string _secondString;
            private byte[] _trailingBytes;

            public ulong Hash
            {
                get => _hash;
                set
                {
                    _hash = value;
                    OnPropertyChanged();
                }
            }

            public string FirstString
            {
                get => _firstString;
                set
                {
                    _firstString = value;
                    OnPropertyChanged();
                }
            }

            public string SecondString
            {
                get => _secondString;
                set
                {
                    _secondString = value;
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

            public HashValueEntry()
            {
                _firstString = "";
                _secondString = "";
                _trailingBytes = new byte[8];
            }

            public override string ToString()
            {
                return $"{FirstString} / {SecondString}";
            }

            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [JsonObject]
        public class ValueEntry : INotifyPropertyChanged
        {
            private string _firstString;
            private string _secondString;
            private byte[] _trailingBytes;

            public string FirstString
            {
                get => _firstString;
                set
                {
                    _firstString = value;
                    OnPropertyChanged();
                }
            }

            public string SecondString
            {
                get => _secondString;
                set
                {
                    _secondString = value;
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

            public ValueEntry()
            {
                _firstString = "";
                _secondString = "";
                _trailingBytes = new byte[8];
            }

            public override string ToString()
            {
                return $"{FirstString} / {SecondString}";
            }

            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [JsonObject]
        public class AppearanceSection : INotifyPropertyChanged
        {
            private string _sectionName;
            private ObservableCollection<HashValueEntry> _mainList;
            private ObservableCollection<ValueEntry> _additionalList;

            public string SectionName
            {
                get => _sectionName;
                set
                {
                    _sectionName = value;
                    OnPropertyChanged();
                }
            }

            public ObservableCollection<HashValueEntry> MainList => _mainList;

            public ObservableCollection<ValueEntry> AdditionalList => _additionalList;

            public AppearanceSection()
            {
                _sectionName = "";
                _mainList = new NotifyingObservableCollection<HashValueEntry>();
                _mainList.CollectionChanged += (sender, args) =>
                {
                    OnPropertyChanged(nameof(MainList));
                };
                _additionalList = new NotifyingObservableCollection<ValueEntry>();
                _additionalList.CollectionChanged += (sender, args) =>
                {
                    OnPropertyChanged(nameof(AdditionalList));
                };
            }

            public override string ToString()
            {
                return $"{SectionName} ({MainList.Count} / {AdditionalList.Count})";
            }

            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [JsonObject]
        public class Section : INotifyPropertyChanged
        {
            private ObservableCollection<AppearanceSection> _appearanceSections;

            public ObservableCollection<AppearanceSection> AppearanceSections => _appearanceSections;

            public Section()
            {
                _appearanceSections = new NotifyingObservableCollection<AppearanceSection>();
                _appearanceSections.CollectionChanged += (sender, args) =>
                {
                    OnPropertyChanged(nameof(AppearanceSections));
                };
            }

            public override string ToString()
            {
                return $"{AppearanceSections.Count} inner sections";
            }

            public event PropertyChangedEventHandler PropertyChanged;

            [NotifyPropertyChangedInvocator]
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public bool DataExists
        {
            get => _dataExists;
            set
            {
                _dataExists = value;
                OnPropertyChanged();
            }
        }

        public uint Unknown1
        {
            get => _unknown1;
            set
            {
                _unknown1 = value;
                OnPropertyChanged();
            }
        }

        public byte[] UnknownFirstBytes
        {
            get => _unknownFirstBytes;
            set
            {
                _unknownFirstBytes = value;
                OnPropertyChanged();
            }
        }

        public Section FirstSection => _firstSection;

        public Section SecondSection => _secondSection;

        public Section ThirdSection => _thirdSection;

        public ObservableCollection<StringTriple> StringTriples => _stringTriples;

        public ObservableCollection<string> Strings => _strings;

        public CharacterCustomizationAppearances()
        {
            _firstSection = new Section();
            _firstSection.PropertyChanged += (sender, args) =>
            {
                OnPropertyChanged(nameof(FirstSection));
            };
            _secondSection = new Section();
            _secondSection.PropertyChanged += (sender, args) =>
            {
                OnPropertyChanged(nameof(FirstSection));
            };
            _thirdSection = new Section();
            _thirdSection.PropertyChanged += (sender, args) =>
            {
                OnPropertyChanged(nameof(FirstSection));
            };
            _stringTriples = new NotifyingObservableCollection<StringTriple>();
            _stringTriples.CollectionChanged += (sender, args) =>
            {
                OnPropertyChanged(nameof(StringTriples));
            };
            _strings = new ObservableCollection<string>();
            _strings.CollectionChanged += (sender, args) =>
            {
                OnPropertyChanged(nameof(Strings));
            };
        }
       
    }
}
