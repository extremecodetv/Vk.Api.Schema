using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для market.add <para/>
    /// Документация: <see href="https://vk.com/dev/market.add"/>
    /// </summary>
    public interface IMarketAddParameters
    {
        /// <summary>
        /// Идентификатор владельца товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Название товара
        /// </summary>
        /// <remarks>
        /// Минимальная длина 4, максимальная длина 100, обязательный параметр
        /// </remarks>
        string Name { get; set; }

        /// <summary>
        /// Описание товара
        /// </summary>
        /// <remarks>
        /// Минимальная длина 10, обязательный параметр
        /// </remarks>
        string Description { get; set; }

        /// <summary>
        /// Идентификатор категории товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int CategoryId { get; set; }

        /// <summary>
        /// Цена товара
        /// </summary>
        /// <remarks>
        /// Минимальное значение 0.01, обязательный параметр
        /// </remarks>
        decimal Price { get; set; }

        /// <summary>
        /// Удален ли товар
        /// </summary>
        bool? IsDeleted { get; set; }

        /// <summary>
        /// Идентификатор фотографии обложки товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int MainPhotoId { get; set; }

        /// <summary>
        /// Идентификаторы дополнительных фотографий товара
        /// </summary>
        /// <remarks>
        /// Количество элементов не более 4
        /// </remarks>
        IEnumerable<int> PhotoIds { get; set; }
    }
}