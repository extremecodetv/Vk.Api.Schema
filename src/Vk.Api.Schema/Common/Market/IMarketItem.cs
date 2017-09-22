using System;
using System.Collections.Generic;
using Vk.Api.Schema.Common.Media.Photo;
using Vk.Api.Schema.Common.Wall;
using Vk.Api.Schema.Enums.Market;

namespace Vk.Api.Schema.Common.Market
{
    /// <summary>
    /// Интерфейс для представления информации о товаре "ВКонтакте"<para/>
    /// Документация: <see href="https://vk.com/dev/objects/market_item">objects.market_item</see>
    /// </summary>
    public interface IMarketItem
    {
        /// <summary>
        /// Идентификатор товара
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Идентификатор владельца товара
        /// </summary>
        int OwnerId { get; }

        /// <summary>
        /// Название товара
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Описание товара
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Цена товара
        /// </summary>
        IPrice Price { get; }

        /// <summary>
        /// Категория товара
        /// </summary>
        ICategory Category { get; }

        /// <summary>
        /// Url изображения-обложки товара
        /// </summary>
        Uri ThumbPhotoUrl { get; }

        /// <summary>
        /// Статус доступности товара
        /// </summary>
        AvailabilityType Availability { get; }

        /// <summary>
        /// Коллекция изображений товара
        /// </summary>
        IEnumerable<IPhoto> Photos { get; }

        /// <summary>
        /// Возможность комментировать товар, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        bool? CanComment { get; }

        /// <summary>
        /// Возможность сделать репост товара, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        bool? CanRepost { get; }

        /// <summary>
        /// Информация об отметках "Мне нравится", если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        ILikes Likes { get; }
    }
}