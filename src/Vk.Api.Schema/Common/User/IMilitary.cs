using System;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации  о военной службе
    /// </summary>
    public interface IMilitary
    {
        /// <summary>
        /// Номер части, (если доступно)
        /// иначе <see langword="null"/> 
        /// </summary>
        string Unit { get; set; }

        /// <summary>
        /// Идентификатор части, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        int? Id { get; set; }

        /// <summary>
        /// Идентификатор страны, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        int? CountryId { get; set; }

        /// <summary>
        /// Год начала службы, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? FromDate { get; set; }

        /// <summary>
        /// Год окончания службы, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? UntilDate { get; set; }
    }
}
