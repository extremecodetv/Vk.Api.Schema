
namespace Vk.Api.Schema.Parameters.Photo
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для photos.copy <para/>
    /// Документация: <see href="https://vk.com/dev/photos.copy"/>
    /// </summary>
    public interface IPhotoCopyParameters
    {
        /// <summary>
        /// Идентификатор владельца фотографии
        /// </summary>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор фотографии
        /// </summary>
        int PhotoId { get; set; }

        /// <summary>
        /// Код доступа для приватных фотографий 
        /// (необязательный параметр)
        /// </summary>
        string AccessToken { get; set; }
    }
}
