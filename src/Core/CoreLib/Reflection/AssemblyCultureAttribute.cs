using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ScriptIgnore]
    public sealed class AssemblyCultureAttribute : Attribute
    {
        private string _culture;

        public AssemblyCultureAttribute(string culture)
        {
            _culture = culture;
        }

        public string Culture
        {
            get
            {
                return _culture;
            }
        }
    }
}