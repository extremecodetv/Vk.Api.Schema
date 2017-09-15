using System.ComponentModel;

namespace Vk.Api.Schema.Enums.Filters
{
    /// <summary>
    /// Параметры запроса для получения дополнительных
    /// полей профиля
    /// </summary>
    public enum UserField
    {
        /// <summary>
        /// Идентификатор фото
        /// </summary>
        [Description("photo_id")]
        PhotoId,
        /// <summary>
        /// Верификация страницы
        /// </summary>
        [Description("verified")]
        Verfied,
        /// <summary>
        /// Пол
        /// </summary>
        [Description("sex")]
        Sex,
        /// <summary>
        /// Дата рождения
        /// </summary>
        [Description("bdate")]
        BirthDate,
        /// <summary>
        /// Город
        /// </summary>
        [Description("city")]
        City,
        /// <summary>
        /// Страна
        /// </summary>
        [Description("country")]
        Country,
        /// <summary>
        /// Родной город
        /// </summary>
        [Description("home_town")]
        HomeTown,
        /// <summary>
        /// Имеется ли фото
        /// </summary>
        [Description("has_photo")]
        HasPhoto,
        /// <summary>
        /// Квадратное фото шириной 50px
        /// </summary>
        [Description("photo_50")]
        Photo50,
        /// <summary>
        /// Квадратное фото шириной 100px
        /// </summary>
        [Description("photo_100")]
        Photo100,
        /// <summary>
        /// Квадратное фото шириной 200px
        /// </summary>
        [Description("photo_200")]
        Photo200,
        /// <summary>
        /// Фото шириной 200px
        /// </summary>
        [Description("photo_200_orig")]
        Photo200Original,
        /// <summary>
        /// Фото шириной 400px
        /// </summary>
        [Description("photo_400_orig")]
        Photo400Original,
        /// <summary>
        /// Квадратное фото максимального размера
        /// </summary>
        [Description("photo_max")]
        PhotoMax,
        /// <summary>
        /// Фото максимального размера
        /// </summary>
        [Description("photo_max_orig")]
        PhotoMaxOriginal,
        /// <summary>
        /// Находится ли пользователь на сайте
        /// </summary>
        [Description("online")]
        Online,
        /// <summary>
        /// Короткий адресс страницы
        /// </summary>
        [Description("domain")]
        Domain,
        /// <summary>
        /// Известен ли номер мобильного 
        /// </summary>
        [Description("has_mobile")]
        HasMobile,
        /// <summary>
        /// Контакты
        /// </summary>
        [Description("contacts")]
        Contacts,
        /// <summary>
        /// Сайт
        /// </summary>
        [Description("site")]
        Site,
        /// <summary>
        /// Образование
        /// </summary>
        [Description("education")]
        Education,
        /// <summary>
        /// Список ВУЗов
        /// </summary>
        [Description("universities")]
        Universities,
        /// <summary>
        /// Список школ
        /// </summary>
        [Description("schools")]
        Schools,
        /// <summary>
        /// Статус
        /// </summary>
        [Description("status")]
        Status,
        /// <summary>
        /// Последний вход
        /// </summary>
        [Description("last_seen")]
        LastSeen,
        /// <summary>
        /// Количество подписчиков
        /// </summary>
        [Description("followers_count")]
        FollowersCount,
        /// <summary>
        /// Количество общих друзей
        /// </summary>
        [Description("common_count")]
        CommonCount,
        /// <summary>
        /// Текущий род деятельности
        /// </summary>
        [Description("occupation")]
        Occupation,
        /// <summary>
        /// Никнейм или отчество
        /// </summary>
        [Description("nickname")]
        Nickname,
        /// <summary>
        /// Родственники
        /// </summary>
        [Description("relatives")]
        Relatives,
        /// <summary>
        /// Семейное положение
        /// </summary>
        [Description("relation")]
        Relation,
        /// <summary>
        /// Жизненная позиция
        /// </summary>
        [Description("personal")]
        Personal,
        /// <summary>
        /// Внешние сервисы
        /// </summary>
        [Description("connections")]
        Connections,
        /// <summary>
        /// Связанные внешние сервисы
        /// </summary>
        [Description("exports")]
        Exports,
        /// <summary>
        /// Доступно ли комментирование стены
        /// </summary>
        [Description("wall_comments")]
        WallComments,
        /// <summary>
        /// Деятельность
        /// </summary>
        [Description("activities")]
        Activites,
        /// <summary>
        /// Интересы
        /// </summary>
        [Description("interests")]
        Interests,
        /// <summary>
        /// Музыка
        /// </summary>
        [Description("music")]
        Music,
        /// <summary>
        /// Фильмы
        /// </summary>
        [Description("movies")]
        Movies,
        /// <summary>
        /// Телешоу
        /// </summary>
        [Description("tv")]
        Tv,
        /// <summary>
        /// Книги
        /// </summary>
        [Description("books")]
        Books,
        /// <summary>
        /// Игры
        /// </summary>
        [Description("games")]
        Games,
        /// <summary>
        /// О себе
        /// </summary>
        [Description("about")]
        About,
        /// <summary>
        /// Цитаты
        /// </summary>
        [Description("quotes")]
        Quotes,
        /// <summary>
        /// Можно ли оставлять записи на стене
        /// </summary>
        [Description("can_post")]
        CanPost,
        /// <summary>
        /// Можно ли видеть чужие записи на стене
        /// </summary>
        [Description("can_see_all_posts")]
        CanSeeAllPosts,
        /// <summary>
        /// Можно ли видеть аудиозаписи
        /// </summary>
        [Description("can_see_audio")]
        CanSeeAudio,
        /// <summary>
        /// Можно ли написать личное сообщение
        /// </summary>
        [Description("can_write_private_message")]
        CanWritePrivateMessage,
        /// <summary>
        /// Можно ли сделать запрос на дружбу
        /// </summary>
        [Description("can_send_friend_request")]
        CanSendFriendRequest,
        /// <summary>
        /// Находится ли пользователь в закладках
        /// </summary>
        [Description("is_favorite")]
        IsFavorite,
        /// <summary>
        /// Скрыт ли пользователь из ленты новостей
        /// </summary>
        [Description("is_hidden_from_feed")]
        IsHiddenFromFeed,
        /// <summary>
        /// Временая зона пользователя
        /// </summary>
        [Description("timezone")]
        Timezone,
        /// <summary>
        /// Короткое имя страницы пользователя
        /// </summary>
        [Description("screen_name")]
        ScreenName,
        /// <summary>
        /// Девичья фамилия
        /// </summary>
        [Description("maiden_name")]
        MaidenName,
        /// <summary>
        /// Обрезанное фото профиля
        /// </summary>
        [Description("crop_photo")]
        CropPhoto,
        /// <summary>
        /// Является ли пользователь другом
        /// </summary>
        [Description("is_friend")]
        IsFriend,
        /// <summary>
        /// Стаутс дружбы с пользователем
        /// </summary>
        [Description("friend_status")]
        FriendStatus,
        /// <summary>
        /// Карьера
        /// </summary>
        [Description("career")]
        Career,
        /// <summary>
        /// Военная служба
        /// </summary>
        [Description("military")]
        Military,
        /// <summary>
        /// Находится ли пользователь в черном списке
        /// </summary>
        [Description("blacklisted")]
        Blacklisted,
        /// <summary>
        /// Находится ли пользователь в черном списке у текущего пользователя
        /// </summary>
        [Description("blacklisted_by_me")]
        BlacklistedByMe
    }
}
