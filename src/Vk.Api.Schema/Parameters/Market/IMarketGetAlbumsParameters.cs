namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    ///  Интерфейс для представления параметров запроса для market.getAlbums <para/>
    /// Документация: <see href="https://vk.com/dev/market.getAlbumst"/>
    /// </summary>
    public interface IMarketGetAlbumsParameters
    {
        /// <summary>
        /// Идентификатор владельца товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Смещение относительно первой найденной подборки
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество возвращаемых подборок
        /// </summary>
        /// <remarks>
        /// По умолчанию 50, максимальное значение 100
        /// </remarks>
        int? Count { get; set; }
    }
}
