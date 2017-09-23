using Newtonsoft.Json;

namespace Vk.Api.Schema.Common.Wall
{
    /// <summary>
    /// Класс для десериализации <see cref="IReposts"/>
    /// </summary>
    public sealed class Reposts : IReposts
    {
#pragma warning disable 1591
        private Reposts()
        {
        }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("user_reposted")]
        public bool? UserReposted { get; set; }
    }
}