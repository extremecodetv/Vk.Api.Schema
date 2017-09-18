using System;

using Vk.Api.Schema.Enums;

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
        Uri Url { get; set; }

        /// <summary>
        /// Ширина копии в пикселях, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        /// <remarks>
        /// В фотографиях, опубликованых до 2012-го года, отсутствует
        /// </remarks>
        int? Width { get; set; }

        /// <summary>
        /// Высота копии в пикселях, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        /// <remarks>
        /// В фотографиях, опубликованых до 2012-го года, отсутствует
        /// </remarks>
        int? Height { get; set; }

        /// <summary>
        /// Пропорции и размер копии изображения, если доступны,
        /// иначе <see langword="null"/> 
        /// </summary>
        PhotoSizeType? Type { get; set; }
    }
}
