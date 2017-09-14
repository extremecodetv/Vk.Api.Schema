using System;

namespace Vk.Api.Schema.Common.App
{
    /// <summary>
    /// Интерфейс для представления информации об авторе приложения ВКонтакте
    /// </summary>
    public interface IAppCreatorData
    {
        /// <summary>
        /// Адрес страницы автора приложения
        /// </summary>
        Uri AuthorUrl { get; set; }

        /// <summary>
        /// Идентификатор автора приложения
        /// </summary>
        int AuthorId { get; set; }

        /// <summary>
        /// Идентификатор официальной группы приложения (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? AuthorGroupId { get; set; }

    }
}
