using System;
using Newtonsoft.Json;
using Vk.Api.Schema.Serialization.Converters;

namespace Vk.Api.Schema.Common.Board
{
    /// <summary>
    /// Класс для десериализации <see cref="ITopic"/>
    /// </summary>
    public sealed class Topic : ITopic
    {
#pragma warning disable 1591

        private Topic()
        {
        }
        
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Date { get; set; }

        [JsonProperty("created_by")]
        public int CreatedBy { get; set; }

        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime UpdateTime { get; set; }

        [JsonProperty("updated_by")]
        public int UpdatedBy { get; set; }

        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("is_fixed")]
        public bool IsFixed { get; set; }

        [JsonProperty("comments")]
        public int CommentsCount { get; set; }

        [JsonProperty("first_comment")]
        public string FirstComment { get; set; }

        [JsonProperty("last_comment")]
        public string LastComment { get; set; }
    }
}