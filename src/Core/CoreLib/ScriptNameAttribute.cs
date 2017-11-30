// ScriptMetadata.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
using System.Runtime.CompilerServices;

namespace System
{
    /// <summary>
    /// Allows specifying the name to use for a type or member in the generated script.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Event, Inherited = false, AllowMultiple = false)]
    [ScriptIgnore]
    public sealed class ScriptNameAttribute : Attribute
    {
        private string _name;
        private bool _preserveCase;
        private bool _preserveName;

        public ScriptNameAttribute()
        {
        }

        public ScriptNameAttribute(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public bool PreserveCase
        {
            get
            {
                return _preserveCase;
            }
            set
            {
                _preserveCase = true;
            }
        }

        public bool PreserveName
        {
            get
            {
                return _preserveName;
            }
            set
            {
                _preserveName = value;
            }
        }
    }
}