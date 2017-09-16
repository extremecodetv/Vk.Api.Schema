
namespace Vk.Api.Schema.Parameters.Account
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для account.getPushSettings <para/>
    /// Документация: <see href="https://vk.com/dev/account.getPushSettings"/>
    /// </summary>
    public interface IAccountGetPushSettings
    {
        /// <summary>
        /// Идентификатор устройства
        /// </summary>
        string DeviceId { get; set; }
    }
}
