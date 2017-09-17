using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Photo
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для photos.createComment <para/>
    /// Документация: <see href="https://vk.com/dev/photos.createComment"/>
    /// </summary>
    public interface IPhotoCreateCommentParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, 
        /// которому принадлежит фотография
        /// </summary>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор фотографии
        /// </summary>
        int PhotoId { get; set; }

        /// <summary>
        /// Текст комментария
        /// </summary>
        /// <remarks>
        /// Необязателен, если используются вложения
        /// </remarks>
        string Message { get; set; }

        /// <summary>
        /// Список вложений приложеных к комментарию
        /// </summary>
        IEnumerable<object> Attachments { get; set; } //TODO: Create attachments

        /// <summary>
        /// Отправка комментария от имени сообщества
        /// </summary>
        /// <remarks>
        /// Доступно только для администраторов или редакторов сообщества
        /// </remarks>
        bool? FromGroup { get; set; }

        /// <summary>
        /// Идентификатор комментария, в ответ на который нужно
        /// оставить текущий комментарий
        /// </summary>
        int? ReplyToComment { get; set; }

        /// <summary>
        /// Идентификатор стикера, который необходимо 
        /// прикрепить к комментарию 
        /// </summary>
        int? StickerId { get; set; }
    }
}
