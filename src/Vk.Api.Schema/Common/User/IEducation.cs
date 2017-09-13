using System;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации о высшем учебном заведении
    /// </summary>
    public interface IEducation
    {
        /// <summary>
        /// Идентификатор университета (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? UniversityId { get; set; }

        /// <summary>
        /// Название университета (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        string UniversityName { get; set; }

        /// <summary>
        /// Идентификатор факультета (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? FacultyId { get; set; }

        /// <summary>
        /// Название факультета (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        string FacultyName { get; set; }

        /// <summary>
        /// Год окончания (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? Graduation { get; set; }
    }
}
