using System.Collections.Generic;
using Vk.Api.Schema.Serialization.Http;

namespace Vk.Api.Schema.Parameters.Docs
{
    public class DocsEditParameters : IDocsEditParameters
    {
        [HttpProperty("owner_id")]
        public int OwnerId { get; set; }

        [HttpProperty("doc_id")]
        public int DocId { get; set; }

        [HttpProperty("title")]
        public string Title { get; set; }

        [HttpProperty("tags")]
        public IEnumerable<string> Tags { get; set; }
    }
}