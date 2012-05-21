// ElementAttributeCollection.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {

    [IgnoreNamespace]
    [Imported]
    public sealed class ElementAttributeCollection {

        internal ElementAttributeCollection() {
        }

        [IntrinsicProperty]
        public int Length {
            get {
                return 0;
            }
        }

        public ElementAttribute GetNamedItem(string name) {
            return null;
        }

        public ElementAttribute RemoveNamedItem(string name) {
            return null;
        }

        public ElementAttribute SetNamedItem(ElementAttribute attribute) {
            return null;
        }
    }
}
