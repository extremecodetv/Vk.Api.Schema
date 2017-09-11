using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Enums.User
{
    /// <summary>
    /// Статус аккаунта пользователя
    /// </summary>
    public enum AccountStatus
    {
        /// <summary>
        /// Пользователь удален
        /// </summary>
        Deleted,
        /// <summary>
        /// Пользователь заблокирован
        /// </summary>
        Banned
    }
}
