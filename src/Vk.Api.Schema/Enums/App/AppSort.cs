using System.ComponentModel;

namespace Vk.Api.Schema.Enums.App
{
    /// <summary>
    /// Способ сортировки приложений
    /// </summary>
    public enum AppSort
    {
        /// <summary>
        /// Популярные за день
        /// </summary>
        [Description("popular_today")]
        PopularToday,

        /// <summary>
        /// По посещаемости
        /// </summary>
        [Description("visitors")]
        Visitors,

        /// <summary>
        /// По дате создания приложения
        /// </summary>
        [Description("create_date")]
        CreateDate,

        /// <summary>
        /// По скорости роста
        /// </summary>
        [Description("growth_rate")]
        GrowthRate,

        /// <summary>
        /// Популярные за неделю
        /// </summary>
        [Description("popular_week")]
        PopularWeek
    }
}