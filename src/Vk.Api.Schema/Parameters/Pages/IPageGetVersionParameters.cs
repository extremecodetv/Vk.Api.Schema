namespace Vk.Api.Schema.Parameters.Pages
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для pages.getVersion <para/>
    /// Документация: <see href="https://vk.com/dev/pages.getVersion"/>
    /// </summary>
    public interface IPageGetVersionParameters
    {
        /// <summary>
        /// Идентификатор версии
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int VersionId { get; set; }

        /// <summary>
        /// Идентификатор сообщества, которому принадлежит вики-страница
        /// </summary>
        int? GroupId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, создавшего вики-страницу
        /// </summary>
        int? UserId { get; set; }

        /// <summary>
        /// Требуется вернуть html-представление страницы
        /// </summary>
        bool? NeedHtml { get; set; }
    }
}
