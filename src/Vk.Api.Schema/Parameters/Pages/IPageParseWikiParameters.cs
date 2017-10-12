namespace Vk.Api.Schema.Parameters.Pages
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для pages.parseWiki <para/>
    /// Документация: <see href="https://vk.com/dev/pages.parseWiki"/>
    /// </summary>
    public interface IPageParseWikiParameters
    {
        /// <summary>
        /// Текст в вики-формате
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        string Text { get; set; }

        /// <summary>
        /// Идентификатор группы, в контексте которой интерпретируется данная страница
        /// </summary>
        int? GroupId { get; set; }
    }
}
