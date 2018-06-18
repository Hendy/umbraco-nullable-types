using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.NullableTypes.PropertyEditors
{
    internal class NullableIntegerPreValueEditor : PreValueEditor
    {
        [PreValueField(
            "defaultCheckboxState",
            "Default Checkbox State",
            "boolean",
            Description = "When checked, the number field is initially active (non null mode)")]
        public bool DefaultCheckboxState { get; set; }

        [PreValueField(
            "hideValueWhenNull",
            "Hide Value When Null",
            "boolean",
            Description = "When checked, any value in the number field will be hidden in null mode")]
        public bool HideValueWhenNull { get; set; }
    }
}
