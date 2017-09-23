using Vk.Api.Schema.Serialization.Http;

namespace Vk.Api.Schema.Parameters.Docs
{
    public class DocsGetTypesParameters : IDocsGetTypesParameters
    {

        [HttpProperty("owner_id")]
        public int OwnerId { get; }
    }
}