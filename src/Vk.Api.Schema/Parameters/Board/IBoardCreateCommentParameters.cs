using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Board
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для board.createComment <para/>
    /// Документация: <see href="https://vk.com/dev/board.createComment"/>
    /// </summary>
    public interface IBoardCreateCommentParameters
    {
        /// <summary>
        /// Идентификатор сообщества, в котором размещено обсуждение
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор темы, в которой необходимо оставить комментарий
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int TopicId { get; set; }

        /// <summary>
        /// Текст комментария
        /// </summary>
        /// <remarks>
        /// Обязательный параметр, если не передано значение attachments
        /// </remarks>
        string Message { get; set; }

        /// <summary>
        /// Список объектов, приложенных к комментарию
        /// </summary>
        /// <remarks>
        /// При попытке приложить больше одной ссылки будет возвращена ошибка 
        /// </remarks>
        IEnumerable<string> Attachments { get; set; } // TODO: Возможно стоит сделать отдельный тип

        /// <summary>
        /// 1 - тема будет создана от имени группы, 
        /// 0 — тема будет создана от имени пользователя (по умолчанию)
        /// </summary>
        bool? IsCreatedFromGroup { get; set; }

        /// <summary>
        /// Идентификатор стикера
        /// </summary>
        int? StickerId { get; set; }

        /// <summary>
        /// Уникальный идентификатор, предназначенный для предотвращения 
        /// повторной отправки одинакового комментария
        /// </summary>
        string Guid { get; set; }
    }
}
