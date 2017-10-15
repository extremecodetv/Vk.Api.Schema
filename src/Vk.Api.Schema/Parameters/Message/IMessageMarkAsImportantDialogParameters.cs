namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.markAsImportantDialog <para/>
    /// Документация: <see href="https://vk.com/dev/messages.markAsImportantDialog"/>
    /// </summary>
    public interface IMessageMarkAsImportantDialogParameters
    {
        /// <summary>
        /// Идентификатор диалога
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int PeerId { get; set; }

        /// <summary>
        /// Диалог является важным
        /// </summary>
        /// <remarks>
        /// 1, если диалог необходимо пометить, как важные;
        /// 0, если необходимо снять пометку;
        /// По умолчанию 1
        /// </remarks>
        bool? DialogIsImportant { get; set; }
    }
}
