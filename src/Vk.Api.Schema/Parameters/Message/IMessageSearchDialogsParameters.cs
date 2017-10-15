using Vk.Api.Schema.Enums.Filters;

namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.searchDialogs <para/>
    /// Документация: <see href="https://vk.com/dev/messages.searchDialogs"/>
    /// </summary>
    public interface IMessageSearchDialogsParameters
    {
        /// <summary>
        /// Подстрока, по которой будет производиться поиск
        /// </summary>
        string Substring { get; set; }

        /// <summary>
        /// Ограничение по числу возвращаемых результатов
        /// </summary>
        /// <remarks>
        /// По умолчанию 20
        /// </remarks>
        int? Limit { get; set; }

        /// <summary>
        /// Список дополнительных полей профилей и сообществ, которые необходимо вернуть
        /// </summary>
        UserField? Fields { get; set; } // TODO: Список возможных дополнительных полей параметра меньше чем в перечислении
    }
}
