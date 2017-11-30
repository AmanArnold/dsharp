// Runtime.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    [ScriptIgnore]
    public sealed class CLSCompliantAttribute : Attribute
    {
        private bool _isCompliant;

        public CLSCompliantAttribute(bool isCompliant)
        {
            _isCompliant = isCompliant;
        }

        public bool IsCompliant
        {
            get
            {
                return _isCompliant;
            }
        }
    }
}