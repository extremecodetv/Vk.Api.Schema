using System;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации информацию о ВУЗе
    /// </summary>
    public interface IUniversity
    {
        /// <summary>
        /// Идентификатор ВУЗа, (если доступно)
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
        /// Наименование ВУЗа, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Идентификатор факультета, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        int? FacultyId { get; set; }

        /// <summary>
        /// Наименование факультета, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        string FacultyName { get; set; }

        /// <summary>
        /// Идентификатор кафедры, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        int? ChairId { get; set; }

        /// <summary>
        /// Наименование кафедры, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        string ChairName { get; set; }

        /// <summary>
        /// Год окончания обучения, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? GraduationDate { get; set; }

        /// <summary>
        /// Форма обучения, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        string EducationForm { get; set; }

        /// <summary>
        /// Статус обучения, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        string EducationStatus { get; set; }
    }
}
