using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Parameters.User
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для users.get <para/>
    /// Документация: <see href="https://vk.com/dev/users.get"/>
    /// </summary>
    public interface IUserGetByScreenNameParameters : IUserGetParameters
    {
        /// <summary>
        /// Короткие имена пользователей
        /// </summary>
        IEnumerable<string> ScreenNames { get; set; }
    }
}
