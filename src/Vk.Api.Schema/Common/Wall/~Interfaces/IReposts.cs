namespace Vk.Api.Schema.Common.Wall
{
    /// <summary>
    /// Интерфейс, представляющий информацию о репостах записи
    /// </summary>
    public interface IReposts
    {
        /// <summary>
        /// Количество репостов
        /// </summary>
        int Count { get; }

        /// <summary>
        /// <see langword="true"/>, если пользователь репостнул запись
        /// </summary>
        bool? UserReposted { get; }
    }
}