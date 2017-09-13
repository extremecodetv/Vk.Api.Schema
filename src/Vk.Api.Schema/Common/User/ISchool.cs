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
        /// Идентификатор школы, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        int? Id { get; set; }

        /// <summary>
        /// Идентификатор страны, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        int? CountryId { get; set; }

        /// <summary>
        /// Идентификатор города, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        int? CityId { get; set; }

        /// <summary>
        /// Наименование школы, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Год начала обучения, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? FromDate { get; set; }

        /// <summary>
        /// Год окончания обучения, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? ToDate { get; set; }

        /// <summary>
        /// Год выпуска, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? GraduateDate { get; set; }

        /// <summary>
        /// Буква класса, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        string Class { get; set; }

        /// <summary>
        /// Специализация, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        string Speciality { get; set; }

        /// <summary>
        /// Тип школы, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        SchoolType? Type { get; set; }
    }
}
