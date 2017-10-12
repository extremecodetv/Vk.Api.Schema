namespace Vk.Api.Schema.Parameters.Pages
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для pages.getTitles <para/>
    /// Документация: <see href="https://vk.com/dev/pages.getTitles"/>
    /// </summary>
    public interface IPageGetTitlesParameters
    {
        /// <summary>
        /// Идентификатор сообщества, которому принадлежит вики-страница
        /// </summary>
        int? GroupId { get; set; }
    }
}
