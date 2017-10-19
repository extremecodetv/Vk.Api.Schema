using System.ComponentModel;

namespace Vk.Api.Schema.Enums.App
{
    /// <summary>
    /// Тип создаваемого списка друзей
    /// </summary>
    public enum AppInvite
    {
        /// <summary>
        /// Доступные для приглашения (не играют в игру)
        /// </summary>
        [Description("invite")]
        Invite,

        /// <summary>
        /// Доступные для отправки запроса (уже играют)
        /// </summary>
        [Description("request")]
        Request
    }
}