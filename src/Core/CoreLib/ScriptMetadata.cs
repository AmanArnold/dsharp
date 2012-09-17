// ScriptMetadata.cs
// Script#/Libraries/CoreLib
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.CompilerServices {

    /// <summary>
    /// This attribute can be placed on types in system script assemblies that should not
    /// be imported. It is only meant to be used within mscorlib.dll.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class NonScriptableAttribute : Attribute {
    }

    /// <summary>
    /// This attribute can be placed on types that should not be emitted into generated
    /// script, as they represent existing script or native types.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Delegate | AttributeTargets.Struct)]
    [NonScriptable]
    [Imported]
    public sealed class ImportedAttribute : Attribute {
    }

    /// <summary>
    /// Marks an assembly as a script assembly that can be used with Script#.
    /// Additionally, each script must have a unique name that can be used as
    /// a dependency name.
    /// This name is also used to generate unique names for internal types defined
    /// within the assembly. The ScriptQualifier attribute can be used to provide a
    /// shorter name if needed.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class ScriptAssemblyAttribute : Attribute {

        private string _name;

        public ScriptAssemblyAttribute(string name) {
            _name = name;
        }

        public string Name {
            get {
                return _name;
            }
        }
    }

    /// <summary>
    /// Marks a type with a script dependency that is required at runtime.
    /// The specified name is used as the name of the dependency, and the runtime identifier.
    /// </summary>
    [AttributeUsage(AttributeTargets.Type, Inherited = false, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class ScriptDependencyAttribute : Attribute {

        private string _name;

        public ScriptDependencyAttribute(string name) {
            _name = name;
        }

        public string Name {
            get {
                return _name;
            }
        }
    }

    /// <summary>
    /// This attribute indicates that the namespace of type within a system assembly
    /// should be ignored at script generation time. It is useful for creating namespaces
    /// for the purpose of c# code that don't exist at runtime.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Delegate | AttributeTargets.Interface | AttributeTargets.Struct, Inherited = true, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class IgnoreNamespaceAttribute : Attribute {
    }

    /// <summary>
    /// This attribute can be placed on a static class that only contains static string
    /// fields representing a set of resource strings.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    [NonScriptable]
    [Imported]
    public sealed class ResourcesAttribute : Attribute {
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class ScriptExtensionAttribute : Attribute {

        private string _expression;

        public ScriptExtensionAttribute(string extendeeExpression) {
            _expression = extendeeExpression;
        }

        public string Expression {
            get {
                return _expression;
            }
        }
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class ScriptModuleAttribute : Attribute {
    }

    /// <summary>
    /// This attribute marks an enumeration type within a system assembly as as a set of
    /// names. Rather than the specific value, the name of the enumeration field is
    /// used as a string.
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class NamedValuesAttribute : Attribute {
    }

    /// <summary>
    /// This attribute marks an enumeration type within a system assembly as as a set of
    /// numeric values. Rather than the enum field, the value of the enumeration field is
    /// used as a literal.
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class NumericValuesAttribute : Attribute {
    }

    /// <summary>
    /// This attribute allows defining an alternate method signature that is not generated
    /// into script, but can be used for defining overloads to enable optional parameter semantics
    /// for a method. It must be applied on a method defined as extern, since an alternate signature
    /// method does not contain an actual method body.
    /// </summary>
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class AlternateSignatureAttribute : Attribute {
    }

    /// <summary>
    /// This attribute denotes a C# property that manifests like a field in the generated
    /// JavaScript (i.e. is not accessed via get/set methods). This is really meant only
    /// for use when defining OM corresponding to native objects exposed to script.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class IntrinsicPropertyAttribute : Attribute {
    }

    /// <summary>
    /// Allows specifying the name to use for a type or member in the generated script.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Event, Inherited = false, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class ScriptNameAttribute : Attribute {

        private string _name;

        public ScriptNameAttribute(string name) {
            _name = name;
        }

        public string Name {
            get {
                return _name;
            }
        }
    }

    /// <summary>
    /// This attribute allows suppressing the default behavior of converting
    /// member names to camel-cased equivalents in the generated JavaScript.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class PreserveCaseAttribute : Attribute {
    }

    /// <summary>
    /// This attribute allows suppressing the default behavior of minimizing
    /// private type names and member names in the generated JavaScript.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class PreserveNameAttribute : Attribute {
    }

    /// <summary>
    /// This attribute allows specifying a script name for an imported method.
    /// The method is interpreted as a global method. As a result it this attribute
    /// only applies to static methods.
    /// </summary>
    // REVIEW: Eventually do we want to support this on properties/field and instance methods as well?
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class ScriptAliasAttribute : Attribute {

        private string _alias;

        public ScriptAliasAttribute(string alias) {
            _alias = alias;
        }

        public string Alias {
            get {
                return _alias;
            }
        }
    }

    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class ScriptSkipAttribute : Attribute {
    }

    [AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
    [NonScriptable]
    [Imported]
    public sealed class ScriptOutputAttribute : Attribute {

        private string _header;
        private string _footer;

        public ScriptOutputAttribute(string header)
            : this(header, String.Empty) {
        }

        public ScriptOutputAttribute(string header, string footer) {
            _header = header;
            _footer = footer;
        }

        public string Footer {
            get {
                return _footer;
            }
        }

        public string Header {
            get {
                return _header;
            }
        }
    }
}
