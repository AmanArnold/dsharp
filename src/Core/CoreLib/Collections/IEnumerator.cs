// IEnumerator.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;

namespace System.Collections {

    [Imported]
    public interface IEnumerator {

        [ScriptProperty]
        object Current {
            get;
        }

        bool MoveNext();

        void Reset();
    }
}
