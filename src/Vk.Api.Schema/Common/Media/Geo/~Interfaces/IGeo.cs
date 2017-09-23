using Vk.Api.Schema.Common.Media.Geo;

namespace Vk.Api.Schema.Common
{
    /// <summary>
    /// Интерфейс, представляющий данные о местоположении
    /// </summary>
    public interface IGeo
    {
        /// <summary>
        /// Тип места
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Координаты места
        /// </summary>
        string Coordinates { get; }

        /// <summary>
        /// Описание места, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        IPlace Place { get; }
    }
}