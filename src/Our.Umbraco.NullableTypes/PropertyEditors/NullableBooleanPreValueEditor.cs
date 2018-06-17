using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.NullableTypes.PropertyEditors
{
    internal class NullableBooleanPreValueEditor : PreValueEditor
    {
        [PreValueField(
            "nullLabel", 
            "Null Label", 
            "textstring", 
            Description = "Label for the null state")]
        public string NullLabel { get; set; }

        [PreValueField(
            "falseLabel", 
            "False Label", 
            "textstring", 
            Description = "Label for the false state")]
        public string FalseLabel { get; set; }

        [PreValueField(
            "trueLabel", 
            "True Label", 
            "textstring", 
            Description = "Label for the true state")]
        public string TrueLabel { get; set; }
    }
}
