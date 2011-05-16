// DictionaryEntry.cs
// Script#/Libraries/CoreLib
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Collections {

    [IgnoreNamespace]
    [Imported]
    public sealed class DictionaryEntry {

        internal DictionaryEntry() {
        }

        [IntrinsicProperty]
        public string Key {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public object Value {
            get {
                return null;
            }
        }
    }
}
