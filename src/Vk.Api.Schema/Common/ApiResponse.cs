using Newtonsoft.Json;

namespace Vk.Api.Schema.Common
{

#pragma warning disable 1591

    public sealed class ApiResponse<T> : IResponse<T>
    {
        private ApiResponse()
        {
        }
        
        [JsonProperty("error")]
        public object Error { get; set; }
        
        [JsonProperty("response")]
        public T Response { get; }
    }
}