using Vk.Api.Schema.Enums;

namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для market.report <para/>
    /// Документация: <see href="https://vk.com/dev/market.report"/>
    /// </summary>
    public interface IMarketReportParameters
    {
        /// <summary>
        /// Идентификатор владельца товаров
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
        /// Причина жалобы
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        ReportContentType Reason { get; set; }
    }
}
