
namespace Vk.Api.Schema.Enums.User
{
    /// <summary>
    /// Тип родственной связи
    /// </summary>
    public enum RelationshipType
    {
        /// <summary>
        /// Брат/Сестра
        /// </summary>
        Sibling,
        /// <summary>
        /// Отец/Мать
        /// </summary>
        Parent,
        /// <summary>
        /// Сын/Дочь
        /// </summary>
        Child,
        /// <summary>
        /// Дедушка/Бабушка
        /// </summary>
        Grandparent,
        /// <summary>
        /// Внук/Внучка
        /// </summary>
        Grandchild
    }
}
