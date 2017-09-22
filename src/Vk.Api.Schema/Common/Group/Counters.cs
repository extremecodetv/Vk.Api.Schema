using Newtonsoft.Json;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Класс для десериализации <see cref="ICounters"/>
    /// </summary>
    public sealed class Counters : ICounters
    {
#pragma warning disable 1591

        private Counters() { }

        [JsonProperty("photos")]
        public int? PhotosCount { get; set; }

        [JsonProperty("albums")]
        public int? AlbumsCount { get; set; }

        [JsonProperty("audios")]
        public int? AudiosCount { get; set; }

        [JsonProperty("videos")]
        public int? VideosCount { get; set; }

        [JsonProperty("topics")]
        public int? TopicsCount { get; set; }

        [JsonProperty("docs")]
        public int? DocsCount { get; set; }
    }
}