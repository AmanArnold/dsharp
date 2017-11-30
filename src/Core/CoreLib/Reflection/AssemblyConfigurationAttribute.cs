using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ScriptIgnore]
    public sealed class AssemblyConfigurationAttribute : Attribute
    {
        private string _configuration;

        public AssemblyConfigurationAttribute(string configuration)
        {
            _configuration = configuration;
        }

        public string Configuration
        {
            get
            {
                return _configuration;
            }
        }
    }
}