using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.NullableTypes.PropertyEditors
{
    internal class NullableStringPreValueEditor : PreValueEditor
    {
        [PreValueField(
            "defaultCheckboxState", 
            "Default Checkbox State", 
            "boolean", 
            Description = "An active checkbox makes for an active textbox (whitespace instead of null mode)")]
        public bool DefaultCheckboxState { get; set; }

        [PreValueField(
            "hideTextWhenNull",
            "Hide Text When Null",
            "boolean",
            Description = "If checked, any text in the textbox will be hidden whilst it's deactivated (in null node)")]
        public bool HideTextWhenNull { get; set; }

        [PreValueField(
            "textboxStyle", 
            "Textbox Style", 
            "textstring", 
            Description = "Optional semicolon delimeted, style attribute values")]
        public string TextboxStyle { get; set; }
    }
}
