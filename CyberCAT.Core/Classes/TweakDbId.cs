using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using CyberCAT.Core.Annotations;

namespace CyberCAT.Core.Classes
{
    public class TweakDbId : INotifyPropertyChanged
    {
        private uint _id;
        private byte _length;
        private byte[] _padding;

        public ulong Raw64
        {
            get
            {
                var idBytes = BitConverter.GetBytes(Id);

                var rawBytes = new byte[8];
                rawBytes[7] = Padding[2];
                rawBytes[6] = Padding[1];
                rawBytes[5] = Padding[0];
                rawBytes[4] = Length;
                rawBytes[3] = idBytes[3];
                rawBytes[2] = idBytes[2];
                rawBytes[1] = idBytes[1];
                rawBytes[0] = idBytes[0];

                return BitConverter.ToUInt64(rawBytes, 0);
            }
            set
            {
                var rawBytes = BitConverter.GetBytes(value);
                var idBytes = new byte[4];
                idBytes[0] = rawBytes[0];
                idBytes[1] = rawBytes[1];
                idBytes[2] = rawBytes[2];
                idBytes[3] = rawBytes[3];
                Id = BitConverter.ToUInt32(idBytes, 0);
                Length = rawBytes[4];
                Padding = new byte[3];
                Padding[0] = rawBytes[5];
                Padding[1] = rawBytes[6];
                Padding[2] = rawBytes[7];

                OnPropertyChanged();
                OnPropertyChanged(nameof(Id));
                OnPropertyChanged(nameof(Length));
                OnPropertyChanged(nameof(Padding));
            }
        }

        public uint Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Raw64));
            }
        }

        public byte Length
        {
            get => _length;
            set
            {
                _length = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Raw64));
            }
        }

        public byte[] Padding
        {
            get => _padding;
            set
            {
                _padding = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Raw64));
            }
        }

        protected bool Equals(TweakDbId other)
        {
            return _id == other._id && _length == other._length && _padding.SequenceEqual(other._padding);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TweakDbId) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int) _id;
                hashCode = (hashCode * 397) ^ _length.GetHashCode();
                hashCode = (hashCode * 397) ^ (_padding != null ? _padding.GetHashCode() : 0);
                return hashCode;
            }
        }

        public string Name => NameResolver.GetName(this);

        public override string ToString()
        {
            return $"{Id:X8}:{Length:X2}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Create a TweakDbId object based on a TweakDb name.
        /// The NameResolver needs to be filled for this to work.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static TweakDbId FromName(string name)
        {
            return new TweakDbId {Raw64 = NameResolver.GetHash(name)};
        }

        /// <summary>
        /// Returns the TweakDbId representing None (Id 00000000:00).
        /// This object can be modified afterwards as always a new object is returned.
        /// </summary>
        public static TweakDbId None => new TweakDbId {Raw64 = 0};

        public TweakDbId Clone()
        {
            return new TweakDbId {Id = _id, Length = _length};
        }

        public TweakDbId()
        {
            _padding = new byte[3];
        }
    }

    public static class TweakDbIdExtensions
    {
        public static TweakDbId ReadTweakDbId(this BinaryReader reader)
        {
            var tdbid = new TweakDbId();
            tdbid.Id = reader.ReadUInt32();
            tdbid.Length = reader.ReadByte();
            tdbid.Padding = reader.ReadBytes(3);
            return tdbid;
        }

        public static void Write(this BinaryWriter writer, TweakDbId tdbid)
        {
            writer.Write(tdbid.Id);
            writer.Write(tdbid.Length);
            writer.Write(tdbid.Padding);
        }
    }
}
