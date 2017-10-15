namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.deleteChatPhoto <para/>
    /// Документация: <see href="https://vk.com/dev/messages.deleteChatPhoto"/>
    /// </summary>
    public interface IMessageDeleteChatPhotoParameters
    {
        /// <summary>
        /// Идентификатор беседы
        /// </summary>
        /// <remarks>
        /// Положительное число, обязательный параметр, максимальное значение 100'000'000
        /// </remarks>
        int ChatId { get; set; }
    }
}
