using System;

namespace Vk.Api.Schema.Common.Note
{
    /// <summary>
    /// Интерфейс для представления информации о заметке "ВКонтакте"<para/>
    /// Документация: <see href="https://vk.com/dev/objects/note">objects.note</see>
    /// </summary>
    public interface INote
    {
        /// <summary>
        /// Идентификатор заметки
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Идентификатор владельца
        /// </summary>
        int OwnerId { get; }

        /// <summary>
        /// Заголовок
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Текст
        /// </summary>
        string Text { get; }

        /// <summary>
        /// Дата создания
        /// </summary>
        DateTime Date { get; }

        /// <summary>
        /// Количество комментариев
        /// </summary>
        int CommentsCount { get; }

        /// <summary>
        /// Количество прочитанных комментариев, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        int? ReadCommentsCount { get; }

        /// <summary>
        /// Url страницы для отображения заметки
        /// </summary>
        Uri ViewUrl { get; }
    }
}