// String.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System
{
    /// <summary>
    /// Equivalent to the String type in Javascript.
    /// </summary>
    [ScriptIgnoreNamespace]
    [ScriptImport]
    public sealed class String
    {
        /// <summary>
        /// An empty zero-length string.
        /// </summary>
        public static readonly String Empty = "";

        /// <summary>
        /// The number of characters in the string.
        /// </summary>
        [ScriptField]
        public extern int Length { get; }

        /// <summary>
        /// Retrieves the character at the specified position.
        /// </summary>
        /// <param name="index">The specified 0-based position.</param>
        /// <returns>The character within the string.</returns>
        [ScriptField]
        public extern char this[int index] { get; }

        [ScriptAlias("ss.compareStrings")]
        public static extern int Compare(string s1, string s2);

        [ScriptAlias("ss.compareStrings")]
        public static extern int Compare(string s1, string s2, bool ignoreCase);

        [ScriptAlias("ss.string")]
        public static extern string Concat(string s1, string s2);

        [ScriptAlias("ss.string")]
        public static extern string Concat(string s1, string s2, string s3);

        [ScriptAlias("ss.string")]
        public static extern string Concat(string s1, string s2, string s3, string s4);

        /// <summary>
        /// Concatenates a set of individual strings into a single string.
        /// </summary>
        /// <param name="strings">The sequence of strings</param>
        /// <returns>The concatenated string.</returns>
        [ScriptAlias("ss.string")]
        public static extern string Concat(params string[] strings);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [ScriptAlias("ss.string")]
        public static extern string Concat(object o1, object o2);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [ScriptAlias("ss.string")]
        public static extern string Concat(object o1, object o2, object o3);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [ScriptAlias("ss.string")]
        public static extern string Concat(object o1, object o2, object o3, object o4);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [ScriptAlias("ss.string")]
        public static extern string Concat(params object[] o);

        /// <summary>
        /// Determines if the string ends with the specified character.
        /// </summary>
        /// <param name="value">The character to test for.</param>
        /// <returns>true if the string ends with the character; false otherwise.</returns>
        [ScriptAlias("ss.endsWith")]
        public extern bool EndsWith(char value);

        /// <summary>
        /// Determines if the string ends with the specified substring or suffix.
        /// </summary>
        /// <param name="value">The string to test for.</param>
        /// <returns>true if the string ends with the suffix; false otherwise.</returns>
        [ScriptAlias("ss.endsWith")]
        public extern bool EndsWith(string value);

        [ScriptAlias("ss.format")]
        public static extern string Format(string format, params object[] values);

        [ScriptAlias("ss.format")]
        [Obsolete("This is a non standard interface. Please migrate away")]
        public static extern string Format(CultureInfo culture, string format, params object[] values);

        public extern int IndexOf(char value);

        public extern int IndexOf(string value);

        public extern int IndexOf(char value, int startIndex);

        public extern int IndexOf(string value, int startIndex);

        [ScriptAlias("ss.insertString")]
        public extern string Insert(int index, string value);

        [ScriptAlias("ss.emptyString")]
        public static extern bool IsNullOrEmpty(string value);

        [ScriptAlias("ss.whitespace")]
        public static extern bool IsNullOrWhiteSpace(string value);

        public extern int LastIndexOf(char value);

        public extern int LastIndexOf(string value);

        public extern int LastIndexOf(char value, int startIndex);

        public extern int LastIndexOf(string value, int startIndex);

        [ScriptAlias("ss.padLeft")]
        public extern string PadLeft(int totalWidth);

        [ScriptAlias("ss.padLeft")]
        public extern string PadLeft(int totalWidth, char paddingChar);

        [ScriptAlias("ss.padRight")]
        public extern string PadRight(int totalWidth);

        [ScriptAlias("ss.padRight")]
        public extern string PadRight(int totalWidth, char paddingChar);

        [ScriptAlias("ss.removeString")]
        public extern string Remove(int index);

        [ScriptAlias("ss.removeString")]
        public extern string Remove(int index, int count);

        [ScriptAlias("ss.replaceString")]
        public extern string Replace(string oldValue, string newValue);

        [ScriptAlias("ss.splitString")]
        public extern string[] Split(params char[] separator);

        [ScriptAlias("ss.splitString")]
        public extern string[] Split(params string[] separator);

        [ScriptAlias("ss.startsWith")]
        public extern bool StartsWith(char value);

        [ScriptAlias("ss.startsWith")]
        public extern bool StartsWith(string prefix);

        public extern string Substring(int startIndex);

        public extern string Substring(int startIndex, int endIndex);

        [ScriptName("toLowerCase")]
        public extern string ToLower();

        [ScriptName("toUpperCase")]
        public extern string ToUpper();

        [ScriptAlias("ss.trim")]
        public extern string Trim();

        [ScriptAlias("ss.trim")]
        public extern string Trim(params char[] trimCharacters);

        [ScriptAlias("ss.trimEnd")]
        public extern string TrimEnd(params char[] trimCharacters);

        [ScriptAlias("ss.trimStart")]
        public extern string TrimStart(params char[] trimCharacters);

        /// <internalonly />
        public extern static bool operator ==(string s1, string s2);

        /// <internalonly />
        public extern static bool operator !=(string s1, string s2);
    }
}