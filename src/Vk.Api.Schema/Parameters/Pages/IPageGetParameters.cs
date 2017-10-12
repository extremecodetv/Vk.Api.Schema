namespace Vk.Api.Schema.Parameters.Pages
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для pages.get <para/>
    /// Документация: <see href="https://vk.com/dev/pages.get"/>
    /// </summary>
    public interface IPageGetParameters
    {
        /// <summary>
        /// Идентификатор владельца вики-страницы
        /// </summary>
        int? OwnerId { get; set; }

        /// <summary>
        /// Идентификатор вики-страницы
        /// </summary>
        int? PageId { get; set; }

        /// <summary>
        /// Требуется получить информацию о глобальной вики-странице
        /// </summary>
        bool? NeedGlobalInfo { get; set; }

        /// <summary>
        /// Получаемая wiki страница является предпросмотром для прикрепленной ссылки
        /// </summary>
        bool? IsSitePreview { get; set; }

        /// <summary>
        /// Название страницы
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Требуется вернуть содержимое страницы в вики-формате
        /// </summary>
        /// <remarks>
        /// Доступен начиная с версии 5.20
        /// </remarks>
        bool? NeedSource { get; set; }

        /// <summary>
        /// Требуется вернуть html-представление страницы
        /// </summary>
        bool? NeedHtml { get; set; }
    }
}
