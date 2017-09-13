using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации о текущем роде деятельности
    /// </summary>
    public interface IOccupation
    {
        /// <summary>
        /// Тип деятельности, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        OccupationType? Type { get; set; }

        /// <summary>
        /// Идентификатор учереждения в котором состоит пользователь, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        int? Id { get; set; }

        /// <summary>
        /// Название учереждения, (если доступно)
        /// иначе <see langword="null"/>
        /// </summary>
        string Name { get; set; }
    }
}
