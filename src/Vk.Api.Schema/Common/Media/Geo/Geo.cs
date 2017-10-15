using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Vk.Api.Schema.Serialization.Converters;

namespace Vk.Api.Schema.Common.Media.Geo
{
    /// <summary>
    /// Класс для десериализации <see cref="IGeo"/>
    /// </summary>
    public class Geo : IGeo
    {
#pragma warning disable 1591
        [JsonProperty("type")]
        public string Type { get; set; }
       
        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        [JsonProperty("place")]
        [JsonConverter(typeof(TypeConverter<Place>))]
        public IPlace Place { get; set; }
    }
}
