namespace Vk.Api.Schema.Parameters.Pages
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для pages.getHistory <para/>
    /// Документация: <see href="https://vk.com/dev/pages.getHistory"/>
    /// </summary>
    public interface IPageGetHistoryParameters
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
    }
}
