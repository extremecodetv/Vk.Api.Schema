using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации о текущем роде деятельности
    /// </summary>
    public interface IOccupation
    {
        /// <summary>
        /// Тип деятельности, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        OccupationType? Type { get; }

        /// <summary>
        /// Идентификатор учереждения в котором состоит пользователь, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? Id { get; }

        /// <summary>
        /// Название учереждения, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Name { get; }
    }
}
