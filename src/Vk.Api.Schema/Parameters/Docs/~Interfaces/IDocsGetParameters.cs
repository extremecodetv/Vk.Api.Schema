using Vk.Api.Schema.Enums.Media;

namespace Vk.Api.Schema.Parameters.Docs
{

    /// <summary>
    /// Интерфейс, представляющий параметры запроса для docs.get <para/>
    /// Документация: <see href="https://vk.com/dev/docs.get"/>
    /// </summary>
    public interface IDocsGetParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества
        /// </summary>
        int? OwnerId { get; set; }

        /// <summary>
        /// Количество документов, информацию о которых необходимо вернуть
        /// </summary>
        int? Count { get; set; }

        /// <summary>
        /// Смещение
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Фильтр по типу документа
        /// </summary>
        DocumentType? Type { get; set; }
    }
}