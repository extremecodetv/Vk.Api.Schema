namespace Vk.Api.Schema.Parameters.Board
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для board.openTopic <para/>
    /// Документация: <see href="https://vk.com/dev/board.openTopic"/>
    /// </summary>
    public interface IBoardOpenTopicParameters
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
    }
}
