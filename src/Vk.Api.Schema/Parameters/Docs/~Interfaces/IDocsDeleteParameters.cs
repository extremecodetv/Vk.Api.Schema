namespace Vk.Api.Schema.Parameters.Docs
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для docs.delete <para/>
    /// Документация: <see href="https://vk.com/dev/docs.delete"/>
    /// </summary>
    public interface IDocsDeleteParameters
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
    }
}