using System;

namespace Vk.Api.Schema.Common.Media.Photo
{
    /// <summary>
    /// Интерфейс, содержащий <see cref="Uri"/> на копии <see cref="IPhoto"/> в различных пропорциях
    /// </summary>
    public interface IPhotoUrl
    {
        /// <summary>
        /// URL копии фотографии с максимальным размером 75x75px, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        Uri Photo75 { get; set; }

        /// <summary>
        /// URL копии фотографии с максимальным размером 130x130px, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        Uri Photo130 { get; set; }

        /// <summary>
        /// URL копии фотографии с максимальным размером 604x604px, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        Uri Photo604 { get; set; }

        /// <summary>
        /// URL копии фотографии с максимальным размером 807x807px, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        Uri Photo807 { get; set; }

        /// <summary>
        /// URL копии фотографии с максимальным размером 1280x1024px, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        Uri Photo1280 { get; set; }

        /// <summary>
        /// URL копии фотографии с максимальным размером 2560x2048px, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        Uri Photo2560 { get; set; }
    }
}
