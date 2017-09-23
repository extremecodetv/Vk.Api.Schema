namespace Vk.Api.Schema.Common.Media.Document
{
    /// <summary>
    /// Интерфейс, представляющий тип документов
    /// </summary>
    public interface IType
    {
        /// <summary>
        /// Идентификатор типа
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Название типа
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Число документов
        /// </summary>
        int Count { get; }
    }
}