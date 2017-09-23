using Vk.Api.Schema.Enums.Filters;
using Vk.Api.Schema.Serialization.Http;

namespace Vk.Api.Schema.Parameters.Docs
{
    public class DocsGetMessagesUploadServer : IDocsGetMessagesUploadServerParameters
    {

        [HttpProperty("peer_id")]
        public int? PeerId { get; set; }

        [HttpProperty("type")]
        public DocumentUploadServerFilter? Filter { get; set; }
    }
}