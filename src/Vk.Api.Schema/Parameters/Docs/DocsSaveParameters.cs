using System.Collections.Generic;
using Vk.Api.Schema.Serialization.Http;

namespace Vk.Api.Schema.Parameters.Docs
{
    public class DocsSaveParameters : IDocsSaveParameters
    {
        [HttpProperty("file")]
        public string File { get; set; }

        [HttpProperty("title")]
        public string Title { get; set; }

        [HttpProperty("tags")]
        public IEnumerable<string> Tags { get; set; }
    }
}