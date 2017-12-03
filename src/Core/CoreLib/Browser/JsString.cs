using System;
using System.Runtime.CompilerServices;

namespace Browser
{
    [ScriptIgnoreNamespace]
    [ScriptImport]
    [ScriptName("String")]
    public sealed class JsString
    {
        private JsString()
        {
        }
        /// <summary>
        /// Retrieves the character at the specified position.
        /// </summary>
        /// <param name="index">The specified 0-based position.</param>
        /// <returns>The character within the string.</returns>
        public extern char CharAt(int index);

        /// <summary>
        /// Retrieves the character code of the character at the specified position.
        /// </summary>
        /// <param name="index">The specified 0-based position.</param>
        /// <returns>The character code of the character within the string.</returns>
        public extern int CharCodeAt(int index);

        /// <summary>
        /// Returns the unencoded version of a complete encoded URI.
        /// </summary>
        /// <returns>The unencoded string.</returns>
        [ScriptAlias("decodeURI")]
        public extern string DecodeUri();

        /// <summary>
        /// Returns the unencoded version of a single part or component of an encoded URI.
        /// </summary>
        /// <returns>The unencoded string.</returns>
        [ScriptAlias("decodeURIComponent")]
        public extern string DecodeUriComponent();

        /// <summary>
        /// Encodes the complete URI.
        /// </summary>
        /// <returns>The encoded string.</returns>
        [ScriptAlias("encodeURI")]
        public extern string EncodeUri();

        /// <summary>
        /// Encodes a single part or component of a URI.
        /// </summary>
        /// <returns>The encoded string.</returns>
        [ScriptAlias("encodeURIComponent")]
        public extern string EncodeUriComponent();

        /// <summary>
        /// Encodes a string by replacing punctuation, spaces etc. with their escaped equivalents.
        /// </summary>
        /// <returns>The escaped string.</returns>
        [ScriptAlias("escape")]
        public extern string Escape();

        [ScriptAlias("ss.string")]
        public extern static string FromChar(char ch, int count);

        public extern static string FromCharCode(int charCode);

        public extern static string FromCharCode(params int[] charCodes);

        public extern string[] Match(JsRegExp regex);

        [ScriptName("replace")]
        public extern string ReplaceFirst(string oldText, string replaceText);

        [ScriptName("replace")]
        public extern string ReplaceRegex(JsRegExp regex, string replaceText);

        [ScriptName("replace")]
        public extern string ReplaceRegex(JsRegExp regex, StringReplaceCallback callback);

        public extern int Search(JsRegExp regex);

        public extern string[] Split(JsRegExp regex);

        public extern string[] Split(JsRegExp regex, int limit);


        public extern string[] Split(char separator, int limit);

        public extern string[] Split(string separator, int limit);

        public extern string Substr(int startIndex);

        public extern string Substr(int startIndex, int length);

        public extern string ToLocaleLowerCase();

        public extern string ToLocaleUpperCase();

        [Obsolete("ToLowerCase() should not be used, switch to ToLower()")]
        public extern string ToLowerCase();

        [Obsolete("ToUpperCase() should not be used, switch to ToUpper()")]
        public extern string ToUpperCase();

        /// <summary>
        /// Decodes a string by replacing escaped parts with their equivalent textual representation.
        /// </summary>
        /// <returns>The unescaped string.</returns>
        [ScriptAlias("unescape")]
        public extern string Unescape();

        public static extern implicit operator JsString(string str);

        public static extern implicit operator string(JsString str);
    }
}