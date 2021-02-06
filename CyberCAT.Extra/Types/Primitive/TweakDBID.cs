namespace CyberCAT.Extra.Types.Primitive
{
    public struct TweakDBID
    {
        public TweakDBID(ulong value)
        {
            this.Value = value;
        }

        public ulong Value { get; }

        public static implicit operator TweakDBID(ulong val)
        {
            return new TweakDBID(val);
        }

        public static implicit operator ulong(TweakDBID p)
        {
            return p.Value;
        }
    }
}