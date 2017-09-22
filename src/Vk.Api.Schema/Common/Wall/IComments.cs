namespace Vk.Api.Schema.Common.Wall
{
    /// <summary>
    /// Интерфейс, представляющий информацию о комментариях
    /// </summary>
    public interface IComments
    {
        /// <summary>
        /// Количество комментариев
        /// </summary>
        int Count { get; }

        /// <summary>
        /// <see langword="true"/>, если текущий пользователь может комментировать запись
        /// </summary>
        bool CanPost { get; }

        /// <summary>
        /// <see langword="true"/>,  если сообщества могут комментировать запись
        /// </summary>
        bool GroupsCanPost { get; }
    }
}