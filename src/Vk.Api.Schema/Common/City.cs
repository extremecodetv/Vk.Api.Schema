using Newtonsoft.Json;

namespace Vk.Api.Schema.Common
{
    /// <summary>
    /// Класс для десериализации <see cref="ICity"/>
    /// </summary>
    public class City : ICity
    {

#pragma warning disable 1591

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}