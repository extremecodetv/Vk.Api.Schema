using System.Collections.Generic;
using Vk.Api.Schema.Common.Media;

namespace Vk.Api.Schema.Common.Message
{
    /// <summary>
    /// Интерфейс для представления информации о личном сообщении "ВКонтакте"<para/>
    /// Документация: <see href="https://vk.com/dev/objects/message">objects.message</see>
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Идентификатор сообщения
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Идентификатор пользователя, в диалоге с которым находится сообщение
        /// </summary>
        int UserId { get; }

        /// <summary>
        /// Идентификатор автора сообщения
        /// </summary>
        int FromId { get; }

        /// <summary>
        /// <see langword="true"/>, если сообщение прочитано, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        bool? IsReaded { get; }

        /// <summary>
        /// <see langword="true"/>, если сообщение отправлено пользователем, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        bool? IsOut { get; }

        /// <summary>
        /// Заголовок беседы
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Текст сообщения
        /// </summary>
        string Body { get; }

        /// <summary>
        /// Информация о местоположении, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        IGeo Geo { get; }

        /// <summary>
        /// Медиавложения сообщения, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        IEnumerable<IAttachment> Attachments { get; }

        /// <summary>
        /// Коллекция пересланных сообщений, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        IEnumerable<IMessage> ForwardMessages { get; }

        /// <summary>
        /// Содержатся ли в сообщении emoji, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        bool? ContainsEmoji { get; }

        /// <summary>
        /// Является ли сообщение важным, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        bool? IsImportant { get; }

        /// <summary>
        /// Удалено ли сообщение
        /// </summary>
        bool? IsDeleted { get; }

        /// <summary>
        /// Идентификатор для отправки сообщения, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        int? RandomId { get; }
        
    }
}