using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Common.Media.Photo
{
    /// <summary>
    /// Интерфейс, представляющий информацию о фотографии
    /// Документация: <see href="https://vk.com/dev/objects/photo"/>
    /// </summary>
    public interface IPhoto : IPhotoUrl
    {
        /// <summary>
        /// Идентификатор фотографии
        /// </summary>
        int? Id { get; }

        /// <summary>
        /// Идентификатор альбома, в котором находится фотография, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? AlbumId { get; }

        /// <summary>
        /// Идентификатор владельца фотографии, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? OwnerId { get; }

        /// <summary>
        /// Идентификатор пользователя загрузившего фотографию, если фотография загружена в сообществе.
        /// Если недоступен, то <see langword="null"/>
        /// </summary>
        /// <remarks>
        /// Для фотографий, загруженых от имени сообщества, UserId = 100 (wtf?)
        /// </remarks>
        int? UserId { get; }

        /// <summary>
        /// Текст описания фотографии, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        string Text { get; }

        /// <summary>
        /// Дата добавления фотографии, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? Date { get; }

        /// <summary>
        /// Коллекция с копиями изображения в разных размерах, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IEnumerable<IPhotoSize> Sizes { get; }

        /// <summary>
        /// Ширина оригинала фотографии в пикселях, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        /// <remarks>
        /// В фотографиях опубликованых до 2012-го года отсутствует
        /// </remarks>
        int? Width { get; }

        /// <summary>
        /// Высота оригинала фотографии в пикселях, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        /// <remarks>
        /// В фотографиях, опубликованых до 2012-го года, отсутствует
        /// </remarks>
        int? Height { get; }
    }
}
