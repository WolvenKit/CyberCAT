using System;

namespace CyberCAT.Core.Classes
{
    public struct GameTime
    {
        public GameTime(uint value)
        {
            Value = value;
        }

        public uint Value { get; }

        public static implicit operator GameTime(uint s)
        {
            return new GameTime(s);
        }

        public static implicit operator uint(GameTime p)
        {
            return p.Value;
        }

        public string ToGameTimeString()
        {
            var time = TimeSpan.FromSeconds(Value);
            return time.ToString(@"d\:hh\:mm\:ss");
        }

        public string ToRealTimeString()
        {
            var time = TimeSpan.FromSeconds(Value / 8);
            return time.ToString(@"d\:hh\:mm\:ss");
        }

        public override string ToString()
        {
            return ToGameTimeString();
        }
    }
}