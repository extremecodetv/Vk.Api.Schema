
namespace Vk.Api.Schema.Common.Media.Photo
{
    /// <summary>
    /// Структура, представляющая координаты 
    /// прямоугольной области (в процентах)
    /// </summary>
    public struct Rect
    {
        /// <summary>
        /// Смещение левого верхнего угла по координате X (в процентах)
        /// </summary>
        double X { get; set; }

        /// <summary>
        /// Смещение левого верхнего угла по координате Y (в процентах)
        /// </summary>
        double Y { get; set; }

        /// <summary>
        /// Смещение правого нижнего угла по координате X (в процентах)
        /// </summary>
        double X2 { get; set; }

        /// <summary>
        /// Смещение правого нижнего угла по координате Y (в процентах)
        /// </summary>
        double Y2 { get; set; }
    }
}
