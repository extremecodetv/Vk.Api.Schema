using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Poll
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для polls.create <para/>
    /// Документация: <see href="https://vk.com/dev/polls.create"/>
    /// </summary>
    public interface IPollCreateParameters
    {
        /// <summary>
        /// Текст вопроса
        /// </summary>
        string Question { get; set; }

        /// <summary>
        /// Является ли опрос анонимным
        /// </summary>
        bool IsAnonymous { get; set; }

        /// <summary>
        /// Индентификатор автора
        /// </summary>
        /// <remarks>
        /// Если опрос будет добавлен в группу, необходимо передать отрицательный идентификатор группы
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Список вариантов ответов
        /// </summary>
        /// <remarks>
        /// Может быть не менее 1 и не более 10 вариантов ответа
        /// </remarks>
        IEnumerable<string> AddAnswers { get; set; } // TODO: намутить серилизацию
    }
}
