
namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации о городе
    /// </summary>
    public interface ICity
    {
        /// <summary>
        /// Идентификатор города
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Название города
        /// </summary>
        string Title { get; set; }
    }
}
