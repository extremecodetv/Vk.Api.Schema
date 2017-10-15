namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.editChat <para/>
    /// Документация: <see href="https://vk.com/dev/messages.editChat"/>
    /// </summary>
    public interface IMessageEditChatParameters
    {
        /// <summary>
        /// Идентификатор беседы
        /// </summary>
        /// <remarks>
        /// Положительное число, обязательный параметр, максимальное значение 100'000'000
        /// </remarks>
        int ChatId { get; set; }

        /// <summary>
        /// Новое название для беседы
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        string Title { get; set; }
    }
}
