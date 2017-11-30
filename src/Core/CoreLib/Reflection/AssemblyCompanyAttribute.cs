using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ScriptIgnore]
    public sealed class AssemblyCompanyAttribute : Attribute
    {
        private string _company;

        public AssemblyCompanyAttribute(string company)
        {
            _company = company;
        }

        public string Company
        {
            get
            {
                return _company;
            }
        }
    }
}