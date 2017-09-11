using System;
using Vk.Api.Schema.Enums;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации о пользователе ВКонтакте <para/>
    /// Документация: <see href="https://vk.com/dev/objects/user">objects.user</see>
    /// </summary>
    public interface IUser : IUserMinimal, IUserConnections
    {        
        /// <summary>
        /// Содержимое поля профиля "О себе" (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        string About { get; set; }

        /// <summary>
        /// Содержимое поля профиля "Деятельность" (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        string Activities { get; set; }

        /// <summary>
        /// Дата рождения пользователя в формате D.M.YYYY или D.M (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? BirthDate { get; set; }

        /// <summary>
        /// Находится ли пользователь в черном списке
        /// </summary>
        bool IsBlacklisted { get; set; }

        /// <summary>
        /// Находится ли пользователь в черном списке у текущего пользователя
        /// </summary>
        bool IsBlacklistedByMe { get; set; }

        /// <summary>
        /// Содержимое поля профиля "Книги" (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        string Books { get; set; }

        /// <summary>
        /// Может ли текущий пользователь оставлять записи на стене
        /// </summary>
        bool CanPost { get; set; }

        /// <summary>
        /// Может ли текущий пользователь видеть чужие записи на стене
        /// </summary>
        bool CanSeeAllPosts { get; set; }

        /// <summary>
        /// Будет ли отправлено уведомление пользователю о заявке в друзья
        /// от текущего пользователя
        /// </summary>
        bool CanSendFreindRequest { get; set; }

        /// <summary>
        /// Может ли текущий пользователь отправить личное сообщение
        /// </summary>
        bool CanWritePrivateMessage { get; set; }

        /// <summary>
        /// Информация о карьере пользователя
        /// </summary>
        ICareer Career { get; set; }

        /// <summary>
        /// Информация о городе указанном в профиле пользователя
        /// </summary>
        ICity City { get; set; }

        /// <summary>
        /// Количество общих друзей с текущим пользователем
        /// </summary>
        int? CommonCount { get; set; }

        //TODO: Connections


    }
}
