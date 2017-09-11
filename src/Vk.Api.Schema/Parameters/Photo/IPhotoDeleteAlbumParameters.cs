
namespace Vk.Api.Schema.Parameters.Photo
{
    /// <summary>
    /// Интерфейс представляющий параметры запроса для photos.deleteAlbum <para/>
    /// Документация: <see href="https://vk.com/dev/photos.deleteAlbum"/>
    /// </summary>
    public interface IPhotoDeleteAlbumParameters
    {
        /// <summary>
        /// Идентификатор альбома
        /// </summary>
        int AlbumId { get; set; }

        /// <summary>
        /// Идентификатор сообщества в котором размещен альбом
        /// </summary>
        /// <remarks>
        /// Необязательный параметр
        /// </remarks>
        int? GroupId { get; set; }
    }
}
