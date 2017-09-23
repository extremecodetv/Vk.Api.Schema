using Vk.Api.Schema.Serialization.Http;

namespace Vk.Api.Schema.Parameters.Docs
{
    public class DocsGetUploadServerParameters : IDocsGetUploadServerParameters
    {
        [HttpProperty("group_id")]
        public int? GroupId { get; set; }
    }
}