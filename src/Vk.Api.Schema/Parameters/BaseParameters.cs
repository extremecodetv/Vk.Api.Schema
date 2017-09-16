using Vk.Api.Schema.Enums;

using Vk.Api.Schema.Serialization.Http;

namespace Vk.Api.Schema.Parameters
{
    /// <summary>
    /// Представляет базовый набор параметров для всех запросов 
    /// </summary>
    public abstract class BaseParameters : IBaseParameters
    {
        private static string accessToken;
        /// <summary>
        /// AccessToken для доступа к функциям API
        /// </summary>
        [HttpProperty("access_token")]
        public string AccessToken => accessToken;
        
        /// <summary>
        /// Используемая версия API
        /// </summary>
        [HttpProperty("v")]
        public string Version => Schema.Version;

        private static Language? language;
        /// <summary>
        /// Язык, на котором необходимо возвращать данные
        /// </summary>
        [HttpProperty("lang")]
        public Language? Language => language;

        private static bool? useHttps;
        /// <summary>
        /// Использование HTTPS протокола для возвращения ссылок и медиаконтента
        /// </summary>
        [HttpProperty("https")]
        public bool? UseHttps => useHttps;

        private static bool? useTestMode;
        /// <summary>
        /// Тестовый режим
        /// </summary>
        [HttpProperty("test_mode")]
        public bool? UseTestMode => useTestMode;

        //TODO: Инциализация
        
    }
}
