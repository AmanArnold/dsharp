﻿using System;
using System.Runtime.CompilerServices;

namespace System.Html.Data {

    [ScriptIgnoreNamespace]
    [ScriptImport]
    public sealed class IDBDatabase : IDBEventTarget {

        private IDBDatabase() {
        }

        [ScriptField]
        public string Name {
            get { return default(string); }
        }

        [ScriptField]
        public long Version {
            get { return default(long); }
        }

        [ScriptField]
        public string[] ObjectStoreNames {
            get { return default(string[]); }
        }

        public IDBObjectStore CreateObjectStore(string name) {
            return default(IDBObjectStore);
        }

        public IDBObjectStore CreateObjectStore(string name, IDBObjectStoreParameters optionalParameters) {
            return default(IDBObjectStore);
        }

        public void DeleteObjectStore(string name) {
        }
        
        public IDBTransaction Transaction(string[] storenames) {
            return default(IDBTransaction);
        }

        public IDBTransaction Transaction(string[] storenames, string mode) {
            return default(IDBTransaction);
        }

        public void Close() {
        }

        [ScriptName("onabort")]
        public IDBDatabaseCallback OnAbort;

        [ScriptName("onerror")]
        public IDBDatabaseCallback OnError;

        [ScriptName("onversionchange")]
        public IDBDatabaseVersionChangeCallback OnVersionChange;
    }

    [ScriptIgnoreNamespace]
    [ScriptImport]
    public delegate void IDBDatabaseCallback(IDBEvent<IDBDatabase> e);

    [ScriptIgnoreNamespace]
    [ScriptImport]
    public delegate void IDBDatabaseVersionChangeCallback(IDBVersionChangeEvent<IDBDatabase> e);

}
