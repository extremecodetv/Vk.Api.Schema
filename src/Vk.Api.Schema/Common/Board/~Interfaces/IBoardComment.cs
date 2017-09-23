using System;
using System.Collections.Generic;
using Vk.Api.Schema.Common.Media;
using Vk.Api.Schema.Common.Wall;

namespace Vk.Api.Schema.Common.Board
{
    /// <summary>
    /// Интерфейс для представления информации о комментарии в обсужении "ВКонтакте"<para/>
    /// Документация: <see href="https://vk.com/dev/objects/comment_board">objects.comments_board</see>
    /// </summary>
    public interface IBoardComment
    {
        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        int Id { get; }
        
        /// <summary>
        /// Идентификатор автора комментария
        /// </summary>
        int FromId { get; }

        /// <summary>
        /// Дата создания комментария
        /// </summary>
        DateTime Date { get; }

        /// <summary>
        /// Текст комментария
        /// </summary>
        string Text { get; }

        /// <summary>
        /// Коллекция вложений
        /// </summary>
        IEnumerable<IAttachment> Attachments { get; }

        /// <summary>
        /// Информация об отметках "Мне нравится"
        /// </summary>
        ILikes Likes { get; }
    }
}