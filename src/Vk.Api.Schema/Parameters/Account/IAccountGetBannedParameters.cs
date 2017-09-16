
namespace Vk.Api.Schema.Parameters.Account
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для account.getBanned <para/>
    /// Документация: <see href="https://vk.com/dev/account.getBanned"/>
    /// </summary>
    public interface IAccountGetBannedParameters
    {
        /// <summary>
        /// Смещение
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        int? Count { get; set; }
    }
}
