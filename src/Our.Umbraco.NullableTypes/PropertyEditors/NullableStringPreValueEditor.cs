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

        [PreValueField(
            "showTextWhenNull",
            "Show Text When Null",
            "boolean",
            Description = "If checked, any text in the textbox will remain visible whilst it's deactivated (in null node)")]
        public bool ShowTextWhenNull { get; set; }

        [PreValueField(
            "textboxStyle", 
            "Textbox Style", 
            "textstring", 
            Description = "Optional semicolon delimeted, style attribute values")]
        public string TextboxStyle { get; set; }
    }
}
