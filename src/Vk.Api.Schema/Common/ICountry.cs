using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vk.Api.Schema.Common
{
    /// <summary>
    /// Интерфейс, представляющий данные о стране
    /// </summary>
    public interface ICountry
    {
        /// <summary>
        /// Идентификатор страны
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Название страны 
        /// </summary>
        string Title { get; }
    }
}
