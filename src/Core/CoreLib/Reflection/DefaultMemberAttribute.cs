using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ScriptIgnore]
    public sealed class DefaultMemberAttribute
    {
        private string _memberName;

        public DefaultMemberAttribute(string memberName)
        {
            _memberName = memberName;
        }

        public string MemberName
        {
            get
            {
                return _memberName;
            }
        }
    }
}