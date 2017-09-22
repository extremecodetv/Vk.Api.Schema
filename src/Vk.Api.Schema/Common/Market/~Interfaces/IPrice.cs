namespace Vk.Api.Schema.Common.Market
{
    /// <summary>
    /// Интерфейс, представляющий информацию о цене товара
    /// </summary>
    public interface IPrice
    {
        /// <summary>
        /// Цена товара в сотых долях единицы валюты
        /// </summary>
        int Amount { get; }

        /// <summary>
        /// Валюта
        /// </summary>
        ICurrency Currency { get; }

        /// <summary>
        /// Строковое представление цены
        /// </summary>
        string Text { get; }
    }
}