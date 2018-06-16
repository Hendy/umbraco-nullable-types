using Our.Umbraco.NullableTypes.PropertyEditors;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;
using Newtonsoft.Json.Linq;



namespace Our.Umbraco.NullableTypes.Converters
{
    [PropertyValueType(typeof(string))]
    [PropertyValueCache(PropertyCacheValue.All, PropertyCacheLevel.Content)]
    public class NullableStringPropertyValueConverter : PropertyValueConverterBase
    {
        /// <summary>
        /// Check to see if this property value converter should take effect for the supplied published property type
        /// </summary>
        /// <param name="publishedPropertyType"></param>
        /// <returns></returns>
        public override bool IsConverter(PublishedPropertyType publishedPropertyType)
        {
            return publishedPropertyType.PropertyEditorAlias == NullableStringPropertyEditor.PropertyEditorAlias;
        }

        /// <summary>
        /// Convert the saved value into a string
        /// </summary>
        /// <param name="publishedPropertyType"></param>
        /// <param name="source">The saved json from the property editor</param>
        /// <param name="preview"></param>
        /// <returns>A <see cref="CheckboxTable"/> object</returns>
        public override object ConvertSourceToObject(PublishedPropertyType publishedPropertyType, object source, bool preview)
        {
            string nullableString = null;

            if (source != null)
            {
                var value = JObject.Parse((string)source);

                var checkbox = (bool)value["checkbox"];
                var text = (string)value["text"];

                if (checkbox)
                {
                    nullableString = text;
                }
            }

            return nullableString;
        }
    }
}
