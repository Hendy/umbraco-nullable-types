using ClientDependency.Core;
using System.Collections.Generic;
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

        public NullableIntegerPropertyEditor() : base()
        {
            this.DefaultPreValues = new Dictionary<string, object>
            {
                { "defaultCheckboxState", "1" },
                { "hideValueWhenNull", "1" },
                { "minimumValue", int.MinValue.ToString() },
                { "maximumValue", int.MaxValue.ToString() },
                { "stepSize", "1" }
            };
        }

        protected override PreValueEditor CreatePreValueEditor()
        {
            return new NullableIntegerPreValueEditor();
        }
    }
}
