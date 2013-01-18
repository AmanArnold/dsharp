﻿using System;
using System.Runtime.CompilerServices;

namespace System.Html.Data {

    [ScriptIgnoreNamespace]
    [ScriptImport]
    public sealed class IDBTransaction {

        private IDBTransaction() {
        }

        [ScriptField]
        public string Mode {
            get { return null; }
        }

        [ScriptField]
        public IDBDatabase Db {
            get { return null; }
        }

        [ScriptField]
        public object Error {
            get { return null; }
        }

        public IDBObjectStore ObjectStore(string name) {
            return null;
        }

        public void Abort() {
        }

        [ScriptName("onabort")]
        public IDBTransactionDelegate OnAbort;

        [ScriptName("oncomplete")]
        public IDBTransactionDelegate OnComplete;

        [ScriptName("onerror")]
        public IDBTransactionDelegate OnError;

    }

    [ScriptIgnoreNamespace]
    [ScriptImport]
    public delegate void IDBTransactionDelegate(IDBEvent<IDBTransaction> e);

}
