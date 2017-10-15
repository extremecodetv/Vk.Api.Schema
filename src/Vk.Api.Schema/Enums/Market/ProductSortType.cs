namespace Vk.Api.Schema.Enums.Market
{
    /// <summary>
    /// Тип сортировки товара
    /// </summary>
    public enum ProductsSortType
    {
        /// <summary>
        /// Пользовательская расстановка
        /// </summary>
        User,

        /// <summary>
        /// По дате добавления товара
        /// </summary>
        ByDate,

        /// <summary>
        /// По цене
        /// </summary>
        ByPrice,

        /// <summary>
        /// По популярности
        /// </summary>
        ByPopularity
    }
}