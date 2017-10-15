namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.getLastActivity <para/>
    /// Документация: <see href="https://vk.com/dev/messages.getLastActivity"/>
    /// </summary>
    public interface IMessageGetLastActivityParameters
    {
        /// <summary>
        /// Идентификатор пользователя, информацию о последней активности которого требуется получить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int UserId { get; set; }
    }
}
