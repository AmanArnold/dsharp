// ScriptMetadata.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
using System.Runtime.CompilerServices;

namespace System
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = true)]
    [ScriptIgnore]
    [ScriptImport]
    public sealed class ScriptReferenceAttribute : Attribute
    {
        private string _name;

        private string _identifier;
        private string _path;
        private bool _delayLoad;

        public ScriptReferenceAttribute(string name)
        {
            _name = name;
        }

        public bool DelayLoad
        {
            get
            {
                return _delayLoad;
            }
            set
            {
                _delayLoad = value;
            }
        }

        public string Identifier
        {
            get
            {
                return _identifier;
            }
            set
            {
                _identifier = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value;
            }
        }
    }
}