using Vk.Api.Schema.Enums.App;

namespace Vk.Api.Schema.Parameters.Apps
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для apps.getLeaderboard <para/>
    /// Документация: <see href="https://vk.com/dev/apps.getLeaderboard"/>
    /// </summary>
    public interface IAppGetLeaderboardParameters
    {
        /// <summary>
        /// Тип турнирной таблицы
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        AppStandingsType Type { get; set; }

        /// <summary>
        /// Тип рейтинга. (1 - Глобальный рейтинг по всем игрокам, 0 — рейтинг по друзьям пользователя).
        /// </summary>
        /// <remarks>
        /// По умолчанию 1
        /// </remarks>
        bool? IsGlobal { get; set; }

        /// <summary>
        /// Возвращать дополнительную информацию о пользователе
        /// </summary>
        /// <remarks>
        /// По умолчанию 0
        /// </remarks>
        bool? IsExtended { get; set; }
    }
}
