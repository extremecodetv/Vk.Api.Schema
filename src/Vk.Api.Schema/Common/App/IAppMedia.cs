using System;
using System.Collections.Generic;

using Vk.Api.Schema.Media.Photo;

namespace Vk.Api.Schema.Common.App
{
    /// <summary>
    /// Интерфейс для представления медиа информации о приложении "Вконтакте"
    /// </summary>
    public interface IAppMedia
    {
        /// <summary>
        /// URL-адрес обложки приложения шириной 278px
        /// </summary>
        Uri Icon278 { get; set; }

        /// <summary>
        /// URL-адрес обложки приложения шириной 139px
        /// </summary>
        Uri Icon139 { get; set; }

        /// <summary>
        /// URL-адрес обложки приложения шириной 150px
        /// </summary>
        Uri Icon150 { get; set; }

        /// <summary>
        /// URL-адрес обложки приложения шириной 75px
        /// </summary>
        Uri Icon75 { get; set; }

        /// <summary>
        /// URL-адрес баннера шириной 560px
        /// </summary>
        Uri Banner560 { get; set; }

        /// <summary>
        /// URL-адрес баннера шириной 1120px
        /// </summary>
        Uri Banner1120 { get; set; }

        /// <summary>
        /// URL-адрес обложки приложения шириной 16px, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        Uri Icon16 { get; set; }

        /// <summary>
        /// Коллекция скриншотов
        /// </summary>
        IEnumerable<IPhoto> Screenshots { get; set; }
    }
}
