
namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления количества различных объектов у пользователя
    /// </summary>
    public interface ICounters
    {
        /// <summary>
        /// Количество фотоальбомов пользователя (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? AlbumsCount { get; set; }

        /// <summary>
        /// Количество видеозаписей пользователя (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? VideosCount { get; set; }

        /// <summary>
        /// Количество аудиозаписей пользователя (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? AudiosCount { get; set; }

        /// <summary>
        /// Количество фотографий пользователя (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? PhotosCount { get; set; }

        /// <summary>
        /// Количество заметок пользователя (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? NotesCount { get; set; }

        /// <summary>
        /// Количество друзей пользователя (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? FriendsCount { get; set; }

        /// <summary>
        /// Количество групп пользователя (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? GroupsCount { get; set; }
        
        /// <summary>
        /// Количество общих друзей с пользователем (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? MutualFriendscount { get; set; }

        /// <summary>
        /// Количество видеозаписей с пользователем (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? UserVideosCount { get; set; }
        
        /// <summary>
        /// Количество подписчиков пользователя (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? FollowersCount { get; set; }
        
        /// <summary>
        /// Количество объектов в "Интересные страницы" пользователя (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? PagesCount { get; set; }
    }
}
