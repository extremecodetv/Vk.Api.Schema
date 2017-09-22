using System;
using Vk.Api.Schema.Enums.Page;

namespace Vk.Api.Schema.Common.Page
{
    /// <summary>
    /// Интерфейс для представления информации о вики-странице "ВКонтакте"<para/>
    /// Документация: <see href="https://vk.com/dev/objects/page">objects.page</see>
    /// </summary>
    public interface IPage
    {
        /// <summary>
        /// Идентификатор страницы
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        int GroupId { get; }

        /// <summary>
        /// Идентификатор создателя
        /// </summary>
        int CreatorId { get; }

        /// <summary>
        /// Заголовок страницы
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Кто может просматривать вики-страницу
        /// </summary>
        WhoCanType WhoCanView { get; }

        /// <summary>
        /// Кто может редактировать вики-страницу
        /// </summary>
        WhoCanType WhoCanEdit { get; }

        /// <summary>
        /// Дата последнего редактирования, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        DateTime? EditDate { get; }

        /// <summary>
        /// Дата создания вики-страницы
        /// </summary>
        DateTime CreateDate { get; }

        /// <summary>
        /// Идентификатор пользователя, редактировавшего страницу последним, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        int? EditorId { get; }

        /// <summary>
        /// Количество просмотров вики-страницы
        /// </summary>
        int Views { get; }

        /// <summary>
        /// Заголовок родительской страницы для навигации, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        string Parent { get; }

        /// <summary>
        /// Заголовок второй родительской страницы для навигации, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        string Parent2 { get; }

        /// <summary>
        /// Текст страницы в HTML формате, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        string Html { get; }

        /// <summary>
        /// Адрес страницы для отображения
        /// </summary>
        Uri Url { get; }
    }
}