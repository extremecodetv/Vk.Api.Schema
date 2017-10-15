using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.getHistoryAttachments <para/>
    /// Документация: <see href="https://vk.com/dev/messages.getHistoryAttachments"/>
    /// </summary>
    public interface IMessageGetHistoryAttachmentsParameters
    {
        /// <summary>
        /// Идентификатор назначения
        /// </summary>
        /// <remarks>
        /// Для групповой беседы: 2000000000 + id беседы
        /// Для email: id беседы меньше -2000000000 
        /// Для сообщества: -id сообщества
        /// Обязательный параметр
        /// </remarks>
        int PeerId { get; set; }

        /// <summary>
        /// Тип материалов, который необходимо вернуть
        /// </summary>
        /// <remarks>
        /// Существует ограничение по дате отправки вложений. 
        /// Для получения доступны вложения типов photo,video,audio,doc , 
        /// отправленные не ранее 25.03.2013, 
        /// link — не ранее 20.05.13, market,wall — 01.02.2016 
        /// По умолчанию photo
        /// </remarks>
        string MediaType { get; set; } // TODO: По документации - строка, но есть список доступных значений, может сделать тип перечисление?

        /// <summary>
        /// Смещение, необходимое для выборки определенного подмножества объектов
        /// </summary>
        string StartFrom { get; set; } // TODO: По документации - строка, по логике - число (проверить)

        /// <summary>
        /// Количество объектов, которое необходимо получить
        /// </summary>
        /// <remarks>
        /// Положительное число, максимальное значение 200, по умолчанию 30
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Параметр, указывающий нужно ли возвращать доступные размеры фотографии в специальном формате <para/>
        /// Специальный формат: <see href="https://vk.com/dev/objects/photo_sizes"/>
        /// </summary>
        bool? NeedPhotoSizes { get; set; }

        /// <summary>
        /// Дополнительные поля профилей пользователей и сообществ, которые необходимо вернуть в ответе
        /// </summary>
        IEnumerable<string> Fields { get; set; } // TODO: Есть списки допустимых полей, возможно стоит представить отдельным типом
    }
}
