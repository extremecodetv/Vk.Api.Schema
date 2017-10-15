using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.delete <para/>
    /// Документация: <see href="https://vk.com/dev/messages.delete"/>
    /// </summary>
    public interface IMessageDeleteParameters
    {
        /// <summary>
        /// Cписок идентификаторов сообщений
        /// </summary>
        /// <remarks>
        /// Cписок положительных чисел, разделенных запятыми
        /// </remarks>
        IEnumerable<int> MessageIds { get; set; }

        /// <summary>
        /// Пометить сообщения как спам
        /// </summary>
        bool? IsSpam { get; set; }
    }
}
