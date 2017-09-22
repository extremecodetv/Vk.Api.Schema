using System;
using Newtonsoft.Json;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Класс для десериализации <see cref="ICoverImage"/>
    /// </summary>
    public sealed class CoverImage : ICoverImage
    {
#pragma warning disable 1591

        private CoverImage()
        {
        }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }
}