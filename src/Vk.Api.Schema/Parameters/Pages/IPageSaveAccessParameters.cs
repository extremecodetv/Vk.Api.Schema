using Vk.Api.Schema.Enums.Page;

namespace Vk.Api.Schema.Parameters.Pages
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для pages.saveAccess <para/>
    /// Документация: <see href="https://vk.com/dev/pages.saveAccess"/>
    /// </summary>
    public interface IPageSaveAccessParameters
    {
        /// <summary>
        /// Идентификатор вики-страницы
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int PageId { get; set; }

        /// <summary>
        /// Идентификатор сообщества, которому принадлежит вики-страница
        /// </summary>
        int? GroupId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, создавшего вики-страницу
        /// </summary>
        int? UserId { get; set; }

        /// <summary>
        /// Значение настройки доступа на чтение
        /// </summary>
        WhoCanType? AccessView { get; set; }

        /// <summary>
        /// Значение настройки доступа на редактирование
        /// </summary>
        WhoCanType? AccessEdit { get; set; }
    }
}
