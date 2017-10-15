namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.setActivity <para/>
    /// Документация: <see href="https://vk.com/dev/messages.setActivity"/>
    /// </summary>
    public interface IMessageSetActivityParameters
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        string UserId { get; set; } // TODO: По документации - строка (проверить)

        /// <summary>
        /// typing — пользователь начал набирать текст
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Идентификатор назначения
        /// </summary>
        /// <remarks>
        /// Для групповой беседы: 2000000000 + id беседы
        /// Для сообщества: -id сообщества
        /// Доступен начиная с версии 5.38
        /// </remarks>
        int? PeerId { get; set; }
    }
}
