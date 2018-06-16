using Our.Umbraco.NullableTypes.PropertyEditors;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.NullableTypes.Converters
{
    [PropertyValueType(typeof(bool?))]
    [PropertyValueCache(PropertyCacheValue.All, PropertyCacheLevel.Content)]
    public class NullableBooleanPropertyValueConverter : PropertyValueConverterBase
    {
        /// <summary>
        /// Check to see if this property value converter should take effect for the supplied published property type
        /// </summary>
        /// <param name="publishedPropertyType"></param>
        /// <returns></returns>
        public override bool IsConverter(PublishedPropertyType publishedPropertyType)
        {
            return publishedPropertyType.PropertyEditorAlias == NullableBooleanPropertyEditor.PropertyEditorAlias;
        }

        /// <summary>
        /// Convert the saved value into a nullable boolean
        /// </summary>
        /// <param name="publishedPropertyType"></param>
        /// <param name="source">The saved json from the property editor</param>
        /// <param name="preview"></param>
        /// <returns>A <see cref="CheckboxTable"/> object</returns>
        public override object ConvertSourceToObject(PublishedPropertyType publishedPropertyType, object source, bool preview)
        {
            switch (source.ToString())
            {
                case "0":
                    return false;

                case "1":
                    return true;

                default:
                    return null;
            }
        }
    }
}
