// Array.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
using System.Collections;
using System.Runtime.CompilerServices;

namespace System
{
    // NOTE: Keep in sync with ArrayList and List

    /// <summary>
    /// Equivalent to the Array type in Javascript.
    /// </summary>
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("Array")]
    public abstract class Array : IEnumerable
    {
        [ScriptField]
        public extern int Length { get; }

        [ScriptField]
        public extern object this[int index] { get; set; }

        public extern bool Contains(object item);

        public extern IEnumerator GetEnumerator();

        public extern int IndexOf(object item);

        public extern int IndexOf(object item, int startIndex);

        public extern int LastIndexOf(object item);

        public extern int LastIndexOf(object item, int fromIndex);

        public extern void Reverse();

        public extern void Sort();

        [ScriptAlias("ss.array")]
        public extern static Array ToArray(object o);

        public extern static explicit operator ArrayList(Array array);
    }
}
