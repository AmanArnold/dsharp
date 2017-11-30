namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    [ScriptIgnore]
    public sealed class ScriptMethodAttribute : Attribute
    {
        private string _selector;

        public ScriptMethodAttribute(string selector)
        {
            _selector = selector;
        }

        public string Selector
        {
            get
            {
                return _selector;
            }
        }
    }
}