using ClientDependency.Core;
using System.Collections.Generic;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Our.Umbraco.NullableTypes.PropertyEditors
{
    [PropertyEditor(PropertyEditorAlias, "Nullable Boolean", "~/App_Plugins/NullableTypes/NullableBoolean.html", ValueType = "JSON")]
    [PropertyEditorAsset(ClientDependencyType.Css, "~/App_Plugins/NullableTypes/NullableBoolean.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, "~/App_Plugins/NullableTypes/NullableBoolean.js")]
    public class NullableBooleanPropertyEditor : PropertyEditor
    {
        public const string PropertyEditorAlias = "Our.Umbraco.NullableTypes.NullableBoolean";

        public NullableBooleanPropertyEditor() : base()
        {
            this.DefaultPreValues = new Dictionary<string, object>
            {
                { "nullLabel", "Null" },
                { "falseLabel", "False" },
                { "trueLabel", "True" }
            };
        }

        protected override PreValueEditor CreatePreValueEditor()
        {
            return new NullableBooleanPreValueEditor();
        }
    }
}
