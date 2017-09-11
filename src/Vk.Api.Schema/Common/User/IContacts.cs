using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления контактных данных пользователя <see cref="IUser"/>
    /// </summary>
    public interface IContacts
    {
        /// <summary>
        /// Номер мобильного телефона (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        string MobilePhone { get; set; }

        /// <summary>
        /// Номер домашнего телефона (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        string HomePhone { get; set; }
    }
}
