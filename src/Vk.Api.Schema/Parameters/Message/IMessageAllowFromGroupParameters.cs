namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.allowMessagesFromGroup <para/>
    /// Документация: <see href="https://vk.com/dev/messages.allowMessagesFromGroup"/>
    /// </summary>
    public interface IMessageAllowFromGroupParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Положительное число, обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Произвольная строка
        /// </summary>
        /// <remarks>
        /// Этот параметр можно использовать для идентификации пользователя. 
        /// Его значение будет возвращено в событии message_allow Callback API https://vk.com/dev/callback_api. 
        /// </remarks>
        string Key { get; set; }
    }
}
