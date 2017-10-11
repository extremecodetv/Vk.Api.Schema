namespace Vk.Api.Schema.Parameters.Note
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для notes.getComments <para/>
    /// Документация: <see href="https://vk.com/dev/notes.getComments"/>
    /// </summary>
    public interface INoteGetCommentsParameters
    {
        /// <summary>
        /// Идентификатор заметки
        /// </summary>
        /// <remarks>
        /// Положительное число, обязательный параметр
        /// </remarks>
        int NoteId { get; set; }

        /// <summary>
        /// Идентификатор владельца заметки
        /// </summary>
        /// <remarks>
        /// положительное число, по умолчанию идентификатор текущего пользователя
        /// </remarks>
        int? OwnerId { get; set; }

        /// <summary>
        /// Сортировка списка комментариев к заметке по дате добавления в порядке убывания
        /// </summary>
        /// <remarks>
        /// В порядке убывания 1, в порядке возрастания 0,
        /// по умолчанию 0
        /// </remarks>
        bool? IsDescendingSort { get; set; }

        /// <summary>
        /// Cмещение, необходимое для выборки определенного подмножества комментариев
        /// </summary>
        /// <remarks>
        /// Положительное число, по умолчанию 0
        /// </remarks>
        int? Offset { get; set; }

        /// <summary>
        /// Количество комментариев, которое необходимо получить
        /// </summary>
        /// <remarks>
        /// Положительное число, по умолчанию 20, максимальное значение 100
        /// </remarks>
        int? Count { get; set; }
    }
}
