using System.ComponentModel;

namespace Vk.Api.Schema.Enums.Board
{
    /// <summary>
    /// Порядок сортировки
    /// </summary>
    public enum SortChronological
    {
        /// <summary>
        /// Сортировка в хронологическом порядке
        /// </summary>
        [Description("asc")]
        Chronological,

        /// <summary>
        /// Сортировка в обратном хронологическом порядке
        /// </summary>
        [Description("desc")]
        ReverseChronological
    }
}