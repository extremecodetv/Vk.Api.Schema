using Newtonsoft.Json;

namespace Vk.Api.Schema.Common
{
    /// <summary>
    /// Класс для десериализации <see cref="ICurrency"/>
    /// </summary>
    public sealed class Currency : ICurrency
    {

#pragma warning disable 1591

        private Currency()
        {
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}