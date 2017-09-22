using System;
using System.Collections.Generic;

namespace Vk.Api.Schema.Common.Media.Document
{
    /// <summary>
    /// Интерфейс, представляющий данные об аудиосообщении
    /// </summary>
    public interface IPreviewAudioMessage
    {
        /// <summary>
        /// Длительность аудиосообщения
        /// </summary>
        TimeSpan Duration { get; }

        /// <summary>
        /// Коллекция целых чисел для визуального отображения звука
        /// </summary>
        IEnumerable<int> WaveForm { get; }

        /// <summary>
        /// Ссылка на аудиосообщение в Ogg формате 
        /// </summary>
        Uri Ogg { get; }

        /// <summary>
        /// Ссылка на аудиосообщение в Mp3 формате
        /// </summary>
        Uri Mp3 { get; }
    }
}
