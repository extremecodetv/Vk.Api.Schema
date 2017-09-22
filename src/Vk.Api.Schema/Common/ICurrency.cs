namespace Vk.Api.Schema.Common
{
    /// <summary>
    /// Интерфейс, представляющий информацию о валюте
    /// </summary>
    public interface ICurrency
    {
        /// <summary>
        /// Идентификатор валюты
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Символьное обозначение
        /// </summary>
        string Name { get; }
    }
}