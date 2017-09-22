using System;

using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации о школе
    /// </summary>
    public interface ISchool
    {
        /// <summary>
        /// Идентификатор школы, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? Id { get; }

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
        /// Наименование школы, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Год начала обучения, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? FromDate { get; }

        /// <summary>
        /// Год окончания обучения, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? ToDate { get; }

        /// <summary>
        /// Год выпуска, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? GraduateDate { get; }

        /// <summary>
        /// Буква класса, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        string Class { get; }

        /// <summary>
        /// Специализация, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        string Speciality { get; }

        /// <summary>
        /// Тип школы, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        SchoolType? Type { get; }
    }
}
