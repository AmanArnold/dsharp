using System.Runtime.CompilerServices;

namespace System.Runtime.Versioning
{

    [AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
    [ScriptIgnore]
    public sealed class TargetFrameworkAttribute : Attribute
    {
        private string _frameworkName;
        private string _frameworkDisplayName;

        public TargetFrameworkAttribute(string frameworkName)
        {
            _frameworkName = frameworkName;
        }

        public string FrameworkDisplayName
        {
            get
            {
                return _frameworkDisplayName;
            }
            set
            {
                _frameworkDisplayName = value;
            }
        }

        public string FrameworkName
        {
            get
            {
                return _frameworkName;
            }
        }
    }
}