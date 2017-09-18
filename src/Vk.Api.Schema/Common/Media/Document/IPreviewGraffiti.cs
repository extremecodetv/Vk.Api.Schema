using System;

namespace Vk.Api.Schema.Common.Media.Document
{
    /// <summary>
    /// Интерфейс, представляющий данные о граффити
    /// </summary>
    public interface IPreviewGraffiti
    {
        /// <summary>
        /// Url документа с граффити
        /// </summary>
        Uri Url { get; set; }

        /// <summary>
        /// Ширина (в пикселях)
        /// </summary>
        int Width { get; set; }

        /// <summary>
        /// Высота (в пикселях)
        /// </summary>
        int Height { get; set; }
    }
}
