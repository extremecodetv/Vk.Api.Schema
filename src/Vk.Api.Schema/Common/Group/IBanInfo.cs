using System;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Интерфейс, представляющий информацию о блокировке пользователя
    /// </summary>
    public interface IBanInfo
    {
        /// <summary>
        /// Дата окончания блокировки
        /// </summary>
        DateTime EndDate { get; }

        /// <summary>
        /// Комментарий к блокировке
        /// </summary>
        string Comment { get; }
    }
}
