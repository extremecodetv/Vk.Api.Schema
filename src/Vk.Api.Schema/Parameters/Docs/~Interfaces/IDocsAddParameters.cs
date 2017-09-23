namespace Vk.Api.Schema.Parameters.Docs
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для docs.add <para/>
    /// Документация: <see href="https://vk.com/dev/docs.add"/>
    /// </summary>
    public interface IDocsAddParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества <para/>
        /// Обязательный параметр
        /// </summary>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор документа <para/>
        /// Обязательный параметр
        /// </summary>
        int DocId { get; set; }

        /// <summary>
        /// Ключ доступа документа
        /// </summary>
        string AccessKey { get; set; }
    }
}