using System;
using System.Linq;
using System.Net.Http;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;

namespace Vk.Api.Schema.Serialization.Http
{
    /// <summary>
    /// Класс для сериализации объектов производных от <see cref="IBaseParameters"/> в <see cref="FormUrlEncodedContent"/>
    /// </summary>
    public static class HttpPostConverter
    {//TODO: Переделать тип для работы с конвертерами

        public static FormUrlEncodedContent SerializeObject(object source)
        {
            return new FormUrlEncodedContent(source.ToDictionary());
        }

        internal static IDictionary<string, string> ToDictionary(this object source)
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

                if (attribute.Required == HttpRequired.Default && obj == null)
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
                        //value = GetDescriptionAsParameters(obj as Enum);
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
        
        private static void ThrowExceptionWhenSourceArgumentIsNull()
        {
            throw new ArgumentNullException("source", "Unable to convert object to a dictionary. The source object is null.");
        }
    }
}
