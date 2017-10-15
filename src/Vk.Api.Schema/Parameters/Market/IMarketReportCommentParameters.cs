using Vk.Api.Schema.Enums;

namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для market.reportComment <para/>
    /// Документация: <see href="https://vk.com/dev/market.reportComment"/>
    /// </summary>
    public interface IMarketReportCommentParameters
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
        /// Причина жалобы
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        ReportContentType Reason { get; set; }
    }
}
