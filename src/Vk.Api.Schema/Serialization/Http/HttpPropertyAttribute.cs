using System;

namespace Vk.Api.Schema.Serialization.Http
{
    internal class HttpPropertyAttribute : Attribute
    {
        private string parameterName;

        public string ParameterName => parameterName;

        public HttpRequired Required { get; set; } = HttpRequired.DisallowNull;

        public HttpPropertyAttribute(string parameterName)
        {
            this.parameterName = parameterName;
        }
    }
}
