using Vk.Api.Schema.Enums.App;
using Vk.Api.Schema.Enums.Filters;

namespace Vk.Api.Schema.Parameters.Apps
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для apps.getFriendsList <para/>
    /// Документация: <see href="https://vk.com/dev/apps.getFriendsList"/>
    /// </summary>
    public interface IAppGetFriendsListParameters
    {
        /// <summary>
        /// Возвращать расширенную информацию о пользователях
        /// </summary>
        /// <remarks>
        /// 1 — будут дополнительно возвращены имя и фамилия 
        /// 0 — возвращаются только идентификаторы 
        /// По умолчанию 0
        /// </remarks>
        bool? IsExtended { get; set; }

        /// <summary>
        /// Количество пользователей в создаваемом списке
        /// </summary>
        /// <remarks>
        /// По умолчанию 20, максимальное значение 5000
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Смещение относительно первого пользователя для выборки определенного подмножества
        /// </summary>
        /// <remarks>
        /// По умолчанию 0
        /// </remarks>
        int? Offset { get; set; }

        /// <summary>
        /// Тип создаваемого списка друзей
        /// </summary>
        /// <remarks>
        /// По умолчанию: invite
        /// </remarks>
        AppInvite? Type { get; set; }

        /// <summary>
        /// Список дополнительных полей профилей, которые необходимо вернуть
        /// </summary>
        UserField? Fields { get; set; }
    }
}
