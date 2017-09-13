using System;
using System.Collections.Generic;

using Vk.Api.Schema.Enums;
using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации о пользователе ВКонтакте <para/>
    /// Документация: <see href="https://vk.com/dev/objects/user">objects.user</see>
    /// </summary>
    public interface IUser : IUserMinimal, IUserConnections, 
        IUserExports, IUserPhotos, IUserProfileFields, 
        IUserStatus
    {   
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
        /// Количество общих друзей с текущим пользователем
        /// </summary>
        int? CommonCount { get; set; }

        /// <summary>
        /// Координаты, по которым была вырезана фотография профиля и миниатюра
        /// </summary>
        ICropPhoto CropPhoto { get; set; }

        /// <summary>
        /// Короткий адрес страницы
        /// </summary>
        /// <remarks>
        /// Если недоступен, то равен '"id" + UserId'
        /// </remarks>
        string Domain { get; set; }

        //TODO: Name case

        /// <summary>
        /// Количество подписчиков пользователя (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? FollowersCount { get; set; }

        /// <summary>
        /// Статус дружбы с пользователем
        /// </summary>
        FriendStatus? FriendStatus { get; set; }

        /// <summary>
        /// Известен ли номер мобильного телефона, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        bool? HasMobile { get; set; }

        /// <summary>
        /// Установил ли пользователь фотографию профиля, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        bool? HasPhoto { get; set; }

        /// <summary>
        /// Название родного города, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        string HomeTown { get; set; }

        /// <summary>
        /// Добавлен ли текущий пользователь в закладки, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        bool? IsFavorite { get; set; }

        /// <summary>
        /// Скрыт ли пользователь из ленты новостей, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        bool? IsHiddenFromFeed { get; set; }

        /// <summary>
        /// Время последнего посещения, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        ILastSeen LastSeen { get; set; }

        /// <summary>
        /// Идентификаторы списков друзей в которые добавлен пользователь, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        IEnumerable<string> Lists { get; set; }

        /// <summary>
        /// Девичья фамилия, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        string MaidenName { get; set; }

        /// <summary>
        /// Никнейм или отчество пользователя, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        string Nickname { get; set; }

        /// <summary>
        /// Находится ли пользователь сейчас на сайте, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        bool? IsOnline { get; set; }

        /// <summary>
        /// Короткое имя страницы пользователя, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        string ScreenName { get; set; }

        /// <summary>
        /// Пол пользователя, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        Sex? Sex { get; set; }

        /// <summary>
        /// Сайт пользователя, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        Uri Site { get; set; }

        /// <summary>
        /// Временная зона пользователя, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        int? TimeZone { get; set; }

        /// <summary>
        /// Является ли страница верифицированной, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        bool? IsVerified { get; set; }

        /// <summary>
        /// Включены ли комментарии на стене, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        bool? WallCommentsAvailabale { get; set; }
    }
}
