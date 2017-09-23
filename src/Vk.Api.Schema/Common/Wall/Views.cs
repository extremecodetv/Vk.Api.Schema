using Newtonsoft.Json;

namespace Vk.Api.Schema.Common.Wall
{
    /// <summary>
    /// Класс для десериализации <see cref="IViews"/>
    /// </summary>
    public sealed class Views : IViews
    {
#pragma warning disable 1591

        private Views()
        {
        }

        [JsonProperty("count")]
        public int Count { get; }
    }
}