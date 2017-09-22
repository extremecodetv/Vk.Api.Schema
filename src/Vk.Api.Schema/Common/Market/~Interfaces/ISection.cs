namespace Vk.Api.Schema.Common.Market
{
    /// <summary>
    /// Интерфейс, представляющий секцию товара
    /// </summary>
    public interface ISection
    {
        /// <summary>
        /// Идентификатор секции
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Название секции
        /// </summary>
        string Name { get; }
    }
}