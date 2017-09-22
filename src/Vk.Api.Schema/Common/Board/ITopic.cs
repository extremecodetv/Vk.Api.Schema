using System;

namespace Vk.Api.Schema.Common.Board
{
    /// <summary>
    /// Интерфейс для представления информации о обсуждения "ВКонтакте"<para/>
    /// Документация: <see href="https://vk.com/dev/objects/topic">objects.topic</see>
    /// </summary>
    public interface ITopic
    {
        /// <summary>
        /// Идентификатор обсуждения
        /// </summary>
        int Id { get; }
        
        /// <summary>
        /// Название обсуждения
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Дата создания обсуждения
        /// </summary>
        DateTime Date { get; }

        /// <summary>
        /// Идентификатор создателя обсуждения
        /// </summary>
        int CreatedBy { get; }

        /// <summary>
        /// Дата последнего обновления
        /// </summary>
        DateTime UpdateTime { get; }

        /// <summary>
        /// Идентификатор автора последнего комментария
        /// </summary>
        int UpdatedBy { get; }

        /// <summary>
        /// <see langword="true"/>, если обсуждение закрыто
        /// </summary>
        bool IsClosed { get; }

        /// <summary>
        /// <see langword="true"/>, если обсуждение закреплено наверху списка
        /// </summary>
        bool IsFixed { get; }

        /// <summary>
        /// Число комментариев
        /// </summary>
        int CommentsCount { get; }

        /// <summary>
        /// Текст первого комментария, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        string FirstComment { get; }

        /// <summary>
        /// Текст последнего комментария, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        string LastComment { get; }
    }
}