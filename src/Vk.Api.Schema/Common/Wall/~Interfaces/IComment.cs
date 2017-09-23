using System;

namespace Vk.Api.Schema.Common.Wall
{
    /// <summary>
    /// Интерфейс для представления информации о комментарии к записи "ВКонтакте"<para/>
    /// Документация: <see href="https://vk.com/dev/objects/comment">objects.comment</see>
    /// </summary>
    public interface IComment
    {
        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Идентификатор автора
        /// </summary>
        int FromId { get; }

        /// <summary>
        /// Дата создания комментария
        /// </summary>
        DateTime Date { get; }

        /// <summary>
        /// Текст комментария
        /// </summary>
        string Text { get; }

        /// <summary>
        /// Идентификатор пользователя или сообщества, 
        /// в ответ которому оставлен комментарий, если доступен, 
        /// иначе <see langword="null"/>
        /// </summary>
        int? ReplyToUser { get; }

        /// <summary>
        /// Идентификатор комментария, в ответ на который оставлен текущий, если доступен, 
        /// иначе <see langword="null"/>
        /// </summary>
        int? ReplyToComment { get; }

        /// <summary>
        /// Медиавложения комментария
        /// </summary>
        object Attachments { get; } //TODO: Attachments
    }
}