
namespace Vk.Api.Schema.Parameters.Account
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для account.registerDevice <para/>
    /// Документация: <see href="https://vk.com/dev/account.registerDevice"/>
    /// </summary>
    public interface IAccountRegisterDeviceParameters
    {
        /// <summary>
        /// Идентификатор устройства, используемый для отправки уведомлений <para/>
        /// Обязательный параметр 
        /// </summary>
        string Token { get; set; }

        /// <summary>
        /// Уникальный идентификатор устройства <para/>
        /// Обязателньый параметр
        /// </summary>
        string DeviceId { get; set; }

        /// <summary>
        /// Название модели устройства
        /// </summary>
        string DeviceModel { get; set; }

        /// <summary>
        /// Год устройства
        /// </summary>
        int DeviceYear { get; set; }

        /// <summary>
        /// Версия операционной системы устройства
        /// </summary>
        string SystemVersion { get; set; }

        /// <summary>
        /// Настройки уведомлений
        /// </summary>
        object Settings { get; set; } //TODO: IPushSettings
    }
}
