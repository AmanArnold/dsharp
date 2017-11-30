using System.Runtime.CompilerServices;

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    [ScriptIgnore]
    public sealed class AssemblyDelaySignAttribute : Attribute
    {
        private bool _delaySign;

        public AssemblyDelaySignAttribute(bool delaySign)
        {
            _delaySign = delaySign;
        }

        public bool DelaySign
        {
            get
            {
                return _delaySign;
            }
        }
    }
}