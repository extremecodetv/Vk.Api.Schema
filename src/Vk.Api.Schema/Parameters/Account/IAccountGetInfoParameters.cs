using Vk.Api.Schema.Enums.Filters;

namespace Vk.Api.Schema.Parameters.Account
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для account.getInfo <para/>
    /// Документация: <see href="https://vk.com/dev/account.getInfo"/>
    /// </summary>
    public interface IAccountGetInfoParameters
    {
        /// <summary>
        /// Список полей, которые необходимо вернуть 
        /// </summary>
        /// <remarks>
        /// По умолчанию - все поля
        /// </remarks>
        InfoField? Fields { get; set; }
    }
}
