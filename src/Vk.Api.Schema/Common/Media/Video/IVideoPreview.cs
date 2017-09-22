using System;

namespace Vk.Api.Schema.Common.Media.Video
{
    /// <summary>
    /// Uri обложек видеозаписи, в различных размерах
    /// </summary>
    public interface IVideoPreview
    {
        /// <summary>
        /// URL изображения-обложки ролика с размером 130x98px
        /// </summary>
        Uri Photo130 { get; }

        /// <summary>
        /// URL изображения-обложки ролика с размером 320x240px
        /// </summary>
        Uri Photo320 { get; }

        /// <summary>
        /// URL изображения-обложки ролика с размером 640x480px, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        Uri Photo640 { get; }

        /// <summary>
        /// URL изображения-обложки ролика с размером 800x450px, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        Uri Photo800 { get; }
    }
}
