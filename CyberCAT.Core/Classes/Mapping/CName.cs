namespace CyberCAT.Core.Classes.Mapping
{
    public struct CName
    {
        public CName(string value)
        {
            this.Value = value;
        }

        public string Value { get; }

        public static implicit operator CName(string s)
        {
            return new CName(s);
        }

        public static implicit operator string(CName p)
        {
            return p.Value;
        }
    }
}