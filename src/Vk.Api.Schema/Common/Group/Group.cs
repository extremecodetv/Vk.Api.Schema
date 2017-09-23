using System;
using System.Collections.Generic;

using Vk.Api.Schema.Enums;
using Vk.Api.Schema.Enums.Group;

using Newtonsoft.Json;
using Vk.Api.Schema.Common.Market;
using Vk.Api.Schema.Common.Media.Geo;
using Vk.Api.Schema.Serialization.Converters;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Класс для десериализации <see cref="IGroup"/>
    /// </summary>
    public sealed class Group : IGroup
    {

#pragma warning disable 1591

        private Group() { }

        [JsonProperty("id", Required = Required.Always)]
        public int Id { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("is_closed")]
        public GroupClosedType Closed { get; set; }

        [JsonProperty("deactivated")]
        public BlockStatus? BlockStatus { get; set; }

        [JsonProperty("is_admin")]
        public bool? IsAdmin { get; set; }

        [JsonProperty("admin_level")]
        public AdminLevel? Level { get; set; }
        
        [JsonProperty("is_member")]
        public bool? IsMember { get; set; }
        
        [JsonProperty("invited_by")]
        public int? InvitedBy { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(GroupTypeConverter))]
        public GroupType? Type { get; set; }

        [JsonProperty("activity")]
        public string Activity { get; set; }

        [JsonProperty("age_limitss")]
        public AgeLimits? Limits { get; set; }

        [JsonProperty("ban_info")]
        [JsonConverter(typeof(TypeConverter<BanInfo>))]
        public IBanInfo BanInfo { get; set; }

        [JsonProperty("can_create_topic")]
        public bool? CanCreateTopic { get; set; }

        [JsonProperty("can_message")]
        public bool? CanMessage { get; set; }

        [JsonProperty("can_post")]
        public bool? CanPost { get; set; }

        [JsonProperty("can_see_all_posts")]
        public bool? CanSeeAllPosts { get; set; }

        [JsonProperty("can_upload_doc")]
        public bool? CanUploadDocument { get; set; }

        [JsonProperty("can_upload_video")]
        public bool? CanUploadVideo { get; set; }

        [JsonProperty("city")]
        [JsonConverter(typeof(TypeConverter<City>))]
        public ICity City { get; set; }

        [JsonProperty("contacts")]
        [JsonConverter(typeof(TypeConverter<IEnumerable<Contact>>))]
        public IEnumerable<IContact> Contacts { get; set; }

        [JsonProperty("counters")]
        [JsonConverter(typeof(TypeConverter<Counters>))]
        public ICounters Counters { get; set; }

        [JsonProperty("country")]
        [JsonConverter(typeof(TypeConverter<Country>))]
        public ICountry Country { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("cover")]
        [JsonConverter(typeof(TypeConverter<Cover>))]
        public ICover Cover { get; set; }

        [JsonProperty("fixed_post")]
        public int? FixedPost { get; set; }

        [JsonProperty("has_photo")]
        public bool? HasPhoto { get; set; }

        [JsonProperty("is_favorite")]
        public bool? IsFavorite { get; set; }

        [JsonProperty("is_hidden_from_feed")]
        public bool? IsHiddenFromFeed { get; set; }

        [JsonProperty("is_messages_blocked")]
        public bool? IsMessagesBlocked { get; set; }

        [JsonProperty("links")]
        [JsonConverter(typeof(TypeConverter<IEnumerable<Link>>))]
        public IEnumerable<ILink> Links { get; set; }

        [JsonProperty("main_album_id")]
        public int? MainAlbumId { get; set; }

        [JsonProperty("main_section")]
        public SectionType? MainSection { get; set; }

        [JsonProperty("market")]
        [JsonConverter(typeof(TypeConverter<MarketInfo>))]
        public IMarketInfo Market { get; set; }

        [JsonProperty("member_status")]
        public MemberStatus? MemberStatus { get; set; }

        [JsonProperty("members_count")]
        public int? MembersCount { get; set; }

        [JsonProperty("place")]
        [JsonConverter(typeof(TypeConverter<Place>))]
        public IPlace Place { get; set; }

        [JsonProperty("public_date_label")]
        public string PublicDateLabel { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? StartDate { get; set; }
        
        [JsonProperty("finish_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? FinishDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("verified")]
        public bool? IsVerified { get; set; }

        [JsonProperty("wiki_page")]
        public string WikiPage { get; set; }
        
        [JsonProperty("photo_50")]
        public Uri Photo50 { get; set; }

        [JsonProperty("photo_100")]
        public Uri Photo100 { get; set; }

        [JsonProperty("photo_200")]
        public Uri Photo200 { get; set; }
    }
}
