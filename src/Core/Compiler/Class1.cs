using System.Diagnostics;

namespace ScriptSharp
{
    public class AssertHelper
    {
        public static void Assert(bool condition, string message = null)
        {
#if DEBUG
            if(!condition)
            {
                if(Debugger.IsAttached)
                {
                    Debugger.Break();
                }
                else
                {
                    Debugger.Launch();
                }
            }
#endif
            Debug.Assert(condition, message);
        }
    }
}
