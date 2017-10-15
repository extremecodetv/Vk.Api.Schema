namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.search <para/>
    /// Документация: <see href="https://vk.com/dev/messages.search"/>
    /// </summary>
    public interface IMessageSearchParameters
    {
        /// <summary>
        /// Подстрока, по которой будет производиться поиск
        /// </summary>
        string Substring { get; set; }

        /// <summary>
        /// фильтр по идентификатору назначения для поиска по отдельному диалогу
        /// </summary>
        /// <remarks>
        /// Для пользователя: id пользователя
        /// Для групповой беседы: 2000000000 + id беседы
        /// Для сообщества: -id сообщества
        /// </remarks>
        int? PeerId { get; set; }

        /// <summary>
        /// Дата в формате DDMMYYYY — если параметр задан, в ответе будут только сообщения, 
        /// отправленные до указанной даты
        /// </summary>
        int? Date { get; set; }

        /// <summary>
        /// Количество символов, по которому нужно обрезать сообщение
        /// </summary>
        /// <remarks>
        /// 0 - не обрезать сообщение, по умолчанию 0
        /// </remarks>
        int? PreviewLength { get; set; }

        /// <summary>
        /// Смещение, необходимое для выборки определенного подмножества сообщений из списка найденных
        /// </summary>
        /// <remarks>
        /// По умолчанию 0
        /// </remarks>
        int? Offset { get; set; }

        /// <summary>
        /// Количество сообщений, которое необходимо получить
        /// </summary>
        /// <remarks>
        /// По умолчанию 20, максимальное значение 100
        /// </remarks>
        int? Count { get; set; }
    }
}
