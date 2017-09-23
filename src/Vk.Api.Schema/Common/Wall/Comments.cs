using Newtonsoft.Json;

namespace Vk.Api.Schema.Common.Wall
{
    /// <summary>
    /// Класс для десериализации <see cref="IComments"/>
    /// </summary>
    public sealed class Comments : IComments
    {
#pragma warning disable 1591

        private Comments()
        {
        }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("can_post")]
        public bool? CanPost { get; set; }

        [JsonProperty("groups_can_post")]
        public bool GroupsCanPost { get; set; }
    }
}