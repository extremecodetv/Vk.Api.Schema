using System.Collections.Generic;

using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления данных из полей профиля пользователя
    /// </summary>
    public interface IUserProfileFields
    {
        /// <summary>
        /// Содержимое поля профиля "О себе", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string About { get; set; }
        
        /// <summary>
        /// Содержимое поля профиля "Деятельность", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Activities { get; set; }

        /// <summary>
        /// Содержимое поля профиля "Любимая музыка", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Music { get; set; }

        /// <summary>
        /// Содержимое поля профиля "Любимые игры", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Games { get; set; }

        /// <summary>
        /// Содержимое поля профиля "Книги", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Books { get; set; }

        /// <summary>
        /// Содержимое поля профиля "Интересы", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Interests { get; set; }

        /// <summary>
        /// Содержимое поля профиля "Любимые фильмы", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Movies { get; set; }

        /// <summary>
        /// Информация поля профиля "Любимые цитаты", если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        string Quotes { get; set; }

        /// <summary>
        /// Информация поля профиля "Любимые телешоу", если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        string Tv { get; set; }

        /// <summary>
        /// Информация о карьере пользователя, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        ICareer Career { get; set; }

        /// <summary>
        /// Информация о городе, указанном в профиле пользователя, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        ICity City { get; set; }

        /// <summary>
        /// Информация о высшем учебном заведении пользователя, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IEducation Education { get; set; }

        /// <summary>
        /// Информация о военной службе пользователя, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IMilitary Military { get; set; }

        /// <summary>
        /// Информация о текущем роде деятельности пользователя, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IOccupation Occupation { get; set; }

        /// <summary>
        /// Информация поля профиля "Жизненная позиция", если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IPersonal Personal { get; set; }

        /// <summary>
        /// Коллекция школ, в которых учился пользователь, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IEnumerable<ISchool> Schools { get; set; }

        /// <summary>
        /// Коллекция родственников текущего пользователя, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IEnumerable<IRelative> Relatives { get; set; }

        /// <summary>
        /// Семейное положение пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        RelationshipType? Relationship { get; set; }

        //TODO: relation_partner

        /// <summary>
        /// Коллекция вузов, в которых учился пользователь, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IEnumerable<IUniversity> Universities { get; set; }

    }
}
