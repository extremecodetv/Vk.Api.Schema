namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    ///  Интерфейс для представления параметров запроса для market.deleteComment <para/>
    /// Документация: <see href="https://vk.com/dev/market.deleteComment"/>
    /// </summary>
    public interface IMarketDeleteCommentParameters
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
    }
}
