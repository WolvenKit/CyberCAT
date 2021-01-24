namespace CyberCAT.Core.Classes.Mapping
{
    public struct NodeRef
    {
        public NodeRef(string value)
        {
            this.Value = value;
        }

        public string Value { get; }

        public static implicit operator NodeRef(string s)
        {
            return new NodeRef(s);
        }

        public static implicit operator string(NodeRef p)
        {
            return p.Value;
        }
    }
}