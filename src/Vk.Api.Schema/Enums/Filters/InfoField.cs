
namespace Vk.Api.Schema.Enums.Filters
{
    /// <summary>
    /// Список полей для account.getInfo
    /// </summary>
    public enum InfoField
    {
        /// <summary>
        /// Страна
        /// </summary>
        Country,
        /// <summary>
        /// Включено ли безопасное соединение
        /// </summary>
        HttpsRequired,
        /// <summary>
        /// Показываются ли на стене по умолчанию только записи пользователя
        /// </summary>
        OwnPostsDefault,
        /// <summary>
        /// Отключено ли комментирование записей на стене
        /// </summary>
        NoWallReplies,
        /// <summary>
        /// Прошел ли пользователь обучение приложению
        /// </summary>
        Intro,
        /// <summary>
        /// Идентификатор языка пользователя
        /// </summary>
        Language
    }
}
