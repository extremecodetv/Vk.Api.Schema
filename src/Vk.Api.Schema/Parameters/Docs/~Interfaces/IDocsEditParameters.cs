using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Docs
{

    /// <summary>
    /// Интерфейс, представляющий параметры запроса для docs.edit <para/>
    /// Документация: <see href="https://vk.com/dev/docs.edit"/>
    /// </summary>
    public interface IDocsEditParameters
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
        /// Название документа
        /// </summary>
        /// <remarks>
        /// Максимальная длина 128
        /// </remarks>
        string Title { get; set; }

        /// <summary>
        /// Метки для поиска
        /// </summary>
        IEnumerable<string> Tags { get; set; }
    }
}