using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ScriptIgnore]
    public sealed class AssemblyProductAttribute : Attribute
    {
        private string _product;

        public AssemblyProductAttribute(string product)
        {
            _product = product;
        }

        public string Product
        {
            get
            {
                return _product;
            }
        }
    }
}