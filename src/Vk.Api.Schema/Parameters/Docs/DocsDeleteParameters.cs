using Vk.Api.Schema.Serialization.Http;

namespace Vk.Api.Schema.Parameters.Docs
{
    public class DocsDeleteParameters : IDocsDeleteParameters
    {

        [HttpProperty("owner_id")]
        public int OwnerId { get; set; }
        
        [HttpProperty("doc_id")]
        public int DocId { get; set; }
    }
}