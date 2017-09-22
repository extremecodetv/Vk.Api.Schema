using System;

using Vk.Api.Schema.Enums;
using Vk.Api.Schema.Enums.Media;

namespace Vk.Api.Schema.Common.Media.Photo
{
    /// <summary>
    /// Интерфейс, представляющий копию изображения с определенными пропорциями и размером
    /// </summary>
    public interface IPhotoSize
    {
        /// <summary>
        /// URL копии изображения
        /// </summary>
        Uri Url { get; }

        /// <summary>
        /// Ширина копии в пикселях, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        /// <remarks>
        /// В фотографиях, опубликованых до 2012-го года, отсутствует
        /// </remarks>
        int? Width { get; }

        /// <summary>
        /// Высота копии в пикселях, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        /// <remarks>
        /// В фотографиях, опубликованых до 2012-го года, отсутствует
        /// </remarks>
        int? Height { get; }

        /// <summary>
        /// Пропорции и размер копии изображения, если доступны,
        /// иначе <see langword="null"/> 
        /// </summary>
        PhotoSizeType? Type { get; }
    }
}
