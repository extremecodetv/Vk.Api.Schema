
using System.Collections.Generic;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Интерфейс, представляющий данные об обложке сообщества
    /// </summary>
    public interface ICover
    {
        /// <summary>
        /// <see langword="true" />, если обложка включена
        /// </summary>
        bool Enabled { get; }

        /// <summary>
        /// Коллекция копий изображений обложки
        /// </summary>
        IEnumerable<ICoverImage> Images { get; }
    }
}
