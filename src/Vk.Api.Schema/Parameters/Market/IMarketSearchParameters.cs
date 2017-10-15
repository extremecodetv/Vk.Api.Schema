using System.Collections.Generic;
using Vk.Api.Schema.Enums.Market;

namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для market.search <para/>
    /// Документация: <see href="https://vk.com/dev/market.search"/>
    /// </summary>
    public interface IMarketSearchParameters
    {
        /// <summary>
        /// Идентификатор сообщества, которому принадлежат товары
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор подборки
        /// </summary>
        /// <remarks>
        /// По умолчанию 0
        /// </remarks>
        int? AlbumId { get; set; }

        /// <summary>
        /// Строка поискового запроса
        /// </summary>
        /// <remarks>
        /// Например, "зеленые тапочки"
        /// </remarks>
        string Query { get; set; }

        /// <summary>
        /// Минимальное значение цены товаров в сотых долях единицы валюты
        /// </summary>
        int? PriceFrom { get; set; }

        /// <summary>
        /// Максимальное значение цены товаров в сотых долях единицы валюты
        /// </summary>
        int? PriceTo { get; set; }

        /// <summary>
        /// Перечисленные через запятую идентификаторы меток
        /// </summary>
        IEnumerable<int> Tags { get; set; }

        /// <summary>
        /// Вид сортировки
        /// </summary>
        /// <remarks>
        /// По умолчанию 0
        /// </remarks>
        ProductsSortType? Sort { get; set; }

        /// <summary>
        /// Использовать ли обратный порядок
        /// </summary>
        /// <remarks>
        /// По умолчанию <see langword="true"/>
        /// </remarks>
        bool? ReverseOrder { get; set; }

        /// <summary>
        /// Смещение относительно первого найденного товара
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество возвращаемых товаров
        /// </summary>
        int? Count { get; set; }

        /// <summary>
        /// Будут ли возвращены дополнительные поля
        /// </summary>
        /// <remarks>
        /// Если <see langword="true"/> будут возвращены дополнительные поля likes, can_comment, can_repost, photos, views_count
        /// По умолчанию <see langword="false"/>
        /// </remarks>
        bool? Extended { get; set; }
    }
}
