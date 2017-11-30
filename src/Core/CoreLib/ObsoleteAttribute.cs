// Runtime.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Interface | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Class, Inherited = false)]
    [ScriptIgnore]
    public sealed class ObsoleteAttribute : Attribute
    {
        private bool _error;
        private string _message;

        public ObsoleteAttribute()
        {
        }

        public ObsoleteAttribute(string message)
        {
            _message = message;
        }

        public ObsoleteAttribute(string message, bool error)
        {
            _message = message;
            _error = error;
        }

        public bool IsError
        {
            get
            {
                return _error;
            }
        }

        public string Message
        {
            get
            {
                return _message;
            }
        }
    }
}