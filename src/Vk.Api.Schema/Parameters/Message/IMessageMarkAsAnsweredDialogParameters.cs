namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.markAsAnsweredDialog <para/>
    /// Документация: <see href="https://vk.com/dev/messages.markAsAnsweredDialog"/>
    /// </summary>
    public interface IMessageMarkAsAnsweredDialogParameters
    {
        /// <summary>
        /// Идентификатор диалога
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int PeerId { get; set; }

        /// <summary>
        /// Есть ответ на диалог
        /// </summary>
        /// <remarks>
        /// По умолчанию 1
        /// </remarks>
        bool? IsAnswered { get; set; }
    }
}
