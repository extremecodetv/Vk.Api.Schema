namespace Vk.Api.Schema.Parameters.Docs
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для docs.getTypes <para/>
    /// Документация: <see href="https://vk.com/dev/docs.getTypes"/>
    /// </summary>
    public interface IDocsGetTypesParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества <para/>
        /// Обязательный параметр
        /// </summary>
        int OwnerId { get; }
    }
}