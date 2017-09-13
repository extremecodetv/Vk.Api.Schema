
namespace Vk.Api.Schema.Enums.User
{
    /// <summary>
    /// Семейное положение
    /// </summary>
    public enum RelationshipStatus
    {
        /// <summary>
        /// Не указано
        /// </summary>
        Unknown,
        /// <summary>
        /// Не женат/замужем
        /// </summary>
        Single,
        /// <summary>
        /// Есть друг/подруга
        /// </summary>
        Relationship,
        /// <summary>
        /// Помолвлен/помолвлена
        /// </summary>
        Engaged,
        /// <summary>
        /// Женат/замужем
        /// </summary>
        Married,
        /// <summary>
        /// Все сложно
        /// </summary>
        Complicated,
        /// <summary>
        /// В активном поиске
        /// </summary>
        Searching,
        /// <summary>
        /// Влюблен/влюблена
        /// </summary>
        Love,
        /// <summary>
        /// В гражданском браке
        /// </summary>
        CivilUnion
    }
}
