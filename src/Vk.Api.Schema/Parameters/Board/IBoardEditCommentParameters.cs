using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Board
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для board.editComment <para/>
    /// Документация: <see href="https://vk.com/dev/board.editComment"/>
    /// </summary>
    public interface IBoardEditCommentParameters
    {
        /// <summary>
        /// Идентификатор сообщества, в котором размещено обсуждение
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
        /// Идентификатор комментария в обсуждении
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int CommentId { get; set; }

        /// <summary>
        /// Новый текст комментария
        /// </summary>
        /// <remarks>
        /// Является обязательным, если не задан параметр Attachments
        /// </remarks>
        string Message { get; set; }

        /// <summary>
        /// Список объектов, приложенных к комментарию
        /// </summary>
        /// <remarks>
        /// Параметр является обязательным, если не задан параметр Message
        /// </remarks>
        IEnumerable<string> Attachments { get; set; } // TODO: Возможно стоит сделать отдельный тип
    }
}
