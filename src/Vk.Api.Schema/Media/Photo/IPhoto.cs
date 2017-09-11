using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Media.Photo
{
    /// <summary>
    /// Интерфейс представляющий информацию о фотографии
    /// Документация: <see href="https://vk.com/dev/objects/photo"/>
    /// </summary>
    public interface IPhoto : IPhotoUrl
    {
        /// <summary>
        /// Идентификатор фотографии
        /// </summary>
        int? Id { get; set; }

        /// <summary>
        /// Идентификатор альбома, в котором находится фотография (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? AlbumId { get; set; }

        /// <summary>
        /// Идентификатор владельца фотографии (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? OwnerId { get; set; }

        /// <summary>
        /// Идентификатор пользователя загрузившего фотографию, если фотография загружена в сообществе
        /// (если доступно), иначе <see langword="null"/>
        /// </summary>
        /// <remarks>
        /// Для фотографий загруженых от имени сообщества UserId = 100 (wtf?)
        /// </remarks>
        int? UserId { get; set; }

        /// <summary>
        /// Текст описания фотографии (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Дата добавления фотографии (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? Date { get; set; }

        /// <summary>
        /// Коллекция с копиями изображения в разных размерах (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        IEnumerable<IPhotoSize> Sizes { get; set; }

        /// <summary>
        /// Ширина оригинала фотографии в пикселях (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        /// <remarks>
        /// В фотографиях опубликованых до 2012-го года отсутствует
        /// </remarks>
        int? Width { get; set; }

        /// <summary>
        /// Высота оригинала фотографии в пикселях (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        /// <remarks>
        /// В фотографиях опубликованых до 2012-го года отсутствует
        /// </remarks>
        int? Height { get; set; }
    }
}
