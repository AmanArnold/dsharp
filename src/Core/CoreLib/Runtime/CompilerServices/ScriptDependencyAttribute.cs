namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Marks a type with a script dependency that is required at runtime.
    /// The specified name is used as the name of the dependency, and the runtime identifier.
    /// </summary>
    [AttributeUsage(AttributeTargets.Type, Inherited = false, AllowMultiple = false)]
    [ScriptIgnore]
    [ScriptImport]
    public sealed class ScriptDependencyAttribute : Attribute
    {
        private string _name;
        private string _identifier;

        public ScriptDependencyAttribute(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Identifier
        {
            get
            {
                return _identifier;
            }
            set
            {
                _identifier = value;
            }
        }
    }
}