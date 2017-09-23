using System;
using Newtonsoft.Json;
using Vk.Api.Schema.Enums.Wall;
using Vk.Api.Schema.Serialization.Converters;

namespace Vk.Api.Schema.Common.Wall
{
    /// <summary>
    /// Класс для десериализации <see cref="IPostSource"/>
    /// </summary>
    public sealed class PostSource :IPostSource
    {

#pragma warning disable 1591

        private PostSource()
        {
        }

        [JsonProperty("type")]
        [JsonConverter(typeof(SourceTypeConverter))]
        public SourceType Type { get; set; }

        [JsonProperty("platfom")]
        [JsonConverter(typeof(SourcePlatformConverter))]
        public SourcePlatform? Platform { get; set; }

        [JsonProperty("data")]
        [JsonConverter(typeof(SourceDataConverter))]
        public SourceData? Data { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}