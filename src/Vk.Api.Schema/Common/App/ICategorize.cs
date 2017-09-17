using Vk.Api.Schema.Enums.App;

namespace Vk.Api.Schema.Common.App
{
    /// <summary>
    /// Интерфейс для представления информации о классификации приложения "Вконтакте"
    /// </summary>
    public interface ICategorize
    {
        /// <summary>
        /// Категория приложения
        /// </summary>
        string Section { get; set; }

        /// <summary>
        /// Тип приложения
        /// </summary>
        AppType Type { get; set; }

        /// <summary>
        /// Позиция приложения в каталоге
        /// </summary>
        int CatalogPosition { get; set; }

        /// <summary>
        /// Является ли приложение мультиязычным
        /// </summary>
        bool IsInternational { get; set; }

        /// <summary>
        /// Идентификатор жанра
        /// </summary>
        int GenreId { get; set; }

        /// <summary>
        /// Название жанра
        /// </summary>
        string Genre { get; set; }

        /// <summary>
        /// Идентификатор приложения в магазине приложений
        /// </summary>
        string PlatformId { get; set; }

        /// <summary>
        /// Доступно ли приложение в мобильном каталоге
        /// </summary>
        bool IsInMobileCatalog { get; set; }
    }
}
