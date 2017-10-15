using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.createChat <para/>
    /// Документация: <see href="https://vk.com/dev/messages.createChat"/>
    /// </summary>
    public interface IMessageCreateChatParameters
    {
        /// <summary>
        /// Идентификаторы пользователей, которых нужно включить в мультидиалог
        /// </summary>
        /// <remarks>
        /// Должны быть в друзьях у текущего пользователя. 
        /// Список положительных чисел, разделенных запятыми, обязательный параметр
        /// </remarks>
        IEnumerable<int> UserIds { get; set; }

        /// <summary>
        /// Название беседы
        /// </summary>
        string Title { get; set; }
    }
}
