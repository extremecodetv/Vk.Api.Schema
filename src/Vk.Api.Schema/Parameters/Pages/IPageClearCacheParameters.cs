using System;

namespace Vk.Api.Schema.Parameters.Pages
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для pages.clearCache <para/>
    /// Документация: <see href="https://vk.com/dev/pages.clearCache"/>
    /// </summary>
    public interface IPageClearCacheParameters
    {
        /// <summary>
        /// Адрес страницы, закешированную версию которой необходимо очистить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        Uri Url { get; set; }
    }
}
