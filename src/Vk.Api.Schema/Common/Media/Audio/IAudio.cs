using System;
using Vk.Api.Schema.Enums;
using Vk.Api.Schema.Enums.Media;

namespace Vk.Api.Schema.Common.Media.Audio
{
    /// <summary>
    /// Интерфейс, представляющий информацию о аудиозаписи <para/>
    /// Документация: <see href="https://vk.com/dev/objects/audio"/>
    /// </summary>
    public interface IAudio
    {
        /// <summary>
        /// Идентификатор аудиозаписи
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Идентификатор владельца аудиозаписи
        /// </summary>
        int OwnerId { get; }

        /// <summary>
        /// Исполнитель
        /// </summary>
        string Artist { get; }

        /// <summary>
        /// Название композиции
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Длительность композиции
        /// </summary>
        TimeSpan Duration { get; }

        /// <summary>
        /// Ссылка на MP3
        /// </summary>
        Uri Url { get; }

        /// <summary>
        /// Идентификатор текста аудиозаписи, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? LyricsId { get; }

        /// <summary>
        /// Идентификатор альбома, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? AlbumId { get; }

        /// <summary>
        /// Идентификатор жанра
        /// </summary>
        AudioGenreType GenreId { get; }

        /// <summary>
        /// Дата добавления, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? Date { get; }

        /// <summary>
        /// <see langword="true"/>, если включена опция "Не выводить при поиске"
        /// </summary>
        bool NoSearch { get; }

        /// <summary>
        /// <see langword="true"/>, если аудио в высоком качестве
        /// </summary>
        bool IsHighQuality { get; }
    }
}
