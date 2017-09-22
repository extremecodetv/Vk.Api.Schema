using System;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации о карьере <see cref="IUser"/>
    /// </summary>
    public interface ICareer
    {
        /// <summary>
        /// Идентификатор сообщества, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? GroupId { get; }

        /// <summary>
        /// Название компании, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Company { get; }

        /// <summary>
        /// Идентификатор страны, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? CountryId { get; }

        /// <summary>
        /// Идентификатор города, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? CityId { get; }

        /// <summary>
        /// Название города, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string CityName { get; }

        /// <summary>
        /// Год начала работы, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? FromDate { get; }

        /// <summary>
        /// Год окончания работы, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? UntilDate { get; }

        /// <summary>
        /// Должность, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        string Position { get; }
    }
}
