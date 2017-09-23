using System;
using Newtonsoft.Json;
using Vk.Api.Schema.Enums.Wall;

namespace Vk.Api.Schema.Serialization.Converters
{
    internal class SourcePlatformConverter : JsonConverter
    {

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotImplementedException();

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.Value.ToString();
            SourcePlatform? platform = null;

            switch (value)
            {
                case "android":
                    platform = SourcePlatform.Android;
                    break;

                case "iphone":
                    platform = SourcePlatform.Iphone;
                    break;

                case "wphone":
                    platform = SourcePlatform.WindowsPhone;
                    break;
                default:
                    break;
            }

            return platform;
        }

        public override bool CanConvert(Type objectType) => true;
    }
}