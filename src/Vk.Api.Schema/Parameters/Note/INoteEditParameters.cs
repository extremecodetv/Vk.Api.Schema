namespace Vk.Api.Schema.Parameters.Note
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для notes.edit <para/>
    /// Документация: <see href="https://vk.com/dev/notes.edit"/>
    /// </summary>
    public interface INoteEditParameters
    {
        /// <summary>
        /// Идентификатор заметки
        /// </summary>
        /// <remarks>
        /// Положительное число, обязательный параметр
        /// </remarks>
        int NoteId { get; set; }

        /// <summary>
        /// Заголовок заметки
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        string Title { get; set; }

        /// <summary>
        /// Текст заметки
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        string Text { get; set; }

        /// <summary>
        /// Настройки приватности просмотра заметки
        /// </summary>
        /// <remarks>
        /// По умолчанию all, доступен начиная с версии 5.30
        /// </remarks>
        object PrivacyView { get; set; } //TODO: Запилить тип для "Формата приватности" https://vk.com/dev/privacy_setting

        /// <summary>
        /// Настройки приватности комментирования заметки
        /// </summary>
        /// <remarks>
        /// По умолчанию all, доступен начиная с версии 5.30
        /// </remarks>
        object PrivacyComment { get; set; } //TODO: Запилить тип для "Формата приватности" https://vk.com/dev/privacy_setting
    }
}
