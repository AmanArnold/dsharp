using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ScriptIgnore]
    public sealed class AssemblyKeyFileAttribute : Attribute
    {
        private string _keyFile;

        public AssemblyKeyFileAttribute(string keyFile)
        {
            _keyFile = keyFile;
        }

        public string KeyFile
        {
            get
            {
                return _keyFile;
            }
        }
    }
}