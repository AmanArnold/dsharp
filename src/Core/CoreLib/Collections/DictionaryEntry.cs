// DictionaryEntry.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
using System.Runtime.CompilerServices;

namespace System.Collections
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    public struct DictionaryEntry
    {
        public DictionaryEntry(object key, object value)
        {
        }

        [ScriptField]
        public extern object Key { get; set; }

        [ScriptField]
        public extern object Value { get; set; }
    }
}