// Runtime.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ScriptIgnore]
    public abstract class MulticastDelegate : Delegate
    {
        protected MulticastDelegate(object target, string method)
            : base(target, method)
        {
        }

        protected MulticastDelegate(Type target, string method)
            : base(target, method)
        {
        }
    }
}