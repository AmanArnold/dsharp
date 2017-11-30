// ScriptMetadata.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
using System.Runtime.CompilerServices;

namespace System
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
    [ScriptIgnore]
    public sealed class ScriptTemplateAttribute : Attribute
    {
        private string _template;

        public ScriptTemplateAttribute(string template)
        {
            _template = template;
        }

        public string Template
        {
            get
            {
                return _template;
            }
        }
    }
}