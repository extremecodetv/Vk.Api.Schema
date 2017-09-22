
namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Интерфейс, представляющий счетчики сообщества
    /// </summary>
    public interface ICounters
    {
        /// <summary>
        /// Количество фотографий в сообществе, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? PhotosCount { get; }

        /// <summary>
        /// Количество фотоальбомов в сообществе, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? AlbumsCount { get; }

        /// <summary>
        /// Количество аудиозаписей в сообществе, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? AudiosCount { get; }

        /// <summary>
        /// Количество видеозаписей в сообществе, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? VideosCount { get; }

        /// <summary>
        /// Количество обсуждений в сообществе, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? TopicsCount { get; }

        /// <summary>
        /// Количество документов в сообществе, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? DocsCount { get; }
    }
}
