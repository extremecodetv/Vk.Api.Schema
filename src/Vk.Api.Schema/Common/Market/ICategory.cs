namespace Vk.Api.Schema.Common.Market
{
    /// <summary>
    /// Интерфейс, представляющий категорию товара
    /// </summary>
    public interface ICategory
    {
        /// <summary>
        /// Категория товара
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Название категории
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Секция 
        /// </summary>
        ISection Section { get; }
    }
}