using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    ///  Интерфейс для представления параметров запроса для market.addToAlbum <para/>
    /// Документация: <see href="https://vk.com/dev/market.addToAlbum"/>
    /// </summary>
    public interface IMarketAddToAlbumParameters
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

        /// <summary>
        /// Идентификаторы подборок, в которые нужно добавить товар
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        IEnumerable<int> AlbumIds { get; set; }
    }
}
