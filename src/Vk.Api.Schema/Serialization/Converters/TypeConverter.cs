using System;
using Newtonsoft.Json;

namespace Vk.Api.Schema.Serialization.Converters
{
    /// <summary>
    /// Конвертер для десериализации конкретных типов
    /// и апкаста к интерфейсу
    /// </summary>
    /// <typeparam name="T">Тип для десериализации</typeparam>
    internal class TypeConverter<T> : JsonConverter
    {

#pragma warning disable 1591    

        public override bool CanConvert(Type objectType) => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<T>(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}