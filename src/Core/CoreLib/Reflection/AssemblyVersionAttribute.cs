using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ScriptIgnore]
    public sealed class AssemblyVersionAttribute : Attribute
    {
        private string _version;

        public AssemblyVersionAttribute(string version)
        {
            _version = version;
        }

        public string Version
        {
            get
            {
                return _version;
            }
        }
    }
}