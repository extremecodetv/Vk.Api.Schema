using System.Collections.Generic;
using Vk.Api.Schema.Enums.App;
using Vk.Api.Schema.Enums.Filters;
using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Parameters.Apps
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для apps.get <para/>
    /// Документация: <see href="https://vk.com/dev/apps.get"/>
    /// </summary>
    public interface IAppGetParameters
    {
        /// <summary>
        /// Идентификатор приложения, данные которого необходимо получить
        /// </summary>
        int? AppId { get; set; }

        /// <summary>
        /// Cписок идентификаторов приложений, данные которых необходимо получить
        /// </summary>
        /// <remarks>
        /// Количество элементов должно составлять не более 100
        /// </remarks>
        IEnumerable<string> AppIds { get; set; }

        /// <summary>
        /// Платформа, для которой необходимо вернуть данные
        /// </summary>
        /// <remarks>
        /// По умолчанию: web
        /// </remarks>
        AppPlatform? Platform { get; set; }

        /// <summary>
        /// Получить дополнительные поля: screenshots
        /// </summary>
        /// <remarks>
        /// По умолчанию 0
        /// </remarks>
        bool? IsExtended { get; set; }

        /// <summary>
        /// Вернуть список друзей, установивших это приложение
        /// </summary>
        /// <remarks>
        /// По умолчанию 0
        /// </remarks>
        bool? NeedReturnFriends { get; set; }

        /// <summary>
        /// Список дополнительных полей, которые необходимо вернуть для профилей пользователей
        /// </summary>
        /// <remarks>
        /// Параметр учитывается только при NeedReturnFriends = 1.
        /// </remarks>
        UserField? Fields { get; set; } // TODO: Количество значений в перечислении, больше чем допустимых значений этого параметра

        /// <summary>
        /// Падеж для склонения имени и фамилии пользователей
        /// </summary>
        /// <remarks>
        /// Параметр учитывается только при NeedReturnFriends = 1
        /// </remarks>
        NameCaseType? NameCase { get; set; }
    }
}
