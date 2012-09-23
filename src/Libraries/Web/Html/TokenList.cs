﻿// TokenList.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {

    [IgnoreNamespace]
    [Imported]
    public sealed class TokenList {

        private TokenList() {
        }

        [ScriptProperty]
        [ScriptName("length")]
        public int Count {
            get {
                return 0;
            }
        }

        [ScriptProperty]
        public string this[int index] {
            get {
                return null;
            }
        }

        public bool Contains(string token) {
            return false;
        }

        public void Add(string token) {
        }

        public void Remove(string token) {
        }

        public bool Toggle(string token) {
            return false;
        }

        public override string ToString() {
            return null;
        }
    }
}
