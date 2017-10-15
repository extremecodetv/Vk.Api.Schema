namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для market.restoreComment <para/>
    /// Документация: <see href="https://vk.com/dev/market.restore"/>
    /// </summary>
    public interface IMarketRestoreCommentParameters
    {
        /// <summary>
        /// Идентификатор владельца товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор удаленного комментария
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int CommentId { get; set; }
    }
}