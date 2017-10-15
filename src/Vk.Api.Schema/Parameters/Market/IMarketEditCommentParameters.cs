using System.Collections.Generic;
using Vk.Api.Schema.Common.Media;

namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    ///  Интерфейс для представления параметров запроса для market.editComment <para/>
    /// Документация: <see href="https://vk.com/dev/market.editComment"/>
    /// </summary>
    public interface IMarketEditCommentParameters
    {
        /// <summary>
        /// Идентификатор владельца товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int CommentId { get; set; }

        /// <summary>
        /// Текст комментария
        /// </summary>
        /// <remarks>
        /// Необязателен, если используются вложения
        /// </remarks>
        string Message { get; set; }

        /// <summary>
        /// Список объектов, приложенных к комментарию
        /// </summary>
        /// <remarks>
        /// Необязателен, если задан текст комментария
        /// </remarks>
        IEnumerable<IAttachment> Attachments { get; set; }
    }
}
