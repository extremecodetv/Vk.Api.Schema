using System;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Интерфейс, представляющий копию обложки сообщества
    /// </summary>
    public interface ICoverImage
    {
        /// <summary>
        /// Url копии
        /// </summary>
        Uri Url { get; }

        /// <summary>
        /// Ширина копии
        /// </summary>
        int Width { get; }

        /// <summary>
        /// Высота копии
        /// </summary>
        int Height { get; }
    }
}
