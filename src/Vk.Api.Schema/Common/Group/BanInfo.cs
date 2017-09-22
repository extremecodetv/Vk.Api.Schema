using System;
using Newtonsoft.Json;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Класс для десериализации <see cref="IBanInfo"/>
    /// </summary>
    public sealed class BanInfo : IBanInfo
    {

#pragma warning disable 1591    

        private BanInfo()
        {
        }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}