using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.NullableTypes.PropertyEditors
{
    internal class NullableStringPreValueEditor : PreValueEditor
    {
        [PreValueField(
            "defaultCheckboxState", 
            "Default Checkbox State", 
            "boolean",
            Description = "When checked, the textbox is initially active (non null mode)")]
        public bool DefaultCheckboxState { get; set; }

        [PreValueField(
            "hideTextWhenNull",
            "Hide Text When Null",
            "boolean",
            Description = "When checked, any text in the textbox will be hidden in null mode")]
        public bool HideTextWhenNull { get; set; }

        [PreValueField(
            "textboxStyle", 
            "Textbox Style", 
            "textstring", 
            Description = "Optional style attributes for the textbox")]
        public string TextboxStyle { get; set; }
    }
}
