using System;
using System.Linq;
using System.Net.Http;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;

namespace Vk.Api.Schema.Serialization.Http
{
    internal static class HttpPostConverter
    {
        public static FormUrlEncodedContent SerializeObject(object source)
        {
            return new FormUrlEncodedContent(source.ToDictionary());
        }

        private static IDictionary<string, string> ToDictionary(this object source)
        {
            if (source == null)
                ThrowExceptionWhenSourceArgumentIsNull();

            var dictionary = new Dictionary<string, string>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(source))
            {
                AddPropertyToDictionary(property, source, dictionary);
            }

            return dictionary;
        }

        private static void AddPropertyToDictionary(PropertyDescriptor property, object source, Dictionary<string, string> dictionary)
        {
            var attribute = property.Attributes.OfType<HttpPropertyAttribute>().FirstOrDefault();
            if (attribute != null)
            {
                object obj   = property.GetValue(source);
                string value = string.Empty;

                if (attribute.Required == HttpRequired.DisallowNull && obj == null)
                {
                    return;
                }
                else if (attribute.Required == HttpRequired.Always && obj == null)
                {
                    throw new ArgumentException($"Property {property.Name} cannot be null");
                }

                var type = GetPropertyType(property);

                switch (type)
                {
                    case PropertyType.Enum:
                        value = GetDescriptionAsParameters(obj as Enum);
                        break;
                    case PropertyType.Collection:
                        value = String.Join(",", obj as IEnumerable);
                        break;
                    default:
                        value = obj.ToString();
                        break;
                }

                dictionary.Add(attribute.ParameterName, value);
            }
        }
        
        private static PropertyType GetPropertyType(PropertyDescriptor property)
        {
            if (property.PropertyType.IsEnum)
            {
                return PropertyType.Enum;
            }

            if(property.PropertyType is IEnumerable)
            {
                return PropertyType.Collection;
            }

            return PropertyType.String;
        }

        private static string GetDescriptionAsParameters(Enum enumeration)
        {
            var descriptions = GetDescriptions(enumeration);
            return String.Join(",", descriptions);
        }

        private static IEnumerable<string> GetDescriptions(Enum enumeration)
        {
            var descriptions = new List<string>();

            foreach (Enum enumValue in Enum.GetValues(enumeration.GetType()))
            {
                if (enumeration.HasFlag(enumValue))
                {
                    descriptions.Add(GetEnumDescription(enumValue));
                }
            }

            return descriptions;
        }

        private static string GetEnumDescription(Enum enumeration)
        {
            var fieldInfo = enumeration.GetType().GetField(enumeration.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0
                ? attributes.First().Description
                : enumeration.ToString();
        }

        private static void ThrowExceptionWhenSourceArgumentIsNull()
        {
            throw new ArgumentNullException("source", "Unable to convert object to a dictionary. The source object is null.");
        }
    }
}
