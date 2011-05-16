// Type.cs
// Script#/Libraries/CoreLib
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System {

    /// <summary>
    /// The Type data type which is mapped to the Function type in Javascript.
    /// </summary>
    [IgnoreNamespace]
    [Imported]
    public sealed class Type {

        public Type BaseType {
            get {
                return null;
            }
        }

        public string FullName {
            get {
                return null;
            }
        }

        public string Name {
            get {
                return null;
            }
        }

        /// <summary>
        /// Gets the prototype associated with the type.
        /// </summary>
        [IntrinsicProperty]
        public Dictionary Prototype {
            get {
                return null;
            }
        }

        public static void AddHandler(object instance, string name, Delegate handler) {
        }

        public static void AddHandler(Type type, string name, Delegate handler) {
        }

        public static object CreateInstance(Type type, params object[] arguments) {
            return null;
        }

        public static void DeleteField(object instance, string name) {
        }

        public static void DeleteField(Type type, string name) {
        }

        public static object GetField(object instance, string name) {
            return null;
        }

        public static object GetField(Type type, string name) {
            return null;
        }

        public static object GetField(object instance, Enum name) {
            return null;
        }

        public Type[] GetInterfaces() {
            return null;
        }

        public static object GetProperty(object instance, string name) {
            return null;
        }

        public static object GetProperty(Type type, string name) {
            return null;
        }

        public static string GetScriptType(object instance) {
            return null;
        }

        public static Type GetType(string typeName) {
            return null;
        }

        public static bool HasField(object instance, string name) {
            return false;
        }

        public static bool HasField(Type type, string name) {
            return false;
        }

        public static bool HasMethod(object instance, string name) {
            return false;
        }

        public static bool HasMethod(Type type, string name) {
            return false;
        }

        public static bool HasProperty(object instance, string name) {
            return false;
        }

        public static bool HasProperty(Type type, string name) {
            return false;
        }

        public static object InvokeMethod(object instance, string name, params object[] args) {
            return null;
        }

        public static object InvokeMethod(Type type, string name, params object[] args) {
            return null;
        }

        public bool IsAssignableFrom(Type type) {
            return false;
        }

        public static bool IsClass(Type type) {
            return false;
        }

        public static bool IsEnum(Type type) {
            return false;
        }

        public static bool IsFlags(Type type) {
            return false;
        }

        public static bool IsInterface(Type type) {
            return false;
        }

        public static bool IsNamespace(object obj) {
            return false;
        }

        public bool IsInstanceOfType(object instance) {
            return false;
        }

        public static Type Parse(string s) {
            return null;
        }

        public static void RemoveHandler(object instance, string name, Delegate handler) {
        }

        public static void RemoveHandler(Type type, string name, Delegate handler) {
        }

        public static void SetField(object instance, string name, object value) {
        }

        public static void SetField(object instance, Enum name, object value) {
        }

        public static void SetField(Type type, string name, object value) {
        }

        public static void SetProperty(object instance, string name, object value) {
        }

        public static void SetProperty(Type type, string name, object value) {
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Type GetTypeFromHandle(RuntimeTypeHandle typeHandle) {
            return null;
        }
    }
}
