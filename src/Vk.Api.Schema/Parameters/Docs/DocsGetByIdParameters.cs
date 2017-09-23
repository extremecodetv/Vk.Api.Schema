using System.Collections.Generic;
using Vk.Api.Schema.Serialization.Http;

namespace Vk.Api.Schema.Parameters.Docs
{
    public class DocsGetByIdParameters : IDocsGetByIdParameters
    {
        [HttpProperty("docs")]
        public IEnumerable<int> Identifiers { get; set; }
    }
}