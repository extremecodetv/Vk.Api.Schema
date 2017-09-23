using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Vk.Api.Schema.Common.Media;
using Vk.Api.Schema.Common.Wall;
using Vk.Api.Schema.Serialization.Converters;

namespace Vk.Api.Schema.Common.Board
{
    /// <summary>
    /// Класс для десериализации <see cref="IBoardComment"/>
    /// </summary>
    public sealed class BoardComment : IBoardComment
    {
#pragma warning disable 1591

        private BoardComment()
        {
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("from_id")]
        public int FromId { get; set; }

        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Date { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("attachments")] //TODO: Attachments
        public IEnumerable<IAttachment> Attachments { get; set; }

        [JsonProperty("likes")]
        [JsonConverter(typeof(TypeConverter<Likes>))]
        public ILikes Likes { get; set; }
    }
}