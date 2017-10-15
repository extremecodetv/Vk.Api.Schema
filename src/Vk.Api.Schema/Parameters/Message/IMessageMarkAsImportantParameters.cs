using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.markAsImportant <para/>
    /// Документация: <see href="https://vk.com/dev/messages.markAsImportant"/>
    /// </summary>
    public interface IMessageMarkAsImportantParameters
    {
        /// <summary>
        /// Список идентификаторов сообщений, которые необходимо пометить
        /// </summary>
        IEnumerable<int> MessageIds { get; set; }

        /// <summary>
        /// Сообщения важные
        /// </summary>
        /// <remarks>
        /// 1, если сообщения необходимо пометить, как важные; 
        /// 0, если необходимо снять пометку.
        /// </remarks>
        bool? MessageIsImportant { get; set; }
    }
}
