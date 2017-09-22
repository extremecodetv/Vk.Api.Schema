using Newtonsoft.Json;

namespace Vk.Api.Schema.Common.Media.Geo
{
    /// <summary>
    /// Класс для десериализации <see cref="IPlace"/>
    /// </summary>
    public sealed class Place : IPlace
    {
#pragma warning disable 1591

        private Place()
        {
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public int CountryId { get; set; }

        [JsonProperty("city")]
        public int CityId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }
}