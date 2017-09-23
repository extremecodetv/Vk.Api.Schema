using Newtonsoft.Json;

namespace Vk.Api.Schema.Common.Poll
{
    /// <summary>
    /// Класс для десериализации <see cref="IAnswerVariant"/>
    /// </summary>
    public sealed class AnswerVariant : IAnswerVariant
    {
#pragma warning disable 1591

        private AnswerVariant()
        {
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("votes")]
        public int Votes { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }
    }
}