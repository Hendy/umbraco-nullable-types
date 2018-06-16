using ClientDependency.Core;
using System.Collections.Generic;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Our.Umbraco.NullableTypes.PropertyEditors
{
    [PropertyEditor(PropertyEditorAlias, "Nullable String", "~/App_Plugins/NullableTypes/NullableString.html", ValueType = "JSON")]
    [PropertyEditorAsset(ClientDependencyType.Css, "~/App_Plugins/NullableTypes/NullableString.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, "~/App_Plugins/NullableTypes/NullableString.js")]
    public class NullableStringPropertyEditor : PropertyEditor
    {
        public const string PropertyEditorAlias = "Our.Umbraco.NullableTypes.NullableString";

        public NullableStringPropertyEditor() : base()
        {
            this.DefaultPreValues = new Dictionary<string, object>
            {                
            };
        }

        protected override PreValueEditor CreatePreValueEditor()
        {
            return new NullableStringPreValueEditor();
        }
    }
}
