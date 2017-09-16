using Vk.Api.Schema.Enums;

namespace Vk.Api.Schema
{
    /// <summary>
    /// Интерфейс, представляющий базовый параметры API
    /// </summary>
    public interface IBaseParameters
    {
        /// <summary>
        /// AccessToken для доступа к функциям API
        /// </summary>
        string AccessToken { get; }

        /// <summary>
        /// Используемая версия API
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Язык, на котором необходимо возвращать данные
        /// </summary>
        Language? Language { get; }

        /// <summary>
        /// Использование HTTPS протокола для возвращения ссылок и медиаконтента
        /// </summary>
        bool? UseHttps { get; }

        /// <summary>
        /// Тестовый режим
        /// </summary>
        bool? UseTestMode { get; }
    }
}
