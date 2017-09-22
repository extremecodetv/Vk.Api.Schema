
namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления количества различных объектов у пользователя
    /// </summary>
    public interface ICounters
    {
        /// <summary>
        /// Количество фотоальбомов пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? AlbumsCount { get; }

        /// <summary>
        /// Количество видеозаписей пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? VideosCount { get; }

        /// <summary>
        /// Количество аудиозаписей пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? AudiosCount { get; }

        /// <summary>
        /// Количество фотографий пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? PhotosCount { get; }

        /// <summary>
        /// Количество заметок пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? NotesCount { get; }

        /// <summary>
        /// Количество друзей пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? FriendsCount { get; }

        /// <summary>
        /// Количество групп пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? GroupsCount { get; }
        
        /// <summary>
        /// Количество общих друзей с пользователем, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? MutualFriendscount { get; }

        /// <summary>
        /// Количество видеозаписей с пользователем, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? UserVideosCount { get; }
        
        /// <summary>
        /// Количество подписчиков пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? FollowersCount { get; }
        
        /// <summary>
        /// Количество объектов в "Интересные страницы" пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? PagesCount { get; }
    }
}
