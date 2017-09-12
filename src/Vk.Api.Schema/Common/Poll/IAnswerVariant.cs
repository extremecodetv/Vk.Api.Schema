namespace Vk.Api.Schema.Common.Poll
{
    /// <summary>
    /// Интерфейс для представления информации об ответах в опросе ВКонтакте
    /// </summary>
    interface IAnswerVariant
    {
        /// <summary>
        /// Идентификатор ответа
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Текст ответа
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Число проголосовавших за этот ответ
        /// </summary>
        int Votes { get; set; }

        /// <summary>
        /// Рейтинг ответа
        /// </summary>
        double Rate { get; set; }
    }
}
