using System;
using System.Collections.Generic;

namespace Vk.Api.Schema.Common.Poll
{
    /// <summary>
    /// Интерфейс для представления общей информации об опросе "ВКонтакте" <para/>
    /// Документация: <see href="https://vk.com/dev/objects/poll">objects.poll</see>
    /// </summary>
    public interface IPollCommon
    {
        /// <summary>
        /// Идентификатор опроса
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Идентификатор владельца опроса
        /// </summary>
        int OwnerId { get; }

        /// <summary>
        /// Дата создания опроса
        /// </summary>
        DateTime CreateDate { get; }

        /// <summary>
        /// Текст вопроса
        /// </summary>
        string Question { get; }

        /// <summary>
        /// Количество голосов
        /// </summary>
        int Votes { get; }

        /// <summary>
        /// Коллекция объектов, которые содержат информацию о вариантах ответа
        /// </summary>
        IEnumerable<IAnswerVariant> AnswerVariants { get; }

        /// <summary>
        /// Является ли вопрос анонимным
        /// </summary>
        bool IsAnonymous { get; }
    }
}
