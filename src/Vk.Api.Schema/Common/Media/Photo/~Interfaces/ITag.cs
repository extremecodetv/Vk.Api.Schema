using System;

namespace Vk.Api.Schema.Common.Media.Photo
{
    /// <summary>
    /// Интерфейс, представляющий отметку на фотографии
    /// </summary>
    public interface ITag
    {
        /// <summary>
        /// Идентификатор пользователя, которому соответствует отметка
        /// </summary>
        int UserId { get; }

        /// <summary>
        /// Идентификатор отметки
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Идентификатор пользователя, сделавшего отметку
        /// </summary>
        int PlacedId { get; }

        /// <summary>
        /// Название отметки
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Дата добавления отметки
        /// </summary>
        DateTime? Date { get; }

        /// <summary>
        /// Координаты прямоугольной области, на которой сделана отметка
        /// </summary>
        Rect? Rect { get; }

        /// <summary>
        /// Статус отметки. Возвращает <see langword="true"/>, если подтвержденная
        /// </summary>
        bool? IsViewed { get; }
    }
}
