using Newtonsoft.Json.Linq;
using Our.Umbraco.NullableTypes.PropertyEditors;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.NullableTypes.Converters
{
    [PropertyValueType(typeof(int?))]
    [PropertyValueCache(PropertyCacheValue.All, PropertyCacheLevel.Content)]
    public class NullableIntegerPropertyValueConverter : PropertyValueConverterBase
    {
        /// <summary>
        /// Check to see if this property value converter should take effect for the supplied published property type
        /// </summary>
        /// <param name="publishedPropertyType"></param>
        /// <returns></returns>
        public override bool IsConverter(PublishedPropertyType publishedPropertyType)
        {
            return publishedPropertyType.PropertyEditorAlias == NullableIntegerPropertyEditor.PropertyEditorAlias;
        }

        /// <summary>
        /// Convert the saved value into a nullable integer
        /// </summary>
        /// <param name="publishedPropertyType"></param>
        /// <param name="source">The saved json from the property editor</param>
        /// <param name="preview"></param>
        /// <returns>A <see cref="CheckboxTable"/> object</returns>
        public override object ConvertSourceToObject(PublishedPropertyType publishedPropertyType, object source, bool preview)
        {
            int? nullableInteger = null;

            if (source != null)
            {
                if (source is int)
                {
                    nullableInteger = (int)source;
                }
                else if (source is string)
                {
                    var sourceString = source.ToString();

                    if (int.TryParse(sourceString, out int sourceStringParsed))
                    {
                        nullableInteger = sourceStringParsed;
                    }
                    else
                    {
                        try
                        {
                            var value = JObject.Parse(sourceString);

                            if (value.Type == JTokenType.Object)
                            {
                                var checkbox = (bool)value["checkbox"];
                                var number = (string)value["number"];

                                if (checkbox)
                                {
                                    if (int.TryParse(number, out int numberParsed))
                                    {
                                        nullableInteger = numberParsed;
                                    }
                                }
                            }
                        }
                        catch
                        {
                        }
                    }
                }
            }

            return nullableInteger;
        }
    }
}
