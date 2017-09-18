using System.Collections.Generic;
using Vk.Api.Schema.Common.Media.Photo;

namespace Vk.Api.Schema.Common.Media.Document
{
    /// <summary>
    /// Интерфейс, представляющий изображение для предпросмотра документа
    /// </summary>
    public interface IPreviewPhoto
    {
        /// <summary>
        /// Коллекция копий изображений в разных размерах
        /// </summary>
        IEnumerable<IPhotoSize> Sizes { get; set; }
    }
}
