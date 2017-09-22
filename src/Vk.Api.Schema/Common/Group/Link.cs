using System;
using Newtonsoft.Json;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Класс для десериализации <see cref="ILink"/>
    /// </summary>
    public sealed class Link : ILink
    {

#pragma warning disable 1591

        private Link()
        {
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("desc")]
        public string Description { get; set; }

        [JsonProperty("photo_50")]
        public Uri Photo50 { get; set; }

        [JsonProperty("photo_100")]
        public Uri Photo100 { get; set; }
    }
}