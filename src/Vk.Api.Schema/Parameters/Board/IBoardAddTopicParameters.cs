using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Board
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для board.addTopic <para/>
    /// Документация: <see href="https://vk.com/dev/board.addTopic"/>
    /// </summary>
    public interface IBoardAddTopicParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Название обсуждения
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        string Title { get; set; }

        /// <summary>
        /// Текст первого сообщения в обсуждении
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// 1 - тема будет создана от имени группы, 
        /// 0 — тема будет создана от имени пользователя (по умолчанию)
        /// </summary>
        bool? IsCreatedFromGroup { get; set; }

        /// <summary>
        /// Список объектов, приложенных к записи
        /// </summary>
        /// <remarks>
        /// При попытке приложить больше одной ссылки будет возвращена ошибка 
        /// </remarks>
        IEnumerable<string> Attachments { get; set; } // TODO: Возможно стоит сделать отдельный тип
    }
}
