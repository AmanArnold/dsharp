namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Event, Inherited = true, AllowMultiple = false)]
    [ScriptIgnore]
    public sealed class ScriptEventAttribute : Attribute
    {
        private string _addAccessor;
        private string _removeAccessor;

        public ScriptEventAttribute(string addAccessor, string removeAccessor)
        {
            _addAccessor = addAccessor;
            _removeAccessor = removeAccessor;
        }

        public string AddAccessor
        {
            get
            {
                return _addAccessor;
            }
        }

        public string RemoveAccessor
        {
            get
            {
                return _removeAccessor;
            }
        }
    }
}