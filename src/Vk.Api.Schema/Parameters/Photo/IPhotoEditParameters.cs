
namespace Vk.Api.Schema.Parameters.Photo
{
    /// <summary>
    /// Интерфейс представляющий параметры запроса для photos.edit <para/>
    /// Документация: <see href="https://vk.com/dev/photos.edit"/>
    /// </summary>
    public interface IPhotoEditParameters
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

        /// <summary>
        /// Новый текст описания к фотографии
        /// </summary>
        /// <remarks>
        /// Если не задан, считается пустой строкой
        /// </remarks>
        string Caption { get; set; }

        /// <summary>
        /// Географическая широта
        /// </summary>
        double? Latitude { get; set; }

        /// <summary>
        /// Географическая долгота
        /// </summary>
        double? Longitude { get; set; }

        /// <summary>
        /// Название места
        /// </summary>
        string Place { get; set; }

        /// <summary>
        /// Идентификатор в Forsquare
        /// </summary>
        int? ForsquareId { get; set; }

        /// <summary>
        /// Необходимо ли удалить место, 
        /// если <see langword="true"/>, то удалится
        /// </summary>
        bool? DeletePlace { get; set; }
    }
}
