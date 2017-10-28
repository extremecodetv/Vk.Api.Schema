using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Serialization.Http
{
    class HttpConverterAttribute : Attribute
    {
        private readonly Type _converterType;

        public Type ConverterType
        {
            get
            {
                return _converterType;
            }
        }

        public HttpConverterAttribute(Type converterType)
        {
            if(converterType == null)
            {
                throw new NullReferenceException(nameof(converterType));
            }

            if(converterType.BaseType != (typeof(IHttpConverter)))
            {
                throw new InvalidCastException($"Тип {converterType.Name} не является производным от {nameof(IHttpConverter)}");
            }

            _converterType = converterType;
        }
    }
}
