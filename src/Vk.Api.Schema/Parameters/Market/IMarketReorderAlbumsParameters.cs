namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для market.reorderAlbums <para/>
    /// Документация: <see href="https://vk.com/dev/market.reorderAlbums"/>
    /// </summary>
    public interface IMarketReorderAlbumsParameters
    {
        /// <summary>
        /// Идентификатор владельца альбома
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор подборки
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int AlbumId { get; set; }

        /// <summary>
        /// Идентификатор подборки, перед которой следует поместить текущую
        /// </summary>
        int? Before { get; set; }

        /// <summary>
        /// Идентификатор подборки, после которой следует поместить текущую
        /// </summary>
        int? After { get; set; }
    }
}
