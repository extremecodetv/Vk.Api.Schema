﻿namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.addChatUser <para/>
    /// Документация: <see href="https://vk.com/dev/messages.addChatUser"/>
    /// </summary>
    public interface IMessageAddChatUserParameters
    {
        /// <summary>
        /// Идентификатор беседы
        /// </summary>
        /// <remarks>
        /// Положительное число, обязательный параметр, максимальное значение 100'000'000
        /// </remarks>
        int ChatId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, которого необходимо включить в беседу
        /// </summary>
        /// <remarks>
        /// Положительное число, обязательный параметр
        /// </remarks>
        int UserId { get; set; }
    }
}
