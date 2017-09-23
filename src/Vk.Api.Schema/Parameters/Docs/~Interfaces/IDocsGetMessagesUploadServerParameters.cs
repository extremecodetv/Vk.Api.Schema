using Vk.Api.Schema.Enums.Filters;

namespace Vk.Api.Schema.Parameters.Docs
{

    /// <summary>
    /// Интерфейс, представляющий параметры запроса для docs.getMessagesUploadServer <para/>
    /// Документация: <see href="https://vk.com/dev/docs.getMessagesUploadServer"/>
    /// </summary>
    public interface IDocsGetMessagesUploadServerParameters
    {
        /// <summary>
        /// Идентификатор назначения
        /// </summary>
        int? PeerId { get; set; }

        /// <summary>
        /// Тип документа
        /// </summary>
        DocumentUploadServerFilter? Filter { get; set; }
    }
}