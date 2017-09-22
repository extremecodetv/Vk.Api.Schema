using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации о родственнике
    /// </summary>
    public interface IRelative
    {
        /// <summary>
        /// Идентификатор пользователя, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? Id { get; }

        /// <summary>
        /// Имя родственника
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Тип родственной связи
        /// </summary>
        RelationshipType? Type { get; }
    }
}
