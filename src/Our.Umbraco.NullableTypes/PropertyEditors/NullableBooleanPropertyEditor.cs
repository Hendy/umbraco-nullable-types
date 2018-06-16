using ClientDependency.Core;
using System.Collections.Generic;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Our.Umbraco.NullableTypes.PropertyEditors
{
    [PropertyEditor(PropertyEditorAlias, "Nullable Boolean", "~/App_Plugins/NullableBoolean/NullableBoolean.html", ValueType = "JSON")]
    [PropertyEditorAsset(ClientDependencyType.Css, "~/App_Plugins/NullableBoolean/NullableBoolean.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, "~/App_Plugins/NullableBoolean/NullableBoolean.js")]
    public class NullableBooleanPropertyEditor : PropertyEditor
    {
        public const string PropertyEditorAlias = "Our.Umbraco.NullableBoolean";

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
