namespace Vk.Api.Schema.Common.Poll
{
    /// <summary>
    /// Интерфейс для представления информации об ответах в опросе "ВКонтакте"
    /// </summary>
    public interface IAnswerVariant
    {
        /// <summary>
        /// Идентификатор ответа
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Текст ответа
        /// </summary>
        string Text { get; }

        /// <summary>
        /// Число проголосовавших за этот ответ
        /// </summary>
        int Votes { get; }

        /// <summary>
        /// Рейтинг ответа
        /// </summary>
        double Rate { get; }
    }
}
