namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    ///  Интерфейс для представления параметров запроса для market.getCategories <para/>
    /// Документация: <see href="https://vk.com/dev/market.getCategories"/>
    /// </summary>
    public interface IMarketGetCategoriesParameters
    {
        /// <summary>
        /// Количество категорий
        /// </summary>
        /// <remarks>
        /// Максимальное значение 1000, по умолчанию 10
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Смещение для выборки определенного подмножества
        /// </summary>
        int? Offset { get; set; }
    }
}
