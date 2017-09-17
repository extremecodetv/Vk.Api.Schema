using System;

namespace Vk.Api.Schema.Media.Photo
{
    /// <summary>
    /// Интерфейс, представляющий отметку на фотографии
    /// </summary>
    public interface ITag
    {
        /// <summary>
        /// Идентификатор пользователя, которому соответствует отметка
        /// </summary>
        int UserId { get; set; }

        /// <summary>
        /// Идентификатор отметки
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Идентификатор пользователя, сделавшего отметку
        /// </summary>
        int PlacedId { get; set; }

        /// <summary>
        /// Название отметки
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Дата добавления отметки
        /// </summary>
        DateTime? Date { get; set; }

        /// <summary>
        /// Координаты прямоугольной области, на которой сделана отметка
        /// </summary>
        Rect? Rect { get; set; }

        /// <summary>
        /// Статус отметки. Возвращает <see langword="true"/>, если подтвержденная
        /// </summary>
        bool? IsViewed { get; set; }
    }
}
