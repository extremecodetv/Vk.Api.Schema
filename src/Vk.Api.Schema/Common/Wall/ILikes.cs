namespace Vk.Api.Schema.Common.Wall
{
    /// <summary>
    /// Интерфейс, представляющий информацию о лайках к записи
    /// </summary>
    public interface ILikes
    {
        /// <summary>
        /// Число пользователей, которым понравилась запись
        /// </summary>
        int Count { get; }

        /// <summary>
        /// <see langword="true"/>, если текущий пользователь отметил запись "Мне нравится"
        /// </summary>
        bool? UserLikes { get; }

        /// <summary>
        /// <see langword="true"/>, если текущий пользователь может поставить отметку "Мне нравится"
        /// </summary>
        bool? CanLike { get; }

        /// <summary>
        /// <see langword="true"/>,  если текущий пользователь может сделать репост записи
        /// </summary>
        bool? CanPublish { get; }

    }
}