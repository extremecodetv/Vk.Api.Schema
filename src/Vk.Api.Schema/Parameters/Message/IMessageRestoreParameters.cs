namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.restore <para/>
    /// Документация: <see href="https://vk.com/dev/messages.restore"/>
    /// </summary>
    public interface IMessageRestoreParameters
    {
        /// <summary>
        /// Идентификатор сообщения, которое нужно восстановить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int MessageId { get; set; }
    }
}
