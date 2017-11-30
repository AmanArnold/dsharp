using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ScriptIgnore]
    public sealed class AssemblyTrademarkAttribute : Attribute
    {
        private string _trademark;

        public AssemblyTrademarkAttribute(string trademark)
        {
            _trademark = trademark;
        }

        public string Trademark
        {
            get
            {
                return _trademark;
            }
        }
    }
}