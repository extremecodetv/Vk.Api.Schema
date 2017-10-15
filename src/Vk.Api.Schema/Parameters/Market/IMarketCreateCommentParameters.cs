using System.Collections.Generic;
using Vk.Api.Schema.Common.Media;

namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    ///  Интерфейс для представления параметров запроса для market.createComment <para/>
    /// Документация: <see href="https://vk.com/dev/market.createComment"/>
    /// </summary>
    public interface IMarketCreateCommentParameters
    {
        /// <summary>
        /// Идентификатор владельца товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int ItemId { get; set; }

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

        /// <summary>
        /// Опубликован ли комментарий от имени группы
        /// </summary>
        /// <remarks>
        /// Если не был задан, используется <see langword="false"/>
        /// </remarks>
        bool? FromGroup { get; set; }

        /// <summary>
        /// Идентификатор комментария, в ответ на который должен быть добавлен новый комментарий
        /// </summary>
        int? ReplyToComment { get; set; }

        /// <summary>
        /// Идентификатор стикера
        /// </summary>
        int? StickerId { get; set; }

        /// <summary>
        /// Уникальный идентификатор, предназначенный для предотвращения повторной отправки одинакового комментария
        /// </summary>
        string Guid { get; set; }
    }
}
