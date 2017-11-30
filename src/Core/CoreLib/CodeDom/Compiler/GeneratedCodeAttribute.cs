using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.CodeDom.Compiler
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
    [ScriptIgnore]
    public sealed class GeneratedCodeAttribute : Attribute
    {
        private string _tool;
        private string _version;

        public GeneratedCodeAttribute(string tool, string version)
        {
            _tool = tool;
            _version = version;
        }

        public string Tool
        {
            get
            {
                return _tool;
            }
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