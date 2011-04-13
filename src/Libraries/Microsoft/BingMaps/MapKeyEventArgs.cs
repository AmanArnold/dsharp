// MapKeyEventArgs.cs
// Script#/Libraries/Microsoft/BingMaps
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Collections;
using System.Html;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    // TODO: Make properties

    [Imported]
    [IgnoreNamespace]
    public sealed class MapKeyEventArgs : MapEventArgs {

        private MapKeyEventArgs() {
        }

        public bool Handled;
        public int KeyCode;
        public bool AltKey;
        public bool CtrlKey;
        public bool ShiftKey;
    }
}
