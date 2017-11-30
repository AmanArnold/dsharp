using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
    [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ScriptIgnore]
    public sealed class DataMemberAttribute : Attribute
    {
        public bool EmitDefaultValue
        {
            get;
            set;
        }

        public bool IsReference
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int Order
        {
            get;
            set;
        }
    }
}