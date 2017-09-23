using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Vk.Api.Schema.Serialization.Converters;

namespace Vk.Api.Schema.Common.Poll
{
    /// <summary>
    /// Класс для десериализации <see cref="IPoll"/>
    /// </summary>
    public sealed class Poll : IPoll
    {
#pragma warning disable 1591   

        private Poll()
        {
        } 

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("created")]
        public DateTime CreateDate { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("votes")]
        public int Votes { get; set; }

        [JsonProperty("answers")]
        [JsonConverter(typeof(TypeConverter<AnswerVariant>))]
        public IEnumerable<IAnswerVariant> AnswerVariants { get; set; }

        [JsonProperty("anonymous")]
        public bool IsAnonymous { get; set; }

        [JsonProperty("answer_id")]
        public int? AnswerId { get; set; }
    }
}