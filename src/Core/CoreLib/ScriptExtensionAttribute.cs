// ScriptMetadata.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
using System.Runtime.CompilerServices;

namespace System
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    [ScriptIgnore]
    public sealed class ScriptExtensionAttribute : Attribute
    {
        private string _expression;

        public ScriptExtensionAttribute(string extendeeExpression)
        {
            _expression = extendeeExpression;
        }

        public string Expression
        {
            get
            {
                return _expression;
            }
        }
    }
}