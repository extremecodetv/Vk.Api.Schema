using System;

using Vk.Api.Schema.Enums;
using Vk.Api.Schema.Enums.Media;

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
        int Id { get; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        int OwnerId { get; }

        /// <summary>
        /// Название документа
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Размер документа в байтах
        /// </summary>
        int Size { get; }

        /// <summary>
        /// Расширение документа
        /// </summary>
        string Extension { get; }

        /// <summary>
        /// Url документа
        /// </summary>
        Uri Url { get; }

        /// <summary>
        /// Дата добавления документа
        /// </summary>
        DateTime Date { get; }

        /// <summary>
        /// Тип документа
        /// </summary>
        DocumentType Type { get; }

        /// <summary>
        /// Предварительный просмотр документа, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        IPreview Preview { get; }
    }
}
