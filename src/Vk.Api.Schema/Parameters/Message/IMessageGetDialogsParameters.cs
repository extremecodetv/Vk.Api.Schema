namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.getDialogs <para/>
    /// Документация: <see href="https://vk.com/dev/messages.getDialogs"/>
    /// </summary>
    public interface IMessageGetDialogsParameters
    {
        /// <summary>
        /// Смещение, необходимое для выборки определенного подмножества диалогов
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество диалогов, которое необходимо получить
        /// </summary>
        /// <remarks>
        /// По умолчанию 20, максимальное значение 200
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Идентификатор сообщения, начиная с которого нужно вернуть список диалогов 
        /// </summary>
        int? StartMessageId { get; set; }

        /// <summary>
        /// Количество символов, по которому нужно обрезать сообщение
        /// </summary>
        /// <remarks>
        /// Укажите 0, если Вы не хотите обрезать сообщение. По умолчанию сообщения не обрезаются.
        /// Текст обрезается по словам, точное число символов может не совпадать с указанным значением.
        /// </remarks>
        int? PreviewLength { get; set; }

        /// <summary>
        /// Вернуть только диалоги, в которых есть непрочитанные входящие сообщения
        /// </summary>
        /// <remarks>
        /// По умолчанию: 0, доступен начиная с версии 5.14
        /// </remarks>
        bool? Unread { get; set; }

        /// <summary>
        /// Вернуть диалоги с пометкой «Важные» (для сообщений сообществ)
        /// </summary>
        bool? IsImportant { get; set; }

        /// <summary>
        /// Вернуть диалоги с пометкой «Неотвеченные» (для сообщений сообществ)
        /// </summary>
        bool? IsUnanswered { get; set; }
    }
}
