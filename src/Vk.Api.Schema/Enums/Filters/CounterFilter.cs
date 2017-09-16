using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Vk.Api.Schema.Enums.Filters
{
    /// <summary>
    /// Список счетчиков
    /// </summary>
    public enum CounterFilter
    {
        /// <summary>
        /// Новые заявки в друзья
        /// </summary>
        [Description("friends")]
        Friends,
        /// <summary>
        /// Предлагаемые друзья
        /// </summary>
        [Description("friends_suggestions")]
        FriendsSuggestions,
        /// <summary>
        /// Новые сообщения
        /// </summary>
        [Description("messages")]
        Messages,
        /// <summary>
        /// Новые отметки на фотографиях
        /// </summary>
        [Description("photos")]
        Photos,
        /// <summary>
        /// Новые отметки на видеозаписях
        /// </summary>
        [Description("videos")]
        Videos,
        /// <summary>
        /// Подарки
        /// </summary>
        [Description("gifts")]
        Gifts,
        /// <summary>
        /// События
        /// </summary>
        [Description("events")]
        Events,
        /// <summary>
        /// Сообщества
        /// </summary>
        [Description("groups")]
        Groups,
        /// <summary>
        /// Ответы
        /// </summary>
        [Description("notifications")]
        Notifications,
        /// <summary>
        /// Запросы в мобильных играх
        /// </summary>
        [Description("sdk")]
        Sdk,
        /// <summary>
        /// Уведомления от приложений
        /// </summary>
        [Description("app_requests")]
        AppRequests
    }
}
