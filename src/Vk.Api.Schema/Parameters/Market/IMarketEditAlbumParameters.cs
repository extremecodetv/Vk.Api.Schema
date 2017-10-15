namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    ///  Интерфейс для представления параметров запроса для market.editAlbum <para/>
    /// Документация: <see href="https://vk.com/dev/market.editAlbum"/>
    /// </summary>
    public interface IMarketEditAlbumParameters
    {
        /// <summary>
        /// Идентификатор владельца подборки
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор подборки
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int AlbumId { get; set; }

        /// <summary>
        /// Название подборки
        /// </summary>
        /// <remarks>
        /// Максимальная длина 128, обязательный параметр
        /// </remarks>
        string Title { get; set; }

        /// <summary>
        /// Идентификатор фотографии-обложки подборки
        /// </summary>
        int? PhotoId { get; set; }

        /// <summary>
        /// Является ли подборка основной
        /// </summary>
        bool? IsMainAlbum { get; set; }
    }
}
