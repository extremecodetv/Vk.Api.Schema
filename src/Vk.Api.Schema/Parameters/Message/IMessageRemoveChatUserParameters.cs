namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.removeChatUser <para/>
    /// Документация: <see href="https://vk.com/dev/messages.removeChatUser"/>
    /// </summary>
    public interface IMessageRemoveChatUserParameters
    {
        /// <summary>
        /// Идентификатор беседы
        /// </summary>
        /// <remarks>
        /// Обязательный параметр, максимальное значение 100'000'000
        /// </remarks>
        int ChatId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, которого необходимо исключить из беседы
        /// </summary>
        /// <remarks>
        /// Может быть меньше нуля в случае, если пользователь приглашён по email,
        /// Обязательный параметр
        /// </remarks>
        int UserId { get; set; }
    }
}
