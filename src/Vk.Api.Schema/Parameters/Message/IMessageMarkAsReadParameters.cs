namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.markAsRead <para/>
    /// Документация: <see href="https://vk.com/dev/messages.markAsRead"/>
    /// </summary>
    public interface IMessageMarkAsReadParameters
    {
        /// <summary>
        /// Идентификатор назначения
        /// </summary>
        /// <remarks>
        /// Для пользователя: id пользователя
        /// Для групповой беседы: 2000000000 + id беседы
        /// Для сообщества: -id сообщества
        /// </remarks>
        string PeerId { get; set; } //TODO: По документации string, по логике int (проверить)

        /// <summary>
        /// Идентификатор сообщения, начиная с которого, все следующие будут отмечены как прочитанные
        /// </summary>
        int? StartMessageId { get; set; }
    }
}
