using System;
using System.Collections.Generic;
using Vk.Api.Schema.Common.Market;
using Vk.Api.Schema.Common.Media.Geo;
using Vk.Api.Schema.Enums;
using Vk.Api.Schema.Enums.Group;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Интерфейс для представления информации о сообществе "ВКонтакте"<para/>
    /// Документация: <see href="https://vk.com/dev/objects/group">objects.group</see>
    /// </summary>
    public interface IGroup  : IGroupPhotos
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Название сообщества
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Короткий адрес сообщества
        /// </summary>
        string ScreenName { get; }

        /// <summary>
        /// Тип сообщества (открытое, закрытое или частное)
        /// </summary>
        GroupClosedType Closed { get; }

        /// <summary>
        /// Статус блокировки сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        BlockStatus? BlockStatus { get; }

        /// <summary>
        /// Является ли текущий пользователь руководителем, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? IsAdmin { get; }

        /// <summary>
        /// Уровень полномочий пользователя в сообществе, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        AdminLevel? Level { get; }

        /// <summary>
        /// Является ли пользователь участником сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? IsMember { get; }

        /// <summary>
        /// Идентификатор пользователя, который отправил приглашение в сообщество, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? InvitedBy { get; }

        /// <summary>
        /// Тип сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        GroupType? Type { get; }

        /// <summary>
        /// Строка состояния публичной страницы, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Activity { get; }

        /// <summary>
        /// Возрастные ограничения, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        AgeLimits? Limits { get; }

        /// <summary>
        /// Информация о блокировке, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        IBanInfo BanInfo { get; }

        /// <summary>
        /// <see langword="true"/>, если пользователь может создать обсуждение в сообществе, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? CanCreateTopic { get; }

        /// <summary>
        /// <see langword="true"/>, если пользователь может отправить сообщение сообществу, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? CanMessage { get; }

        /// <summary>
        /// <see langword="true"/>, если пользователь может оставлять записи на стене сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? CanPost { get; }

        /// <summary>
        /// <see langword="true"/>, если пользователь может видеть чужие записи на стене сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? CanSeeAllPosts { get; }

        /// <summary>
        /// <see langword="true"/>, если пользователь может загружать документы в сообщество, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? CanUploadDocument { get; }

        /// <summary>
        /// <see langword="true"/>, если пользователь может загружать видеозаписи в сообщество, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? CanUploadVideo { get; }

        /// <summary>
        /// Город, указанный в информации сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        ICity City { get; }

        /// <summary>
        /// Контакты сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        IEnumerable<IContact> Contacts { get; }

        /// <summary>
        /// Счетчики сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        ICounters Counters { get; }

        /// <summary>
        /// Информация о стране сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        ICountry Country { get; }

        /// <summary>
        /// Описание сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Description { get; }
        
        /// <summary>
        /// Обложка сообщества
        /// </summary>
        ICover Cover { get; }

        /// <summary>
        /// Идентификатор закрепленной записи, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? FixedPost { get; }

        /// <summary>
        /// <see langword="true"/>, если установлена главная фотография сообщества
        /// </summary>
        bool? HasPhoto { get; }

        /// <summary>
        /// <see langword="true" />, если сообщество находится в закладках у пользователя
        /// </summary>
        bool? IsFavorite { get; }

        /// <summary>
        /// <see langword="true"/>, если сообество скрыто из новостей текущего пользователя
        /// </summary>
        bool? IsHiddenFromFeed { get; }

        /// <summary>
        /// <see langword="true"/>, если заблокированы сообщения от этого сообщества у пользователя
        /// </summary>
        bool? IsMessagesBlocked { get; }

        /// <summary>
        /// Коллекция ссылок из блока ссылок сообщества
        /// </summary>
        IEnumerable<ILink> Links { get; }

        /// <summary>
        /// Идентификатор основного фотоальбома, если доступно,
        /// иначе <see langword="null"/> 
        /// </summary>
        int? MainAlbumId { get; }

        /// <summary>
        /// Информация о главной секции, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        SectionType? MainSection { get; }

        /// <summary>
        /// Информация о магазине, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        IMarketInfo Market { get; }

        /// <summary>
        /// Статус участника текущего пользователя, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        MemberStatus? MemberStatus { get; }

        /// <summary>
        /// Количество участников, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? MembersCount { get; }

        /// <summary>
        /// Место, указанное в информации о сообществе, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        IPlace Place { get; }

        /// <summary>
        /// Текст описания <see cref="StartDate"/>, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string PublicDateLabel { get; }

        /// <summary>
        /// Адрес сайта в описании сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        Uri Url { get; }

        /// <summary>
        /// Дата основания (для пабликов) или дата встречи (для событий), если доступно,
        /// иначе <see langword="null"/> 
        /// </summary>
        DateTime? StartDate { get; }

        /// <summary>
        /// Дата окончания (для событий), если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? FinishDate { get; }

        /// <summary>
        /// Статус сообщества, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Status { get; }

        /// <summary>
        /// <see langword="true"/>, если сообщество верифицированно, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        bool? IsVerified { get; }

        /// <summary>
        /// Название главной вики-страницы, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string WikiPage { get; }
        
    }
}