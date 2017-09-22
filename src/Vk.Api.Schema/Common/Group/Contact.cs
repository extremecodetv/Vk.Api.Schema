using Newtonsoft.Json;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Класс для десериализации <see cref="IContact"/>
    /// </summary>
    public class Contact : IContact
    {

#pragma warning disable 1591
        
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("desc")]
        public string Position { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}