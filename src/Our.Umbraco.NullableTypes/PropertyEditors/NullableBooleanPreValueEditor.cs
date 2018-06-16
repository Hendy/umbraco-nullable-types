using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.NullableTypes.PropertyEditors
{
    internal class NullableBooleanPreValueEditor : PreValueEditor
    {
        [PreValueField("nullLabel", "Null Label", "textstring", Description = "")]
        public string NullLabel { get; set; }

        [PreValueField("falseLabel", "False Label", "textstring", Description = "")]
        public string FalseLabel { get; set; }

        [PreValueField("trueLabel", "True Label", "textstring", Description = "")]
        public string TrueLabel { get; set; }
    }
}
