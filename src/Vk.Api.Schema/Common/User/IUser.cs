using System;
using System.Collections.Generic;

using Vk.Api.Schema.Enums;
using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации о пользователе "ВКонтакте" <para/>
    /// Документация: <see href="https://vk.com/dev/objects/user">objects.user</see>
    /// </summary>
    public interface IUser : IUserMinimal, IUserConnections, 
        IUserExports, IUserPhotos, IUserProfileFields, 
        IUserStatus
    {   
        /// <summary>
        /// Дата рождения пользователя в формате D.M.YYYY или D.M, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? BirthDate { get; }

        /// <summary>
        /// Находится ли пользователь в черном списке
        /// </summary>
        bool IsBlacklisted { get; }

        /// <summary>
        /// Находится ли пользователь в черном списке у текущего пользователя
        /// </summary>
        bool IsBlacklistedByMe { get; }

        /// <summary>
        /// Может ли текущий пользователь оставлять записи на стене
        /// </summary>
        bool CanPost { get; }

        /// <summary>
        /// Может ли текущий пользователь видеть чужие записи на стене
        /// </summary>
        bool CanSeeAllPosts { get; }

        /// <summary>
        /// Будет ли отправлено уведомление пользователю о заявке в друзья
        /// от текущего пользователя
        /// </summary>
        bool CanSendFreindRequest { get; }

        /// <summary>
        /// Может ли текущий пользователь отправить личное сообщение
        /// </summary>
        bool CanWritePrivateMessage { get; }

        /// <summary>
        /// Количество общих друзей с текущим пользователем
        /// </summary>
        int? CommonCount { get; }

        /// <summary>
        /// Координаты, по которым была вырезана фотография профиля и миниатюра
        /// </summary>
        ICropPhoto CropPhoto { get; }

        /// <summary>
        /// Короткий адрес страницы
        /// </summary>
        /// <remarks>
        /// Если недоступен, то равен 'id + UserId'
        /// </remarks>
        string Domain { get; }

        //TODO: Name case

        /// <summary>
        /// Количество подписчиков пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? FollowersCount { get; }

        /// <summary>
        /// Статус дружбы с пользователем
        /// </summary>
        FriendStatus? FriendStatus { get; }

        /// <summary>
        /// Известен ли номер мобильного телефона, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? HasMobile { get; }

        /// <summary>
        /// Установил ли пользователь фотографию профиля, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? HasPhoto { get; }

        /// <summary>
        /// Название родного города, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string HomeTown { get; }

        /// <summary>
        /// Добавлен ли текущий пользователь в закладки, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? IsFavorite { get; }

        /// <summary>
        /// Скрыт ли пользователь из ленты новостей, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? IsHiddenFromFeed { get; }

        /// <summary>
        /// Время последнего посещения, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        ILastSeen LastSeen { get; }

        /// <summary>
        /// Идентификаторы списков друзей в которые добавлен пользователь, если доступны,
        /// иначе <see langword="null"/>
        /// </summary>
        IEnumerable<string> Lists { get; }

        /// <summary>
        /// Девичья фамилия, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        string MaidenName { get; }

        /// <summary>
        /// Никнейм или отчество пользователя, если доступны,
        /// иначе <see langword="null"/>
        /// </summary>
        string Nickname { get; }

        /// <summary>
        /// Находится ли пользователь сейчас на сайте, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? IsOnline { get; }

        /// <summary>
        /// Короткое имя страницы пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string ScreenName { get; }

        /// <summary>
        /// Пол пользователя, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        Sex? Sex { get; }

        /// <summary>
        /// Сайт пользователя, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        Uri Site { get; }

        /// <summary>
        /// Временная зона пользователя, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        int? TimeZone { get; }

        /// <summary>
        /// Является ли страница верифицированной, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? IsVerified { get; }

        /// <summary>
        /// Включены ли комментарии на стене, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? WallCommentsAvailabale { get; }
    }
}
