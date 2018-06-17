using ClientDependency.Core;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Our.Umbraco.NullableTypes.PropertyEditors
{
    [PropertyEditor(PropertyEditorAlias, "Nullable Integer", "~/App_Plugins/NullableTypes/NullableInteger.html", ValueType = "JSON")]
    [PropertyEditorAsset(ClientDependencyType.Css, "~/App_Plugins/NullableTypes/NullableInteger.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, "~/App_Plugins/NullableTypes/NullableInteger.js")]
    public class NullableIntegerPropertyEditor : PropertyEditor
    {
        public const string PropertyEditorAlias = "Our.Umbraco.NullableTypes.NullableInteger";

        protected override PreValueEditor CreatePreValueEditor()
        {
            return new NullableIntegerPreValueEditor();
        }
    }
}
