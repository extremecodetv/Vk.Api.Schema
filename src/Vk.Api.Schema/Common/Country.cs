using Newtonsoft.Json;

namespace Vk.Api.Schema.Common
{
    /// <summary>
    /// Класс для десериализации <see cref="ICountry"/>
    /// </summary>
    public sealed class Country : ICountry
    {

#pragma warning disable 1591

        private Country() { }
        
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}