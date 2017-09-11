
namespace Vk.Api.Schema.Parameters.Photo
{
    /// <summary>
    /// Интерфейс представляющий параметры запроса для photos.confirmTag <para/>
    /// Документация: <see href="https://vk.com/dev/photos.confirmTag"/>
    /// </summary>
    public interface IPhotoConfirmTagParameters
    {
        /// <summary>
        /// Идентификатор фотографии
        /// </summary>
        int PhotoId { get; set; }

        /// <summary>
        /// Идентификатор отметки на фотографии
        /// </summary>
        int TagId { get; set; }

        /// <summary>
        /// Идентификатор пользователя или сообщества которому
        /// принадлежит фотография (необязательный параметр)
        /// </summary>
        int? OwnerId { get; set; }
    }
}
