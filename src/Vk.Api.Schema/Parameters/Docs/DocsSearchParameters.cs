using Vk.Api.Schema.Serialization.Http;

namespace Vk.Api.Schema.Parameters.Docs
{
    public class DocsSearchParameters : IDocsSearchParameters
    {
        [HttpProperty("q")]
        public string Query { get; set; }

        [HttpProperty("count")]
        public int? Count { get; set; }

        [HttpProperty("offset")]
        public int? Offset { get; set; }
    }
}