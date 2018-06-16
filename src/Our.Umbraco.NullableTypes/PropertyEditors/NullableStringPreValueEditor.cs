using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.NullableTypes.PropertyEditors
{
    internal class NullableStringPreValueEditor : PreValueEditor
    {
        [PreValueField(
            "defaultCheckboxState", 
            "Default Checkbox State", 
            "boolean", 
            Description = "An active checkbox makes for an active textbox (whitespace instead of null)")]
        public bool DefaultCheckboxState { get; set; }
    }
}
