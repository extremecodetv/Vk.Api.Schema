using System.Collections.Generic;
using Vk.Api.Schema.Enums.Filters;
using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.getChatUsers <para/>
    /// Документация: <see href="https://vk.com/dev/messages.getChatUsers"/>
    /// </summary>
    public interface IMessageGetChatUsersParameters
    {
        /// <summary>
        /// Идентификатор беседы
        /// </summary>
        /// <remarks>
        /// Максимальное значение 100'000'000
        /// </remarks>
        int? ChatId { get; set; }

        /// <summary>
        /// Cписок идентификаторов бесед
        /// </summary>
        IEnumerable<int> ChatIds { get; set; }

        /// <summary>
        /// Cписок дополнительных полей профилей, которые необходимо вернуть
        /// </summary>
        UserField? Fields { get; set; } // TODO: Список допустимых значений меньше чем в перечислении

        /// <summary>
        /// Падеж для склонения имени и фамилии пользователя
        /// </summary>
        NameCaseType? NameCase { get; set; }
    }
}
