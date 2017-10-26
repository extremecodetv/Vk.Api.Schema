namespace Vk.Api.Schema.Parameters.Board
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для board.editTopic <para/>
    /// Документация: <see href="https://vk.com/dev/board.editTopic"/>
    /// </summary>
    public interface IBoardEditTopicParameters
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
        /// Новое название обсуждения
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        string Title { get; set; }
    }
}
