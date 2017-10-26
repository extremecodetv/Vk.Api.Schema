namespace Vk.Api.Schema.Parameters.Board
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для board.restoreComment <para/>
    /// Документация: <see href="https://vk.com/dev/board.restoreComment"/>
    /// </summary>
    public interface IBoardRestoreCommentParameters
    {
        /// <summary>
        /// Идентификатор сообщества, в котором размещено обсуждение
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор обсуждения
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int TopicId { get; set; }

        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int CommentId { get; set; }
    }
}
