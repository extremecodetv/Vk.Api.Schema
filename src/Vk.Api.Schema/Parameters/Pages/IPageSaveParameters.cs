namespace Vk.Api.Schema.Parameters.Pages
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для pages.save <para/>
    /// Документация: <see href="https://vk.com/dev/pages.save"/>
    /// </summary>
    public interface IPageSaveParameters
    {
        /// <summary>
        /// Новый текст страницы в вики-формате
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Идентификатор вики-страницы
        /// </summary>
        /// <remarks>
        /// Вместо PageId может быть передан параметр Title. 
        /// </remarks>
        int? PageId { get; set; }

        /// <summary>
        /// Идентификатор сообщества, которому принадлежит вики-страница
        /// </summary>
        int? GroupId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, создавшего вики-страницу
        /// </summary>
        int? UserId { get; set; }

        /// <summary>
        /// Название вики-страницы
        /// </summary>
        string Title { get; set; }
    }
}
