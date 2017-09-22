using System;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации информацию о вузе
    /// </summary>
    public interface IUniversity
    {
        /// <summary>
        /// Идентификатор вуза, если доступен,
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
        /// Наименование вуза, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Идентификатор факультета, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? FacultyId { get; }

        /// <summary>
        /// Наименование факультета, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string FacultyName { get; }

        /// <summary>
        /// Идентификатор кафедры, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? ChairId { get; }

        /// <summary>
        /// Наименование кафедры, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string ChairName { get; }

        /// <summary>
        /// Год окончания обучения, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? GraduationDate { get; }

        /// <summary>
        /// Форма обучения, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        string EducationForm { get; }

        /// <summary>
        /// Статус обучения, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        string EducationStatus { get; }
    }
}
