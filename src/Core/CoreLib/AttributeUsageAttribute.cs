using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    [ScriptIgnore]
    public sealed class AttributeUsageAttribute : Attribute
    {
        private AttributeTargets _attributeTarget = AttributeTargets.All;
        private bool _allowMultiple;
        private bool _inherited;

        public AttributeUsageAttribute(AttributeTargets validOn)
        {
            _attributeTarget = validOn;
            _inherited = true;
        }

        public AttributeTargets ValidOn
        {
            get
            {
                return _attributeTarget;
            }
        }

        public bool AllowMultiple
        {
            get
            {
                return _allowMultiple;
            }
            set
            {
                _allowMultiple = value;
            }
        }

        public bool Inherited
        {
            get
            {
                return _inherited;
            }
            set
            {
                _inherited = value;
            }
        }
    }
}