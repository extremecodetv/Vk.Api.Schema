using Vk.Api.Schema.Serialization.Http;

namespace Vk.Api.Schema.Parameters.Docs
{
    public class DocsAddParameters : IDocsAddParameters
    {
        [HttpProperty("owner_id")]
        public int OwnerId { get; set; }

        [HttpProperty("doc_id")]
        public int DocId { get; set; }

        [HttpProperty("access_key")]
        public string AccessKey { get; set; }
    }
}