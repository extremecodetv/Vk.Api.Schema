using System.Collections.Generic;
using Newtonsoft.Json;
using Vk.Api.Schema.Serialization.Converters;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Класс для десериализации <see cref="ICover"/>
    /// </summary>
    public sealed class Cover : ICover
    {

#pragma warning disable 1591

        private Cover() { }
        
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        
        [JsonProperty("images")]
        [JsonConverter(typeof(TypeConverter<IEnumerable<CoverImage>>))]
        public IEnumerable<ICoverImage> Images { get; set; }
    }
}