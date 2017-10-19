using System.ComponentModel;

namespace Vk.Api.Schema.Enums.App
{
    /// <summary>
    /// Платформа
    /// </summary>
    public enum AppPlatform
    {
        /// <summary>
        /// iOS
        /// </summary>
        [Description("ios")]
        Ios,

        /// <summary>
        /// Android
        /// </summary>
        [Description("android")]
        Android,

        /// <summary>
        /// Windows Phone
        /// </summary>
        [Description("winphone")]
        Winphone,

        /// <summary>
        /// Приложения на vk.com
        /// </summary>
        [Description("web")]
        Web
    }
}