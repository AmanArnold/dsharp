// Assert.cs
// Script#/Libraries/CoreLib
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Testing {

    [IgnoreNamespace]
    [Imported]
    public static class Assert {

        [ScriptAlias("QUnit.equal")]
        public static void AreEqual(object actual, object expected) {
        }

        [ScriptAlias("QUnit.equal")]
        public static void AreEqual(object actual, object expected, string message) {
        }

        [ScriptAlias("QUnit.notEqual")]
        public static void AreNotEqual(object actual, object expected) {
        }

        [ScriptAlias("QUnit.notEqual")]
        public static void AreNotEqual(object actual, object expected, string message) {
        }

        [ScriptAlias("QUnit.expect")]
        public static void ExpectAsserts(int assertions) {
        }

        [ScriptAlias("QUnit.ok")]
        public static void IsTrue(bool condition) {
        }

        [ScriptAlias("QUnit.ok")]
        public static void IsTrue(bool condition, string message) {
        }
    }
}
