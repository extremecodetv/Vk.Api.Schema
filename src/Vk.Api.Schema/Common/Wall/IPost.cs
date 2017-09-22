using System;

using Vk.Api.Schema.Enums.Wall;

namespace Vk.Api.Schema.Common.Wall
{
    /// <summary>
    /// Интерфейс для представления информации о записи на стене пользователя или сообщества "ВКонтакте"<para/>
    /// Документация: <see href="https://vk.com/dev/objects/post">objects.post</see>
    /// </summary>
    public interface IPost
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Идентификатор владельца стены
        /// </summary>
        int OwnerId { get; }

        /// <summary>
        /// Идентификатор автора записи
        /// </summary>
        int FromId { get; }

        /// <summary>
        /// Время публикации записи
        /// </summary>
        DateTime Date { get; }

        /// <summary>
        /// Текст записи, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Text { get; }

        /// <summary>
        /// Идентификатор владельца записи, в ответ на которую была оставлена текущая, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? ReplyOwnerId { get; }

        /// <summary>
        /// Идентификатор записи, в ответ на которую была оставлена текущая, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? ReplyPostId { get; }

        /// <summary>
        /// <see langword="true"/>, если запись была создана с опцией только для друзей, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? IsFriendsOnly { get; }

        /// <summary>
        /// Информация о комментариях к записи, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        IComments Comments { get; }

        /// <summary>
        /// Информация о лайках к записи, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        ILikes Likes { get; }

        /// <summary>
        /// Информация о репостах записи, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        IReposts Reposts { get; }

        /// <summary>
        /// Информация о просмотрах записи, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        IViews Views { get; }

        /// <summary>
        /// Тип записи, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        PostType? Type { get; }

        /// <summary>
        /// Информация о способе размещения записи, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        IPostSource PostSource { get; }

        //TODO: Attachments

        //TODO: Geo

        /// <summary>
        /// Идентификатор автора, если запись была опубликована от имени
        /// сообщества и подписана пользователем, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? SignerId { get; }

        //TODO: copy_history: fucking docs

        /// <summary>
        /// <see langword="true" />, если текущий пользователь может закрепить запись, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? CanPin { get; }

        /// <summary>
        /// <see langword="true" />, если текущий пользователь может удалить запись, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? CanDelete { get; }

        /// <summary>
        /// <see langword="true" />, если текущий пользователь может редактировать запись, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? CanEdit { get; }

        /// <summary>
        /// <see langword="true" />, если запись закреплена, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? IsPinned { get; }

        /// <summary>
        /// <see langword="true" />, если запись содержит отметку "реклама", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? MarkedAsAds { get; }
    }
}