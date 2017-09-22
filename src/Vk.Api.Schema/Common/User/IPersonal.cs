using System.Collections.Generic;

using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации из раздела "Жизненная позиция"
    /// </summary>
    public interface IPersonal
    {
        /// <summary>
        /// Политические предпочтения, если доступны,
        /// иначе <see langword="null"/>
        /// </summary>
        PoliticalType? Political { get; }

        /// <summary>
        /// Языки, если доступны,
        /// иначе <see langword="null"/>
        /// </summary>
        IEnumerable<string> Languages { get; }

        /// <summary>
        /// Мировозрение, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Religion { get; }

        /// <summary>
        /// Источники вдохновления, если доступны,
        /// иначе <see langword="null"/>
        /// </summary>
        string InspiredBy { get; }

        /// <summary>
        /// Главное в людях, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        PeopleMainType? PeopleMain { get; }

        /// <summary>
        /// Главное в жизни, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        LifeMainType? LifeMain { get; }

        /// <summary>
        /// Отношение к курению, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        AttitudeType? Smoking { get; }

        /// <summary>
        /// Отношению к алкоголю, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        AttitudeType? Alcohol { get; }
    }
}
