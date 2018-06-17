using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Our.Umbraco.EmbeddedResource;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Our.Umbraco.NullableTypes")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Our.Umbraco.NullableTypes")]
[assembly: AssemblyCopyright("Copyright ©  2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b8161b5f-edef-48b4-8939-60c690bb0217")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("0.2.0.0")]
[assembly: AssemblyFileVersion("0.2.0.0")]

// register the embedded resoures (authenticated Umbraco users only)
[assembly: EmbeddedResourceProtected("Our.Umbraco.NullableTypes.Resources.NullableBoolean.css", "~/App_Plugins/NullableTypes/NullableBoolean.css")]
[assembly: EmbeddedResourceProtected("Our.Umbraco.NullableTypes.Resources.NullableBoolean.html", "~/App_Plugins/NullableTypes/NullableBoolean.html")]
[assembly: EmbeddedResourceProtected("Our.Umbraco.NullableTypes.Resources.NullableBoolean.js", "~/App_Plugins/NullableTypes/NullableBoolean.js")]

[assembly: EmbeddedResourceProtected("Our.Umbraco.NullableTypes.Resources.NullableString.css", "~/App_Plugins/NullableTypes/NullableString.css")]
[assembly: EmbeddedResourceProtected("Our.Umbraco.NullableTypes.Resources.NullableString.html", "~/App_Plugins/NullableTypes/NullableString.html")]
[assembly: EmbeddedResourceProtected("Our.Umbraco.NullableTypes.Resources.NullableString.js", "~/App_Plugins/NullableTypes/NullableString.js")]

[assembly: EmbeddedResourceProtected("Our.Umbraco.NullableTypes.Resources.NullableInteger.css", "~/App_Plugins/NullableTypes/NullableInteger.css")]
[assembly: EmbeddedResourceProtected("Our.Umbraco.NullableTypes.Resources.NullableInteger.html", "~/App_Plugins/NullableTypes/NullableInteger.html")]
[assembly: EmbeddedResourceProtected("Our.Umbraco.NullableTypes.Resources.NullableInteger.js", "~/App_Plugins/NullableTypes/NullableInteger.js")]
