namespace Vk.Api.Schema.Common.Market
{
    /// <summary>
    /// Интерфейс, представляющий информацию о магазине
    /// </summary>
    public interface IMarketInfo
    {
        /// <summary>
        /// <see langword="true"/>, если включен блок товаров в сообществе
        /// </summary>
        bool Enabled { get; }

        /// <summary>
        /// Минимальная цена товаров, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? MinimalPrice { get; }

        /// <summary>
        /// Максимальная цена товаров, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? MaximalPrice { get; }

        /// <summary>
        /// Идентификатор главной подборки товаров, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? MainAlbumId { get; }

        /// <summary>
        /// Идентификатор контактного лица, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        int? ContactId { get; }

        /// <summary>
        /// Информация о валюте, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        ICurrency Currency { get; }

        /// <summary>
        /// Строковое обозначение валюты, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string CurrencyText { get; }
    }
}