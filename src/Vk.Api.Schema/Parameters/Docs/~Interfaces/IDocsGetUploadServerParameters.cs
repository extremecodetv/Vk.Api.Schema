namespace Vk.Api.Schema.Parameters.Docs
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для docs.getUploadServer <para/>
    /// Документация: <see href="https://vk.com/dev/docs.getUploadServer"/>
    /// </summary>
    public interface IDocsGetUploadServerParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        int? GroupId { get; set; }
    }
}