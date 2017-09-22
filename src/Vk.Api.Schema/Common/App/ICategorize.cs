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
        string Section { get; }

        /// <summary>
        /// Тип приложения
        /// </summary>
        AppType Type { get; }

        /// <summary>
        /// Позиция приложения в каталоге
        /// </summary>
        int CatalogPosition { get; }

        /// <summary>
        /// Является ли приложение мультиязычным
        /// </summary>
        bool IsInternational { get; }

        /// <summary>
        /// Идентификатор жанра
        /// </summary>
        int GenreId { get; }

        /// <summary>
        /// Название жанра
        /// </summary>
        string Genre { get; }

        /// <summary>
        /// Идентификатор приложения в магазине приложений
        /// </summary>
        string PlatformId { get; }

        /// <summary>
        /// Доступно ли приложение в мобильном каталоге
        /// </summary>
        bool IsInMobileCatalog { get; }
    }
}
