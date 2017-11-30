using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
    [ScriptImport]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ScriptName("ss")]
    public static class RuntimeHelper
    {
        [ScriptName("getHashCode")]
        public extern static int GetHashCode(object obj);

        [ScriptSkip]
        public extern static void InitializeArray(Array array, RuntimeFieldHandle handle);
    }
}