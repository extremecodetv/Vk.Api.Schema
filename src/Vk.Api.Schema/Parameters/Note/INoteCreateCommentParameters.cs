namespace Vk.Api.Schema.Parameters.Note
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для notes.createComment <para/>
    /// Документация: <see href="https://vk.com/dev/notes.createComment"/>
    /// </summary>
    public interface INoteCreateCommentParameters
    {
        /// <summary>
        /// Идентификатор заметки
        /// </summary>
        /// <remarks>
        /// Положительное число, обязательный параметр
        /// </remarks>
        int NoteId { get; set; }

        /// <summary>
        /// Идентификатор владельца заметки
        /// </summary>
        /// <remarks>
        /// Положительное число, по умолчанию идентификатор текущего пользователя
        /// </remarks>
        int? OwnerId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, ответом на комментарий которого является добавляемый комментарий
        /// </summary>
        /// <remarks>
        /// Не передаётся, если комментарий не является ответом
        /// Положительное число
        /// </remarks>
        int? ReplyTo { get; set; }

        /// <summary>
        /// Текст комментария
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        string Message { get; set; }

        /// <summary>
        /// Уникальный идентификатор, предназначенный для предотвращения повторной отправки одинакового комментария
        /// </summary>
        string Guid { get; set; }
    }
}
