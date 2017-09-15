using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.User
{
    /// <summary>
    /// Интерфейс представляющий параметры запроса для users.get <para/>
    /// Документация: <see href="https://vk.com/dev/users.get"/>
    /// </summary>
    public interface IUserGetByIdParameters : IUserGetParameters
    {
        /// <summary>
        /// Идентификаторы пользователей
        /// </summary>
        IEnumerable<string> Ids { get; set; }
    }
}
