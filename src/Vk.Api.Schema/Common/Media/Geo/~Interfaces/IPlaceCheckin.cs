using System;

namespace Vk.Api.Schema.Common
{
    /// <summary>
    /// Интерфейс, представляющий чекин
    /// </summary>
    public interface IPlaceCheckin
    {
        /// <summary>
        /// Тип чекина, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? Type { get; }

        /// <summary>
        /// Идентификатор сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? GroupId { get; }

        /// <summary>
        /// URL миниатюры главной фотографии сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        Uri GroupPhotoUrl { get; }

        /// <summary>
        /// Количество чекинов, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? CheckinsCount { get; }

        /// <summary>
        /// Время последнего чекина, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? UpdateDate { get; }

        /// <summary>
        /// Адрес, если доступно, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Address { get; }
      
        /// Тип чекина
        /// </summary>
        int Type { get; }
    }
}