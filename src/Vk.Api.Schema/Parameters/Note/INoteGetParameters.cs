using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Note
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для notes.get <para/>
    /// Документация: <see href="https://vk.com/dev/notes.get"/>
    /// </summary>
    public interface INoteGetParameters
    {
        /// <summary>
        /// Идентификаторы заметок, информацию о которых необходимо получить
        /// </summary>
        IEnumerable<int> NoteIds { get; set; }

        /// <summary>
        /// Идентификатор пользователя, информацию о заметках которого требуется получить
        /// </summary>
        /// <remarks>
        /// Положительное число, по умолчанию идентификатор текущего пользователя
        /// </remarks>
        int? UserId { get; set; }

        /// <summary>
        /// Cмещение, необходимое для выборки определенного подмножества заметок
        /// </summary>
        /// <remarks>
        /// Положительное число, по умолчанию 0
        /// </remarks>
        int? Offset { get; set; }

        /// <summary>
        /// Количество заметок, информацию о которых необходимо получить
        /// </summary>
        /// <remarks>
        /// Положительное число, по умолчанию 20, максимальное значение 100
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Сортировка списка заметок по дате создания в порядке возрастания
        /// </summary>
        /// <remarks>
        /// В порядке возрастания 1, в порядке убывания 0,
        /// по умолчанию 0
        /// </remarks>
        bool? IsAscendingSort { get; set; }
    }
}
