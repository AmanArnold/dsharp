// IContainer.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;

namespace System.ComponentModel
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ScriptIgnore]
    public enum EditorBrowsableState
    {
        Always = 0,
        Never = 1,
        Advanced = 2
    }
}