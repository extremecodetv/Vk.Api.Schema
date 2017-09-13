
namespace Vk.Api.Schema.Enums.User
{
    /// <summary>
    /// Статус дружбы с пользователем
    /// </summary>
    public enum FriendStatus
    {
        /// <summary>
        /// Не друг
        /// </summary>
        NotAFriend,
        /// <summary>
        /// Исходящий запрос на дружбу/подписку
        /// </summary>
        Outcoming,
        /// <summary>
        /// Входящий запрос на дружбу/подписку
        /// </summary>
        Incoming,
        /// <summary>
        /// Друг
        /// </summary>
        Friend
    }
}
