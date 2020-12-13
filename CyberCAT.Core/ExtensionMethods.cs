using System;
using System.Buffers;
using System.IO;

namespace CyberCAT.Core
{
    internal static class ExtensionMethods
    {
        public static string ReadString(this BinaryReader reader, int count)
        {
            return new string(reader.ReadChars(count));
        }

        public static string PeekString(this BinaryReader reader, int count)
        {
            long position = reader.BaseStream.Position;
            string value = new string(reader.ReadChars(count));
            reader.BaseStream.Position = position;
            return value;
        }

        public static byte PeekByte(this BinaryReader reader)
        {
            long position = reader.BaseStream.Position;
            byte value = reader.ReadByte();
            reader.BaseStream.Position = position;
            return value;
        }

        public static void Skip(this BinaryReader reader, int count)
        {
            reader.BaseStream.Position += count;
        }
        
        // TODO: The following two methods are copied from source. Can remove this once library is moved to target .net standard 2.1
        //       can also remove System.Buffers package reference
        //       https://github.com/dotnet/corefx/blob/master/src/Common/src/CoreLib/System/IO/Stream.cs#L737
        public static int Read(this Stream stream, Span<byte> buffer)
        {
            byte[] sharedBuffer = ArrayPool<byte>.Shared.Rent(buffer.Length);
            try
            {
                int numRead = stream.Read(sharedBuffer, 0, buffer.Length);
                if ((uint)numRead > (uint)buffer.Length)
                {
                    throw new IOException("Stream Too Long");
                }
                new Span<byte>(sharedBuffer, 0, numRead).CopyTo(buffer);
                return numRead;
            }
            finally { ArrayPool<byte>.Shared.Return(sharedBuffer); }
        }
        
        // https://github.com/dotnet/corefx/blob/master/src/Common/src/CoreLib/System/IO/Stream.cs#L770
        public static void Write(this Stream stream, ReadOnlySpan<byte> buffer)
        {
            byte[] sharedBuffer = ArrayPool<byte>.Shared.Rent(buffer.Length);
            try
            {
                buffer.CopyTo(sharedBuffer);
                stream.Write(sharedBuffer, 0, buffer.Length);
            }
            finally { ArrayPool<byte>.Shared.Return(sharedBuffer); }
        }
    }
}
