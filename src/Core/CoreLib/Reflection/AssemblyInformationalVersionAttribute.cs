using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ScriptIgnore]
    public sealed class AssemblyInformationalVersionAttribute : Attribute
    {
        private string _informationalVersion;

        public AssemblyInformationalVersionAttribute(string informationalVersion)
        {
            _informationalVersion = informationalVersion;
        }

        public string InformationalVersion
        {
            get
            {
                return _informationalVersion;
            }
        }
    }
}