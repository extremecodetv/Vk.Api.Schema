using System;
using Newtonsoft.Json;
using Vk.Api.Schema.Enums.Wall;

namespace Vk.Api.Schema.Serialization.Converters
{
    internal class SourceDataConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotImplementedException();

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.Value.ToString();
            SourceData? data = null;

            switch (value)
            {
                case "profile_activity":
                    data = SourceData.ProfileActivity;
                    break;
                case "profile_photo":
                    data = SourceData.ProfilePhoto;
                    break;
                case "comments":
                    data = SourceData.Comments;
                    break;
                case "like":
                    data = SourceData.Like;
                    break;
                case "poll":
                    data = SourceData.Poll;
                    break;
                default:
                    break;
            }

            return data;
        }

        public override bool CanConvert(Type objectType) => true;
    }
}