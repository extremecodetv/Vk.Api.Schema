using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Poll
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для polls.edit <para/>
    /// Документация: <see href="https://vk.com/dev/polls.edit"/>
    /// </summary>
    public interface IPollEditParameters
    {
        /// <summary>
        /// Идентификатор владельца опроса 
        /// </summary>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор редактируемого опроса
        /// </summary>
        int PollId { get; set; }

        /// <summary>
        /// Новый текст редактируемого опроса
        /// </summary>
        string Question { get; set; }

        /// <summary>
        /// Список вариантов ответов на добавление
        /// </summary>
        IEnumerable<string> AddAnswers { get; set; }

        /// <summary>
        /// Содержит коллекцию вариантов ответов, которые необходимо отредактировать;
        /// </summary>
        IEnumerable<IPollEditAnswerVariant> EditAnswers { get; set; }

        /// <summary>
        /// Список идентификаторов ответов, которые необходимо удалить
        /// </summary>
        IEnumerable<int> DeleteAnswers { get; set; }
    }
}
