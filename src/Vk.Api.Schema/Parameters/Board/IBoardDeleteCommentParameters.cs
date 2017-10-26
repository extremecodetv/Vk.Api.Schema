namespace Vk.Api.Schema.Parameters.Board
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для board.deleteComment <para/>
    /// Документация: <see href="https://vk.com/dev/board.deleteComment"/>
    /// </summary>
    public interface IBoardDeleteCommentParameters
    {
        /// <summary>
        /// Идентификатор сообщества
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
        /// Идентификатор комментария в обсуждении
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int CommentId { get; set; }
    }
}
