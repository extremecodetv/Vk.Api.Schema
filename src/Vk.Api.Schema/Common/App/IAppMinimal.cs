using System;

namespace Vk.Api.Schema.Common.App
{
    /// <summary>
    /// Интерфейс для представления основной информации о приложении "Вконтакте"
    /// </summary>
    public interface IAppMinimal
    {
        /// <summary>
        /// Идентификатор приложения
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Название приложения
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Дата размещения приложения
        /// </summary>
        DateTime PublishedDate { get; }
    }
}
