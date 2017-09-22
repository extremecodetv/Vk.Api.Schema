using Vk.Api.Schema.Enums.Filters;
using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Parameters.User
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для users.getFollowers <para/>
    /// Документация: <see href="https://vk.com/dev/users.getFollowers"/>
    /// </summary>
    public interface IUserGetFollowersParameters : IUserIdParameter
    {
        /// <summary>
        /// Смещение для выборки подмножества пользователей
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество получаемых подписчиков
        /// </summary>
        /// <remarks>Максимальное значение 1000, значение по умолчанию 100</remarks>
        int? Count { get; set; }

        /// <summary>
        /// Дополнительные поля профиля для получения
        /// </summary>
        UserField? Fields { get; set; }

        /// <summary>
        /// Падеж для склонения имени пользователя
        /// </summary>
        NameCaseType? NameCase { get; set; }
    }
}