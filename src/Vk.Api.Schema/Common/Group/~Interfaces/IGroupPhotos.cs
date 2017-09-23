using System;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Интерфейс, представляющий данные о фотографиях сообщества
    /// </summary>
    public interface IGroupPhotos
    {
        /// <summary>
        /// URL главной фотографии с размером 50x50px.
        /// </summary>
        Uri Photo50 { get; }

        /// <summary>
        /// URL главной фотографии с размером 100х100px.
        /// </summary>
        Uri Photo100 { get; }

        /// <summary>
        /// URL главной фотографии в максимальном размере.
        /// </summary>
        Uri Photo200 { get; }
    }
}