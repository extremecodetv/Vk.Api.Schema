using Vk.Api.Schema.Enums;
using Vk.Api.Schema.Enums.Filters;
using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Parameters.User
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для users.get <para/>
    /// Документация: <see href="https://vk.com/dev/users.get"/>
    /// </summary>
    public interface IUserGetParameters
    {
        /// <summary>
        /// Список дополнительных полей, которые необходимо вернуть
        /// </summary>
        UserField? Fields { get; set; }

        /// <summary>
        /// Падеж для склонения имени и фамилии
        /// </summary>
        NameCaseType? NameCase { get; set; }
    }
}
