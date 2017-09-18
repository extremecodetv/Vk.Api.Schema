using System;
using Vk.Api.Schema.Enums;

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
        int Id { get; set; }

        /// <summary>
        /// Идентификатор владельца аудиозаписи
        /// </summary>
        int OwnerId { get; set; }

        /// <summary>
        /// Исполнитель
        /// </summary>
        string Artist { get; set; }

        /// <summary>
        /// Название композиции
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Длительность композиции
        /// </summary>
        TimeSpan Duration { get; set; }

        /// <summary>
        /// Ссылка на MP3
        /// </summary>
        Uri Url { get; set; }

        /// <summary>
        /// Идентификатор текста аудиозаписи, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? LyricsId { get; set; }

        /// <summary>
        /// Идентификатор альбома, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? AlbumId { get; set; }

        /// <summary>
        /// Идентификатор жанра
        /// </summary>
        AudioGenreType GenreId { get; set; }

        /// <summary>
        /// Дата добавления, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? Date { get; set; }

        /// <summary>
        /// <see langword="true"/>, если включена опция "Не выводить при поиске"
        /// </summary>
        bool NoSearch { get; set; }

        /// <summary>
        /// <see langword="true"/>, если аудио в высоком качестве
        /// </summary>
        bool IsHighQuality { get; set; }
    }
}
