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
        string About { get; }
        
        /// <summary>
        /// Содержимое поля профиля "Деятельность", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Activities { get; }

        /// <summary>
        /// Содержимое поля профиля "Любимая музыка", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Music { get; }

        /// <summary>
        /// Содержимое поля профиля "Любимые игры", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Games { get; }

        /// <summary>
        /// Содержимое поля профиля "Книги", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Books { get; }

        /// <summary>
        /// Содержимое поля профиля "Интересы", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Interests { get; }

        /// <summary>
        /// Содержимое поля профиля "Любимые фильмы", если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Movies { get; }

        /// <summary>
        /// Информация поля профиля "Любимые цитаты", если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        string Quotes { get; }

        /// <summary>
        /// Информация поля профиля "Любимые телешоу", если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        string Tv { get; }

        /// <summary>
        /// Информация о карьере пользователя, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        ICareer Career { get; }

        /// <summary>
        /// Информация о городе, указанном в профиле пользователя, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        ICity City { get; }

        /// <summary>
        /// Информация о высшем учебном заведении пользователя, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IEducation Education { get; }

        /// <summary>
        /// Информация о военной службе пользователя, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IMilitary Military { get; }

        /// <summary>
        /// Информация о текущем роде деятельности пользователя, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IOccupation Occupation { get; }

        /// <summary>
        /// Информация поля профиля "Жизненная позиция", если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IPersonal Personal { get; }

        /// <summary>
        /// Коллекция школ, в которых учился пользователь, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IEnumerable<ISchool> Schools { get; }

        /// <summary>
        /// Коллекция родственников текущего пользователя, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IEnumerable<IRelative> Relatives { get; }

        /// <summary>
        /// Семейное положение пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        RelationshipType? Relationship { get; }

        //TODO: relation_partner

        /// <summary>
        /// Коллекция вузов, в которых учился пользователь, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        IEnumerable<IUniversity> Universities { get; }

    }
}
