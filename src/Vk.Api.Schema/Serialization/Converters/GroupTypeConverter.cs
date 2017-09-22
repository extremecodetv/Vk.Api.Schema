using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Vk.Api.Schema.Enums.Group;

namespace Vk.Api.Schema.Serialization.Converters
{
    internal class GroupTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = (string)reader.Value;
            GroupType? group;

            switch (value)
            {
                case "page":
                    group = GroupType.Page;
                    break;
                case "group":
                    group = GroupType.Group;
                    break;
                case "event":
                    group = GroupType.Event;
                    break;
                default:
                    group = null;
                    break;
            }

            return group;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
