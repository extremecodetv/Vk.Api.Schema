using System;
using Vk.Api.Schema.Enums.Wall;

namespace Vk.Api.Schema.Common.Wall
{
    /// <summary>
    /// Интерфейс, представляющий данные о способе размещения записи на стене
    /// </summary>
    public interface IPostSource
    {
        /// <summary>
        /// Тип источника
        /// </summary>
        SourceType Type { get; }

        /// <summary>
        /// Название платформы, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        SourcePlatform? Platform { get; }

        /// <summary>
        /// Тип действия, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        SourceData? Data { get; }

        /// <summary>
        /// Url ресурса, с которого была опубликованая запись
        /// </summary>
        Uri Url { get; }
    }
}