using Be.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Forms.Classes
{
    class ByteProvider : IByteProvider
    {
        public long Length => _workingData.Count;

        public event EventHandler LengthChanged;
        public event EventHandler Changed;
        public byte[] Data { get; private set; }
        List<byte> _workingData;
        public ByteProvider(byte[] source)
        {
            Data = (byte[])source.Clone();
            _workingData = new List<byte>() { };
            _workingData.AddRange((IEnumerable<byte>)Data.Clone());
        }
        public void ApplyChanges()
        {
            Data = _workingData.ToArray();
        }

        public void DeleteBytes(long index, long length)
        {
            _workingData.RemoveRange((int)index, (int)length);
        }

        public bool HasChanges()
        {
            return !_workingData.SequenceEqual(Data);
        }

        public void InsertBytes(long index, byte[] bs)
        {
            _workingData.InsertRange((int)index, bs);
        }

        public byte ReadByte(long index)
        {
            return _workingData[(int)index];
        }

        public bool SupportsDeleteBytes()
        {
            return true;
        }

        public bool SupportsInsertBytes()
        {
            return true;
        }

        public bool SupportsWriteByte()
        {
            return true;
        }

        public void WriteByte(long index, byte value)
        {
            _workingData[(int)index] = value;
        }
    }
}
