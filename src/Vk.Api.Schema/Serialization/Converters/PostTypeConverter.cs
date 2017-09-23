using System;
using Newtonsoft.Json;
using Vk.Api.Schema.Enums.Wall;

namespace Vk.Api.Schema.Serialization.Converters
{
    internal class PostTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotImplementedException();

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.Value.ToString();
            PostType? type = null;

            switch (value)
            {
                case "post":
                    type = PostType.Post;
                    break;
                case "copy":
                    type = PostType.Copy;
                    break;
                case "reply":
                    type = PostType.Reply;
                    break;
                case "postpone":
                    type = PostType.Postpone;
                    break;
                case "suggest":
                    type = PostType.Suggest;
                    break;
                default:
                    type = null;
                    break;
            }

            return type;
        }

        public override bool CanConvert(Type objectType) => true;
    }
}