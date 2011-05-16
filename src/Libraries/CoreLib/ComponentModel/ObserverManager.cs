// ObserverManager.cs
// Script#/Libraries/CoreLib
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace System.ComponentModel {

    [Imported]
    [ScriptNamespace("ss")]
    [ScriptName("Observable")]
    public static class ObserverManager {

        public static IDisposable RegisterObserver(IObserver observer) {
            return null;
        }
    }
}
