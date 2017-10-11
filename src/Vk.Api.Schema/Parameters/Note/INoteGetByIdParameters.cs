namespace Vk.Api.Schema.Parameters.Note
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для notes.getById <para/>
    /// Документация: <see href="https://vk.com/dev/notes.getById"/>
    /// </summary>
    public interface INoteGetByIdParameters
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
        /// Определяет, требуется ли в ответе wiki-представление заметки
        /// </summary>
        /// <remarks>
        /// работает, только если запрашиваются заметки текущего пользователя,
        /// по умолчанию 0
        /// </remarks>
        bool? NeedWiki { get; set; }
    }
}
