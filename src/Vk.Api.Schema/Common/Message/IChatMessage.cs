using System.Collections.Generic;

namespace Vk.Api.Schema.Common.Message
{
    /// <summary>
    /// Интерфейс, представляющий дополнительные поля сообщений
    /// из мультидиалогов
    /// </summary>
    public interface IChatMessage
    {
        /// <summary>
        /// Идентификатор беседы, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        int? ChatId { get; }

        /// <summary>
        /// Идентификаторы авторов последних сообщений беседы, если доступно, 
        /// иначе <see langword="null"/> 
        /// </summary>
        IEnumerable<int> ActiveUsers { get; }

        object PushSettings { get; } //TODO: Push
        
        //TODO: other shit
        //fucking retards, fuck this shit

    }
}