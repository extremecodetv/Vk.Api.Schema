using System;

namespace Vk.Api.Schema.Common.App
{
    /// <summary>
    /// Интерфейс для представления информации об авторе приложения "ВКонтакте"
    /// </summary>
    public interface IAppCreatorData
    {
        /// <summary>
        /// Адрес страницы автора приложения
        /// </summary>
        Uri AuthorUrl { get; }

        /// <summary>
        /// Идентификатор автора приложения
        /// </summary>
        int AuthorId { get; }

        /// <summary>
        /// Идентификатор официальной группы приложения, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? AuthorGroupId { get; }

    }
}
