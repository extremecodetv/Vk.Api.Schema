using System;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации о карьере <see cref="IUser"/>
    /// </summary>
    public interface ICareer
    {
        /// <summary>
        /// Идентификатор сообщества (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? GroupId { get; set; }

        /// <summary>
        /// Название компании (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        string Company { get; set; }

        /// <summary>
        /// Идентификатор страны (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? CountryId { get; set; }

        /// <summary>
        /// Идентификатор города (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? CityId { get; set; }

        /// <summary>
        /// Название города (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        string CityName { get; set; }

        /// <summary>
        /// Год начала работы (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? FromDate { get; set; }

        /// <summary>
        /// Год окончания работы (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? UntilDate { get; set; }

        /// <summary>
        /// Должность (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        string Position { get; set; }
    }
}
