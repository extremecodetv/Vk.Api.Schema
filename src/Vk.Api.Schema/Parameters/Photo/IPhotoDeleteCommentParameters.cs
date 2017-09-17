
namespace Vk.Api.Schema.Parameters.Photo
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для photos.deleteComment <para/>
    /// Документация: <see href="https://vk.com/dev/photos.deleteComment"/>
    /// </summary>
    public interface IPhotoDeleteCommentParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, 
        /// которому принадлежит комментарий
        /// </summary>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        int CommentId { get; set; }
    }
}
