using Newtonsoft.Json;
using Vk.Api.Schema.Serialization.Converters;

namespace Vk.Api.Schema.Common.Market
{
    /// <summary>
    /// Класс для десериализации <see cref="IMarketInfo"/>
    /// </summary>
    public sealed class MarketInfo : IMarketInfo
    {
#pragma warning disable 1591

        private MarketInfo()
        {
        }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("price_min")]
        public int? MinimalPrice { get; set; }

        [JsonProperty("price_max")]
        public int? MaximalPrice { get; set; }

        [JsonProperty("main_album_id")]
        public int? MainAlbumId { get; set; }

        [JsonProperty("contact_id")]
        public int? ContactId { get; set; }

        [JsonProperty("currency")]
        [JsonConverter(typeof(TypeConverter<Currency>))]
        public ICurrency Currency { get; set; }

        [JsonProperty("currency_text")]
        public string CurrencyText { get; set; }
    }
}