using Vk.Api.Schema.Enums.Media;
using Vk.Api.Schema.Serialization.Http;

namespace Vk.Api.Schema.Parameters.Docs
{
    public class DocsGetParameters : IDocsGetParameters
    {

        [HttpProperty("owner_id")]
        public int? OwnerId { get; set; }

        [HttpProperty("count")]
        public int? Count { get; set; }

        [HttpProperty("offset")]
        public int? Offset { get; set; }

        [HttpProperty("type")]
        public DocumentType? Type { get; set; }
    }
}