namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    ///  Интерфейс для представления параметров запроса для market.get <para/>
    /// Документация: <see href="https://vk.com/dev/market.get"/>
    /// </summary>
    public interface IMarketGetParameters
    {
        /// <summary>
        /// Идентификатор владельца товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор подборки
        /// </summary>
        /// <remarks> 
        /// По умолчанию = 0
        /// </remarks>
        int? AlbumId { get; set; }

        /// <summary>
        /// Количество возвращаемых товаров
        /// </summary>
        /// <remarks>
        /// Максимальное значение 200, по умолчанию 100
        /// </remarks>
        int? Count {get; set;}

        /// <summary>
        /// Смещение относительно первого найденного товара
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Будут ли возвращены дополнительные поля
        /// </summary>
        /// <remarks>
        /// Если <see langword="true"/>, будут возвращены дополнительные поля likes, can_comment, can_repost, photos, views_count 
        /// По умолчанию <see langword="false"/>
        /// </remarks>
        bool? Extended { get; set; }
    }
}
