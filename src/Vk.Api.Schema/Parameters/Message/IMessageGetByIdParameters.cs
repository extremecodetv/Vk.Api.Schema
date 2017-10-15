using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.getById <para/>
    /// Документация: <see href="https://vk.com/dev/messages.getById"/>
    /// </summary>
    public interface IMessageGetByIdParameters
    {
        /// <summary>
        /// Идентификаторы сообщений
        /// </summary>
        /// <remarks>
        /// Максимум 100 идентификаторов,
        /// Список положительных чисел, разделенных запятыми, обязательный параметр
        /// </remarks>
        IEnumerable<int> MessageIds { get; set; }

        /// <summary>
        /// Количество символов, по которому нужно обрезать сообщение
        /// </summary>
        /// <remarks>
        /// Укажите 0, если Вы не хотите обрезать сообщение. По умолчанию сообщения не обрезаются.
        /// </remarks>
        int? PreviewLength { get; set; }
    }
}
