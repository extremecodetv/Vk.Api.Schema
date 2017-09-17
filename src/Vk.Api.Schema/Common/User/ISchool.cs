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
        int? Id { get; set; }

        /// <summary>
        /// Идентификатор страны, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? CountryId { get; set; }

        /// <summary>
        /// Идентификатор города, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? CityId { get; set; }

        /// <summary>
        /// Наименование школы, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Год начала обучения, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? FromDate { get; set; }

        /// <summary>
        /// Год окончания обучения, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? ToDate { get; set; }

        /// <summary>
        /// Год выпуска, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? GraduateDate { get; set; }

        /// <summary>
        /// Буква класса, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        string Class { get; set; }

        /// <summary>
        /// Специализация, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        string Speciality { get; set; }

        /// <summary>
        /// Тип школы, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        SchoolType? Type { get; set; }
    }
}
