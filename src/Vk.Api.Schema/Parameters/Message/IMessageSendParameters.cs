using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.send <para/>
    /// Документация: <see href="https://vk.com/dev/messages.send"/>
    /// </summary>
    public interface IMessageSendParameters
    {
        /// <summary>
        /// Идентификатор пользователя, которому отправляется сообщение
        /// </summary>
        int? UserId { get; set; }

        /// <summary>
        /// Уникальный (в привязке к API_ID и ID отправителя) идентификатор, 
        /// предназначенный для предотвращения повторной отправки одинакового сообщения
        /// </summary>
        /// <remarks>
        /// Сохраняется вместе с сообщением и доступен в истории сообщений
        /// Заданный RandomId используется для проверки уникальности в течение одного часа 
        /// Доступен начиная с версии 5.45
        /// </remarks>
        int? RandomId { get; set; }

        /// <summary>
        /// Идентификатор назначения
        /// </summary>
        /// <remarks>
        /// Для пользователя: id пользователя
        /// Для групповой беседы: 2000000000 + id беседы
        /// Для сообщества: -id сообщества
        /// Доступен начиная с версии 5.38
        /// </remarks>
        int? PeerId { get; set; }

        /// <summary>
        /// Короткий адрес пользователя
        /// </summary>
        string Domain { get; set; }

        /// <summary>
        /// Идентификатор беседы, к которой будет относиться сообщение
        /// </summary>
        /// <remarks>
        /// Максимальное значение 100000000
        /// </remarks>
        int? ChatId { get; set; }

        /// <summary>
        /// Идентификаторы получателей сообщения 
        /// (при необходимости отправить сообщение сразу нескольким пользователям)
        /// </summary>
        /// <remarks>
        /// Доступно только для ключа доступа сообщества
        /// Максимальное количество идентификаторов: 100
        /// </remarks>
        IEnumerable<int> UserIds { get; set; }

        /// <summary>
        /// Текст личного сообщения
        /// </summary>
        /// <remarks>
        /// Обязательный параметр, если не задан параметр Attachment
        /// </remarks>
        string Message { get; set; }

        /// <summary>
        /// Географическая широта
        /// </summary>
        /// <remarks>
        /// от -90 до 90
        /// </remarks>
        double? Latitude { get; set; }

        /// <summary>
        /// Географическая долгота
        /// </summary>
        /// <remarks>
        /// от -180 до 180
        /// </remarks>
        double? Longitude { get; set; }

        /// <summary>
        /// Медиавложения к личному сообщению
        /// </summary>
        object Attachment { get; set; } //TODO: Сделать тип

        /// <summary>
        /// Идентификаторы пересылаемых сообщений
        /// </summary>
        /// <remarks>
        /// Перечисленные сообщения отправителя будут отображаться в теле письма у получателя
        /// Не более 200 значений
        /// </remarks>
        string ForwardMessages { get; set; } // TODO: По документации - строка, по логике - коллекция интов (проверить)

        /// <summary>
        /// Идентификатор стикера
        /// </summary>
        int? StickerId { get; set; }
    }
}
