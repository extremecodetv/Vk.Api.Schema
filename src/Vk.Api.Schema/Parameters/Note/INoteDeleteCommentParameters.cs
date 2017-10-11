namespace Vk.Api.Schema.Parameters.Note
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для notes.deleteComment <para/>
    /// Документация: <see href="https://vk.com/dev/notes.deleteComment"/>
    /// </summary>
    public interface INoteDeleteCommentParameters
    {
        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        /// <remarks>
        /// Положительное число, обязательный параметр
        /// </remarks>
        int CommentId { get; set; }

        /// <summary>
        /// Идентификатор владельца заметки
        /// </summary>
        /// <remarks>
        /// Положительное число, по умолчанию идентификатор текущего пользователя
        /// </remarks>
        int? OwnerId { get; set; }
    }
}
