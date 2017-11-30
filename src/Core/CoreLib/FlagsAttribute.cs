// Runtime.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
using System.Runtime.CompilerServices;

namespace System
{
    [AttributeUsage(AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
    [ScriptIgnore]
    public sealed class FlagsAttribute : Attribute
    {
    }
}