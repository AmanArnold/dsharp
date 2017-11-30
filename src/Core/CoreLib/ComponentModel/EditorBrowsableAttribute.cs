using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Delegate | AttributeTargets.Interface)]
    [ScriptIgnore]
    public sealed class EditorBrowsableAttribute : Attribute
    {
        private EditorBrowsableState _browsableState;

        public EditorBrowsableAttribute(EditorBrowsableState state)
        {
            _browsableState = state;
        }

        public EditorBrowsableState State
        {
            get
            {
                return _browsableState;
            }
        }
    }
}