namespace Vk.Api.Schema.Parameters.Note
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для notes.editComment <para/>
    /// Документация: <see href="https://vk.com/dev/notes.editComment"/>
    /// </summary>
    public interface INoteEditCommentParameters
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

        /// <summary>
        /// Новый текст комментария
        /// </summary>
        /// <remarks>
        /// Минимальная длина 2
        /// </remarks>
        string Message { get; set; }
    }
}
