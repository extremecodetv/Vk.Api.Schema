namespace Vk.Api.Schema.Parameters.Docs
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для docs.search <para/>
    /// Документация: <see href="https://vk.com/dev/docs.search"/>
    /// </summary>
    public interface IDocsSearchParameters
    {
        /// <summary>
        /// Строка поискового запроса <para/>
        /// Обязательный параметр
        /// </summary>
        string Query { get; set; }

        /// <summary>
        /// Количество документов,которое необходимо вернуть
        /// </summary>
        int? Count { get; set; }

        /// <summary>
        /// Смещение
        /// </summary>
        int? Offset { get; set; }
    }
}