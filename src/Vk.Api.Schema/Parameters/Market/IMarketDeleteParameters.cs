namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    ///  Интерфейс для представления параметров запроса для market.delete <para/>
    /// Документация: <see href="https://vk.com/dev/market.delete"/>
    /// </summary>
    public interface IMarketDeleteParameters
    {
        /// <summary>
        /// Идентификатор владельца товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int ItemId { get; set; }
    }
}
