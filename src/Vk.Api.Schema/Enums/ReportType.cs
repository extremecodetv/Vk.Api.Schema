using System.ComponentModel;

namespace Vk.Api.Schema.Enums
{
    /// <summary>
    /// Тип жалобы на пользователя
    /// </summary>
    public enum ReportType
    {
        /// <summary>
        /// Порнография
        /// </summary>
        [Description("porn")]
        Porn,
        /// <summary>
        /// Спам
        /// </summary>
        [Description("spam")]
        Spam,
        /// <summary>
        /// Оскорбительное поведение
        /// </summary>
        [Description("insult")]
        Insult,
        /// <summary>
        /// Рекламная страница
        /// </summary>
        [Description("advertisment")]
        Advertisment
    }
}
