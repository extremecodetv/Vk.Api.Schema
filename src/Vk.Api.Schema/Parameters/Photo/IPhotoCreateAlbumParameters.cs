
namespace Vk.Api.Schema.Parameters.Photo
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для photos.createAlbum <para/>
    /// Документация: <see href="https://vk.com/dev/photos.createAlbum"/>
    /// </summary>
    public interface IPhotoCreateAlbumParameters
    {
        /// <summary>
        /// Название альбома
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Идентификатор сообщества, в котором создается альбом
        /// </summary>
        int? GroupId { get; set; }
        
        /// <summary>
        /// Описание альбома
        /// </summary>
        string Description { get; set; }

        //TODO: Privacy view

        //TODO: Privacy comment

        /// <summary>
        /// Кто может загружать фотографии в альбом. Если <see langword="true"/>, 
        /// то только администраторы и редакторы сообщества
        /// </summary>
        /// <remarks>
        /// Только для альбомов сообществ
        /// </remarks>
        bool? UploadByAdminsOnly { get; set; }

        /// <summary>
        /// Доступно ли комментирование альбома. Если <see langword="true"/>,
        /// то никто не сможет комментировать
        /// </summary>
        /// <remarks>
        /// Только для альбомов сообществ
        /// </remarks>
        bool? CommentsDisabled { get; set; }
    }
}
