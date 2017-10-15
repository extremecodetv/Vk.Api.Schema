namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.deleteDialog <para/>
    /// Документация: <see href="https://vk.com/dev/messages.deleteDialog"/>
    /// </summary>
    public interface IMessageDeleteDialogParameters
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        /// <remarks>
        /// Если требуется очистить историю беседы, используйте PeerId
        /// </remarks>
        string UserId { get; set; }

        /// <summary>
        /// Идентификатор назначения
        /// </summary>
        /// <remarks>
        /// Для групповой беседы: 2'000'000'000 + id беседы.
        /// Для сообщества: -id сообщества.
        /// Доступен начиная с версии 5.38
        /// </remarks>
        int? PeerId { get; set; }

        /// <summary>
        /// Начиная с какого сообщения нужно удалить переписку
        /// </summary>
        /// <remarks>
        /// По умолчанию удаляются все сообщения начиная с первого
        /// </remarks>
        int? Offset { get; set; }

        /// <summary>
        /// Количество удаляемых сообщений
        /// </summary>
        /// <remarks>
        /// Максимальное значение 10000
        /// </remarks>
        int? Count { get; set; }
    }
}
