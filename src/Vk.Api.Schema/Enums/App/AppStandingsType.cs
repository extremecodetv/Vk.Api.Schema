using System.ComponentModel;

namespace Vk.Api.Schema.Enums.App
{
    /// <summary>
    /// Тип турнирной таблицы
    /// </summary>
    public enum AppStandingsType
    {
        /// <summary>
        /// По уровням
        /// </summary>
        [Description("level")]
        Level,

        /// <summary>
        /// По очкам, начисленным за выполнение миссий
        /// </summary>
        [Description("points")]
        Points,

        /// <summary>
        /// По очкам, начисленным напрямую (apps.getScore)
        /// </summary>
        [Description("score")]
        Score
    }
}