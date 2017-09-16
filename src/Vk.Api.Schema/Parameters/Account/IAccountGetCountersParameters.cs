using Vk.Api.Schema.Enums.Filters;

namespace Vk.Api.Schema.Parameters.Account
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для account.getCounters <para/>
    /// Документация: <see href="https://vk.com/dev/account.getCounters"/>
    /// </summary>
    public interface IAccountGetCountersParameters
    {
        /// <summary>
        /// Счетчики, информацию о которых нужно вернуть
        /// </summary>
        CounterFilter? Counters { get; set; }
    }
}
