using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Docs
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для docs.getById <para/>
    /// Документация: <see href="https://vk.com/dev/docs.getById"/>
    /// </summary>
    public interface IDocsGetByIdParameters
    {
        /// <summary>
        /// Идентификаторы документов
        /// </summary>
        IEnumerable<int> Identifiers { get; set; }   
    }
}