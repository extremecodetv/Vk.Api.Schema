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
        PoliticalType? Political { get; set; }

        /// <summary>
        /// Языки, если доступны,
        /// иначе <see langword="null"/>
        /// </summary>
        IEnumerable<string> Languages { get; set; }

        /// <summary>
        /// Мировозрение, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Religion { get; set; }

        /// <summary>
        /// Источники вдохновления, если доступны,
        /// иначе <see langword="null"/>
        /// </summary>
        string InspiredBy { get; set; }

        /// <summary>
        /// Главное в людях, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        PeopleMainType? PeopleMain { get; set; }

        /// <summary>
        /// Главное в жизни, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        LifeMainType? LifeMain { get; set; }

        /// <summary>
        /// Отношение к курению, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        AttitudeType? Smoking { get; set; }

        /// <summary>
        /// Отношению к алкоголю, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        AttitudeType? Alcohol { get; set; }
    }
}
