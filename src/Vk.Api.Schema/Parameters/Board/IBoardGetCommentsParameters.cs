using Vk.Api.Schema.Enums.Board;

namespace Vk.Api.Schema.Parameters.Board
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для board.getComments <para/>
    /// Документация: <see href="https://vk.com/dev/board.getComments"/>
    /// </summary>
    public interface IBoardGetCommentsParameters
    {
        /// <summary>
        /// Идентификатор сообщества, информацию об обсуждениях которого нужно получить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор обсуждения
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int TopicId { get; set; }

        /// <summary>
        /// 1 — будет возвращено дополнительное поле likes
        /// </summary>
        /// <remarks>
        /// По умолчанию поле likes не возвращается
        /// </remarks>
        bool? NeedLikes { get; set; }

        /// <summary>
        /// Идентификатор комментария, начиная с которого нужно вернуть список
        /// </summary>
        /// <remarks>
        /// Доступен начиная с версии 5.33
        /// </remarks>
        int? StartCommentId { get; set; }

        /// <summary>
        /// Смещение, необходимое для выборки определенного подмножества сообщений
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество сообщений, которое необходимо получить
        /// </summary>
        /// <remarks>
        /// По умолчанию 20, максимальное значение 100
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Будет возвращена информация о пользователях, являющихся авторами сообщений
        /// </summary>
        bool? IsExtended { get; set; }

        /// <summary>
        /// Порядок сортировки комментариев
        /// </summary>
        SortChronological? Sort { get; set; }
    }
}
