using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    ///  Интерфейс для представления параметров запроса для market.getAlbumById <para/>
    /// Документация: <see href="https://vk.com/dev/market.getAlbumById"/>
    /// </summary>
    public interface IMarketGetAlbumByIdParameters
    {
        /// <summary>
        /// Идентификатор владельца подборки
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификаторы подборок, данные о которых нужно получить
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        IEnumerable<int> AlbumIds { get; set; }
    }
}
