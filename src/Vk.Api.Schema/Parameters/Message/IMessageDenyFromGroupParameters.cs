namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.denyMessagesFromGroup <para/>
    /// Документация: <see href="https://vk.com/dev/messages.denyMessagesFromGroup"/>
    /// </summary>
    public interface IMessageDenyFromGroupParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Положительное число, обязательный параметр
        /// </remarks>
        int GroupId { get; set; }
    }
}
