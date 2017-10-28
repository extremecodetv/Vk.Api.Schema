using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Vk.Api.Schema.Serialization.Http.Converters
{
    abstract class BaseHttpEnumConverter
    {
        protected internal string GetDescriptionAsParameters(Enum enumeration)
        {
            var descriptions = GetDescriptions(enumeration);
            return String.Join(",", descriptions);
        }

        protected internal IEnumerable<string> GetDescriptions(Enum enumeration)
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

        protected internal string GetEnumDescription(Enum enumeration)
        {
            var fieldInfo = enumeration.GetType().GetField(enumeration.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0
                ? attributes.First().Description
                : enumeration.ToString();
        }
    }
}
