
namespace Vk.Api.Schema.Common
{
    /// <summary>
    /// Интерфейс для представления информации о городе
    /// </summary>
    public interface ICity
    {
        /// <summary>
        /// Идентификатор города
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Название города
        /// </summary>
        string Title { get; }
    }
}
