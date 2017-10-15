using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    ///  Интерфейс для представления параметров запроса для market.getById <para/>
    /// Документация: <see href="https://vk.com/dev/market.getById"/>
    /// </summary>
    public interface IMarketGetByIdParameters
    {
        /// <summary>
        /// Перечисленные через запятую идентификаторы — 
        /// идущие через знак подчеркивания id владельцев товаров и id самих товаров
        /// </summary>
        /// <remarks>
        /// Количество элементов не более 100, обязательный параметр
        /// </remarks>
        IEnumerable<string> ItemIds { get; set; }

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
