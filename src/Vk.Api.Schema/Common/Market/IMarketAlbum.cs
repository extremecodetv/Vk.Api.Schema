using System;
using Vk.Api.Schema.Common.Media.Photo;

namespace Vk.Api.Schema.Common.Market
{
    /// <summary>
    /// Интерфейс для представления информации о подборке товаров "ВКонтакте"<para/>
    /// Документация: <see href="https://vk.com/dev/objects/market_album">objects.market_album</see>
    /// </summary>
    public interface IMarketAlbum
    {
        /// <summary>
        /// Идентификатор подборки
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Идентификатор владельца подборки
        /// </summary>
        int OwnerId { get; }

        /// <summary>
        /// Название подборки
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Обложка подборки
        /// </summary>
        IPhoto Photo { get; }

        /// <summary>
        /// Число товаров в подборке
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Дата обновления подборки
        /// </summary>
        DateTime UpdateTime { get; }
    }
}