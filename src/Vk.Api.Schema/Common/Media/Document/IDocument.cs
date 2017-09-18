using System;

using Vk.Api.Schema.Enums;

namespace Vk.Api.Schema.Common.Media.Document
{
    /// <summary>
    /// Интерфейс, представляющий информацию о документе <para/>
    /// Документация: <see href="https://vk.com/dev/objects/doc"/>
    /// </summary>
    public interface IDocument
    {
        /// <summary>
        /// Идентификатор документа
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        int OwnerId { get; set; }

        /// <summary>
        /// Название документа
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Размер документа в байтах
        /// </summary>
        int Size { get; set; }

        /// <summary>
        /// Расширение документа
        /// </summary>
        string Extension { get; set; }

        /// <summary>
        /// Url документа
        /// </summary>
        Uri Url { get; set; }

        /// <summary>
        /// Дата добавления документа
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Тип документа
        /// </summary>
        DocumentType Type { get; set; }

        /// <summary>
        /// Предварительный просмотр документа
        /// </summary>
        IPreview Preview { get; set; }
    }
}
