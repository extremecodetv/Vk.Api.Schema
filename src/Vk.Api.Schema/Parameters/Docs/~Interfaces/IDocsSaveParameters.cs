using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Docs
{

    /// <summary>
    /// Интерфейс, представляющий параметры запроса для docs.save <para/>
    /// Документация: <see href="https://vk.com/dev/docs.save"/>
    /// </summary>
    public interface IDocsSaveParameters
    {
        /// <summary>
        /// TODO: Description
        /// </summary>
        string File { get; set; }

        /// <summary>
        /// Название документа
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Метки для поиска
        /// </summary>
        IEnumerable<string> Tags { get; set; }
    }
}