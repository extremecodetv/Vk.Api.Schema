using System;

namespace Vk.Api.Schema.Common.Media.Document
{
    /// <summary>
    /// Интерфейс, представляющий данные о сервере для загрузки документа
    /// </summary>
    public interface IDocumentUpload
    {
        /// <summary>
        /// Сервер для загрузки документа
        /// </summary>
        Uri UploadUrl { get; }
    }
}