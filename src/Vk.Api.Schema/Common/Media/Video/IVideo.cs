using System;

namespace Vk.Api.Schema.Common.Media.Video
{
    /// <summary>
    /// Интерфейс, представляющий информацию о видеозаписи <para/>
    /// Документация: <see href="https://vk.com/dev/objects/video"/>
    /// </summary>
    public interface IVideo : IVideoPreview
    {
        /// <summary>
        /// Идентификатор видеозаписи
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Идентификатор владельца видеозаписи
        /// </summary>
        int OwnerId { get; }

        /// <summary>
        /// Название видеозаписи
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Описание видеозаписи
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Длительность видеозаписи
        /// </summary>
        TimeSpan Duration { get; }

        /// <summary>
        /// Дата создания видеозаписи
        /// </summary>
        DateTime Date { get; }

        /// <summary>
        /// Дата добавления видеозаписи
        /// </summary>
        DateTime AddingDate { get; }

        /// <summary>
        /// Количество просмотров
        /// </summary>
        int Views { get; }

        /// <summary>
        /// Количество комментариев
        /// </summary>
        int Comments { get; }

        /// <summary>
        /// Url страницы с плеером
        /// </summary>
        Uri PlayerUrl { get; }

        /// <summary>
        /// Название платформы (для видеозаписей, добавленных с внешних сайтов)
        /// </summary>
        string Platform { get; }

        /// <summary>
        /// <see langword="true"/>, если пользователь может редактировать видеозапись, иначе <see langword="null"/>
        /// </summary>
        bool? CanEdit { get; }

        /// <summary>
        /// <see langword="true"/>, если пользователь может добавить видеозапись себе
        /// </summary>
        bool CanAdd { get; }

        /// <summary>
        /// Ключ доступа к видеозаписи
        /// </summary>
        string AccessKey { get; } 

        /// <summary>
        /// <see langword="true"/>, если видеоролик обрабатывается, иначе <see langword="null"/>
        /// </summary>
        bool? IsProcessing { get; }

        /// <summary>
        /// <see langword="true"/>, если прямая трансляция
        /// </summary>
        /// <remarks>
        /// Длительность <see cref="IVideo.Duration"/> в этом случае равна 0
        /// </remarks>
        bool IsLive { get; }

        /// <summary>
        /// <see langword="true"/>, если трансляция скоро начнется
        /// </summary>
        bool? IsUpcoming { get; }
    }
}
