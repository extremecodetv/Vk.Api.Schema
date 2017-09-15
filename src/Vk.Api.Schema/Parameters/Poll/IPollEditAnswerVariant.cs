namespace Vk.Api.Schema.Parameters.Poll
{
    /// <summary>
    /// Интерфейс для представления объекта, содержащего варианты ответов,
    /// которые необходимо отредактировать
    /// </summary>
    public interface IPollEditAnswerVariant
    {
        /// <summary>
        /// Идентификатор ответа
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Новый текст ответа 
        /// </summary>
        string Text { get; set; }
    }
}
