using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ScriptIgnore]
    public sealed class AssemblyTitleAttribute : Attribute
    {
        private string _title;

        public AssemblyTitleAttribute(string title)
        {
            _title = title;
        }

        public string Title
        {
            get
            {
                return _title;
            }
        }
    }
}