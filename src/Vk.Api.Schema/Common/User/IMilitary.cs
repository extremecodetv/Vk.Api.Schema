using System;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации  о военной службе
    /// </summary>
    public interface IMilitary
    {
        /// <summary>
        /// Номер части, если доступен,
        /// иначе <see langword="null"/> 
        /// </summary>
        string Unit { get; }

        /// <summary>
        /// Идентификатор части, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? Id { get; }

        /// <summary>
        /// Идентификатор страны, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? CountryId { get; }

        /// <summary>
        /// Год начала службы, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? FromDate { get; }

        /// <summary>
        /// Год окончания службы, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? UntilDate { get; }
    }
}
