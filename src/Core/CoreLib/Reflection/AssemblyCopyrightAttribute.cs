using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ScriptIgnore]
    public sealed class AssemblyCopyrightAttribute : Attribute
    {
        private string _copyright;

        public AssemblyCopyrightAttribute(string copyright)
        {
            _copyright = copyright;
        }

        public string Copyright
        {
            get
            {
                return _copyright;
            }
        }
    }
}