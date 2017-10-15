using System;
using Newtonsoft.Json;
using Vk.Api.Schema.Common.Poll;
using Vk.Api.Schema.Enums.Wall;
using Vk.Api.Schema.Serialization.Converters;
using Vk.Api.Schema.Common.Media.Geo;

namespace Vk.Api.Schema.Common.Wall
{
    /// <summary>
    /// Класс для десериализации <see cref="IPost"/>
    /// </summary>
    public sealed class Post : IPost
    {
#pragma warning disable 1591

        private Post()
        {
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("from_id")]
        public int FromId { get; set; }

        [JsonProperty("date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Date { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("reply_owner_id")]
        public int? ReplyOwnerId { get; set; }

        [JsonProperty("reply_post_id")]
        public int? ReplyPostId { get; set; }

        [JsonProperty("friends_only")]
        public bool? IsFriendsOnly { get; set; }

        [JsonProperty("comments")]
        [JsonConverter(typeof(TypeConverter<Comments>))]
        public IComments Comments { get; set; }

        [JsonProperty("likes")]
        [JsonConverter(typeof(TypeConverter<Likes>))]
        public ILikes Likes { get; set; }

        [JsonProperty("reposts")]
        [JsonConverter(typeof(TypeConverter<Reposts>))]
        public IReposts Reposts { get; set; }

        [JsonProperty("views")]
        [JsonConverter(typeof(TypeConverter<Views>))]
        public IViews Views { get; set; }

        [JsonProperty("post_type")]
        [JsonConverter(typeof(PostTypeConverter))]
        public PostType? Type { get; set; }

        [JsonProperty("geo")]
        [JsonConverter(typeof(TypeConverter<Geo>)]
        public IGeo Geo { get; set; }

        [JsonProperty("post_source")]
        [JsonConverter(typeof(TypeConverter<PostSource>))]
        public IPostSource PostSource { get; set; }

        [JsonProperty("signer_id")]
        public int? SignerId { get; set; }

        [JsonProperty("can_pin")]
        public bool? CanPin { get; set; }

        [JsonProperty("can_delete")]
        public bool? CanDelete { get; set; }

        [JsonProperty("can_edit")]
        public bool? CanEdit { get; set; }

        [JsonProperty("is_pinned")]
        public bool? IsPinned { get; set; }

        [JsonProperty("marked_as_ads")]
        public bool? MarkedAsAds { get; set; }
    }
}