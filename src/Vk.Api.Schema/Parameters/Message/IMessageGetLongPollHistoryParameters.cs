using Vk.Api.Schema.Enums.Filters;

namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.getLongPollHistory <para/>
    /// Документация: <see href="https://vk.com/dev/messages.getLongPollHistory"/>
    /// </summary>
    public interface IMessageGetLongPollHistoryParameters
    {
        /// <summary>
        /// Последнее значение параметра ts, полученное от Long Poll сервера
        /// или с помощью метода messages.getLongPollServer 
        /// </summary>
        int? Ts { get; set; }

        /// <summary>
        /// Последнее значение параметра new_pts, полученное от Long Poll сервера
        /// </summary>
        /// <remarks>
        /// Используется для получения действий, которые хранятся всегда
        /// </remarks>
        int? Pts { get; set; }

        /// <summary>
        /// Количество символов, по которому нужно обрезать сообщение
        /// </summary>
        /// <remarks>
        /// Укажите 0, если Вы не хотите обрезать сообщение. По умолчанию сообщения не обрезаются.
        /// </remarks>
        int? PreviewLength { get; set; }

        /// <summary>
        /// Возвращать историю только от тех пользователей, которые сейчас online
        /// </summary>
        bool? UsersAreOnline { get; set; }

        /// <summary>
        /// Список дополнительных полей профилей, которые необходимо вернуть
        /// </summary>
        /// <remarks>
        /// По умолчанию: photo,photo_medium_rec,sex,online,screen_name
        /// </remarks>
        UserField? Fields { get; set; }

        /// <summary>
        /// Лимит по количеству всех событий в истории
        /// </summary>
        /// <remarks>
        /// Параметры events_limit и msgs_limit применяются совместно
        /// Число результатов в ответе ограничивается первым достигнутым лимитом
        /// По умолчанию 1000, минимальное значение 1000
        /// </remarks>
        int? EventsLimit { get; set; }

        /// <summary>
        /// Лимит по количеству событий с сообщениями в истории
        /// </summary>
        /// <remarks>
        /// Параметры events_limit и msgs_limit применяются совместно
        /// Число результатов в ответе ограничивается первым достигнутым лимитом
        /// По умолчанию 200, минимальное значение 200
        /// </remarks>
        int? MsgsLimit { get; set; }

        /// <summary>
        /// Максимальный идентификатор сообщения среди уже имеющихся в локальной копии
        /// </summary>
        /// <remarks>
        /// Необходимо учитывать как сообщения, полученные через методы API 
        /// (например messages.getDialogs, messages.getHistory), 
        /// так и данные, полученные из Long Poll сервера (события с кодом 4)
        /// </remarks>
        int? MaxMsgId { get; set; }

        /// <summary>
        /// Версия Long Pol сервера
        /// </summary>
        int? LpVersion { get; set; }
    }
}
