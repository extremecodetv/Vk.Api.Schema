namespace Vk.Api.Schema.Parameters.Board
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для board.fixTopic <para/>
    /// Документация: <see href="https://vk.com/dev/board.fixTopic"/>
    /// </summary>
    public interface IBoardFixTopicParameters
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
