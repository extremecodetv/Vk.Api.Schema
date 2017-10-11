namespace Vk.Api.Schema.Parameters.Note
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для notes.delete <para/>
    /// Документация: <see href="https://vk.com/dev/notes.delete"/>
    /// </summary>
    public interface INoteDeleteParameters
    {
        /// <summary>
        /// Идентификатор заметки
        /// </summary>
        /// <remarks>
        /// Положительное число, обязательный параметр
        /// </remarks>
        int NoteId { get; set; }
    }
}
