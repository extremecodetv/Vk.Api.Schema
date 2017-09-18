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
        int Id { get; set; }

        /// <summary>
        /// Идентификатор владельца видеозаписи
        /// </summary>
        int OwnerId { get; set; }

        /// <summary>
        /// Название видеозаписи
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Описание видеозаписи
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Длительность видеозаписи
        /// </summary>
        TimeSpan Duration { get; set; }

        /// <summary>
        /// Дата создания видеозаписи
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Дата добавления видеозаписи
        /// </summary>
        DateTime AddingDate { get; set; }

        /// <summary>
        /// Количество просмотров
        /// </summary>
        int Views { get; set; }

        /// <summary>
        /// Количество комментариев
        /// </summary>
        int Comments { get; set; }

        /// <summary>
        /// Url страницы с плеером
        /// </summary>
        Uri PlayerUrl { get; set; }

        /// <summary>
        /// Название платформы (для видеозаписей, добавленных с внешних сайтов)
        /// </summary>
        string Platform { get; set; }

        /// <summary>
        /// <see langword="true"/>, если пользователь может редактировать видеозапись, иначе <see langword="null"/>
        /// </summary>
        bool? CanEdit { get; set; }

        /// <summary>
        /// <see langword="true"/>, если пользователь может добавить видеозапись себе
        /// </summary>
        bool CanAdd { get; set; }

        //string AccessKey { get; set; } //TODO: hz

        /// <summary>
        /// <see langword="true"/>, если видеоролик обрабатывается, иначе <see langword="null"/>
        /// </summary>
        bool? IsProcessing { get; set; }

        /// <summary>
        /// <see langword="true"/>, если прямая трансляция
        /// </summary>
        /// <remarks>
        /// Длительность <see cref="IVideo.Duration"/> в этом случае равна 0
        /// </remarks>
        bool IsLive { get; set; }

        /// <summary>
        /// <see langword="true"/>, если трансляция скоро начнется
        /// </summary>
        bool? IsUpcoming { get; set; }
    }
}
