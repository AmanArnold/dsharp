using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ScriptIgnore]
    public sealed class AssemblyDescriptionAttribute : Attribute
    {
        private string _description;

        public AssemblyDescriptionAttribute(string description)
        {
            _description = description;
        }

        public string Description
        {
            get
            {
                return _description;
            }
        }
    }
}