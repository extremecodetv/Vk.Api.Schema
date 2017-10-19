using Vk.Api.Schema.Enums.App;
using Vk.Api.Schema.Enums.Filters;
using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Parameters.Apps
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для apps.getCatalog <para/>
    /// Документация: <see href="https://vk.com/dev/apps.getCatalog"/>
    /// </summary>
    interface IAppGetCatalogParameters
    {
        /// <summary>
        /// Способ сортировки приложений
        /// </summary>
        /// <remarks>
        /// По умолчанию: popular_today
        /// </remarks>
        AppSort? Sort { get; set; }

        /// <summary>
        /// Смещение, необходимое для выборки определенного подмножества приложений
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество приложений, информацию о которых необходимо вернуть
        /// </summary>
        /// <remarks>
        /// По умолчанию 100, обязательный параметр
        /// </remarks>
        int Count { get; set; }

        /// <summary>
        /// Платформа, для которой необходимо вернуть приложения
        /// </summary>
        /// <remarks>
        /// По умолчанию web
        /// </remarks>
        AppPlatform? Platform { get; set; }

        /// <summary>
        /// Получить дополнительные поля: screenshots, MAU (количество уникальных посетителей в месяц), 
        /// catalog_position, international (отображается ли приложение в каталоге у иностранных пользователей)
        /// </summary>
        /// <remarks>
        /// Если указан extended – count не должен быть больше 100
        /// По умолчанию 0
        /// </remarks>
        bool? IsExtended { get; set; }

        /// <summary>
        /// Вернуть список друзей, установивших это приложение
        /// </summary>
        /// <remarks>
        /// По умолчанию 0
        /// Параметр учитывается только при передаче access_token
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

        /// <summary>
        /// Поисковая строка для поиска по каталогу приложений
        /// </summary>
        string SearchString { get; set; }

        /// <summary>
        /// Идентификатор жанра
        /// </summary>
        int? GenreId { get; set; }

        /// <summary>
        /// Возвращает список установленных приложений или установленных в "Выбор редакции" 
        /// (только для мобильных приложений)
        /// </summary>
        AppInstalledFilter Filter { get; set; }
    }
}
