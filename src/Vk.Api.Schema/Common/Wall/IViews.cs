namespace Vk.Api.Schema.Common.Wall
{
    /// <summary>
    /// Интерфейс, представляющий информацию о просмотрах записи
    /// </summary>
    public interface IViews
    {
        /// <summary>
        /// Число просмотров записи
        /// </summary>
        int Count { get; }
    }
}