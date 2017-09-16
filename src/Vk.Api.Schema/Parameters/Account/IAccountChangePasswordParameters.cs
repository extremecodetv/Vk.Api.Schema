
namespace Vk.Api.Schema.Parameters.Account
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для account.changePassword <para/>
    /// Документация: <see href="https://vk.com/dev/account.changePassword"/>
    /// </summary>
    public interface IAccountChangePasswordParameters
    {
        /// <summary>
        /// Идентификатор сессии
        /// </summary>
        string RestoreSid { get; set; }

        /// <summary>
        /// Хэш, полученный при авторизации через OAuth
        /// </summary>
        string ChangePasswordHash { get; set; }

        /// <summary>
        /// Текущий пароль пользователя
        /// </summary>
        string OldPassword { get; set; }

        /// <summary>
        /// Новый пароль пользователя
        /// </summary>
        string NewPassword { get; set; }
    }
}
