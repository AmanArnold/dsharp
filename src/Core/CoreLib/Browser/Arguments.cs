// Arguments.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
using System;
using System.Runtime.CompilerServices;

namespace Browser
{
    /// <summary>
    /// Provides access to the arguments of the current function.
    /// </summary>
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("arguments")]
    public static class Arguments
    {
        /// <summary>
        /// Retrieves the arguments list.
        /// </summary>
        /// <returns>The arguments list.</returns>
        [ScriptAlias("arguments")]
        [ScriptField]
        public static extern object[] Current { get; }

        /// <summary>
        /// Retrieves the number of actual arguments passed to the function.
        /// </summary>
        /// <returns>The count of arguments.</returns>
        [ScriptField]
        public static extern int Length { get; }

        /// <summary>
        /// Retrieves the specified actual argument value passed to the
        /// function by index.
        /// </summary>
        /// <param name="index">The index of the argument to retrieve.</param>
        /// <returns>The value of the specified argument.</returns>
        public static extern object GetArgument(int index);

        /// <summary>
        /// Retrieves the specified actual argument value passed to the
        /// function by index.
        /// </summary>
        /// <param name="index">The index of the argument to retrieve.</param>
        /// <typeparam name="T">The type of the return value.</typeparam>
        /// <returns>The value of the specified argument.</returns>
        public static extern T GetArgument<T>(int index);

        [ScriptAlias("Array.toArray")]
        public static extern Array ToArray();
    }
}