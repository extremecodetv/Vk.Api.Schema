namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для market.reorderItems <para/>
    /// Документация: <see href="https://vk.com/dev/market.reorderItems"/>
    /// </summary>
    public interface IMarketReorderItemsParameters
    {
        /// <summary>
        /// Идентификатор владельца товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор подборки, в которой находится товар
        /// </summary>
        /// <remarks>
        /// 0 — для сортировки общего списка товаров
        /// </remarks>
        int? AlbumId { get; set; }

        /// <summary>
        /// Идентификатор товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int ItemId { get; set; }

        /// <summary>
        /// Идентификатор товара, перед которым следует поместить текущий
        /// </summary>
        int? Before { get; set; }

        /// <summary>
        /// Идентификатор товара, после которого следует поместить текущий
        /// </summary>
        int? After { get; set; }
    }
}
