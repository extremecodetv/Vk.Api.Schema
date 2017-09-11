
namespace Vk.Api.Schema.Parameters.Photo
{
    /// <summary>
    /// Интерфейс представляющий параметры запроса для photos.delete <para/>
    /// Документация: <see href="https://vk.com/dev/photos.delete"/>
    /// </summary>
    public interface IPhotoDeleteParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества
        /// которому принадлежит фотография
        /// </summary>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор фотографии
        /// </summary>
        int PhotoId { get; set; }
    }
}
