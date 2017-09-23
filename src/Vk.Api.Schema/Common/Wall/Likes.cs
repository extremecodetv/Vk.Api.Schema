using Newtonsoft.Json;

namespace Vk.Api.Schema.Common.Wall
{
    /// <summary>
    /// Класс для десериализации <see cref="ILikes"/>
    /// </summary>
    public sealed class Likes : ILikes
    {
#pragma warning disable 1591
        private Likes()
        {
        }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("user_likes")]
        public bool? UserLikes { get; set; }

        [JsonProperty("can_like")]
        public bool? CanLike { get; set; }

        [JsonProperty("can_publish")] 
        public bool? CanPublish { get; set; }
    }
}