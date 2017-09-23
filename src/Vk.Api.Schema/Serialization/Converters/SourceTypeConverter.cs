using System;
using Newtonsoft.Json;
using Vk.Api.Schema.Enums.Wall;

namespace Vk.Api.Schema.Serialization.Converters
{
    internal class SourceTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotImplementedException();

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.Value.ToString();
            SourceType? type = null;

            switch (value)
            {
                case "vk":
                    type = SourceType.Vk;
                    break;

                case "widget":
                    type = SourceType.Widget;
                    break;

                case "api":
                    type = SourceType.Api;
                    break;

                case "rss":
                    type = SourceType.Rss;
                    break;

                case "sms":
                    type = SourceType.Sms;
                    break;
                default:
                    break;
            }

            return type;
        }

        public override bool CanConvert(Type objectType) => true;
    }
}