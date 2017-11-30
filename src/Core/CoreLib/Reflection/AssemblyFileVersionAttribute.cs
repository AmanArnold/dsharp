using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ScriptIgnore]
    public sealed class AssemblyFileVersionAttribute : Attribute
    {
        private string _version;

        public AssemblyFileVersionAttribute(string version)
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