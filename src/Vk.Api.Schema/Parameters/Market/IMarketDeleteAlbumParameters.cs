namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    ///  Интерфейс для представления параметров запроса для market.deleteAlbum <para/>
    /// Документация: <see href="https://vk.com/dev/market.deleteAlbum"/>
    /// </summary>
    public interface IMarketDeleteAlbumParameters
    {
        /// <summary>
        /// Идентификатор владельца подборки
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
    }
}
