
namespace Vk.Api.Schema.Parameters.Account
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для account.getActiveOffers <para/>
    /// Документация: <see href="https://vk.com/dev/account.getActiveOffers"/>
    /// </summary>
    public interface IAccountGetActiveOffersParameters
    {
        /// <summary>
        /// Смещение, необходимое для выборки определенного подмножества офферов
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество офферов, которое необходимо получить 
        /// </summary>
        /// <remarks>
        /// Максимальное значение - 100
        /// </remarks>
        int? Count { get; set; }
    }
}
