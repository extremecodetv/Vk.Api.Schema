
namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления статуса пользователя
    /// </summary>
    public interface IUserStatus
    {
        /// <summary>
        /// Статус пользователя, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        string Status { get; }

        //TODO: audio_status

    }
}
