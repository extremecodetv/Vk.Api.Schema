using System;
using Vk.Api.Schema.Enums;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации о последнем посещении пользователя
    /// </summary>
    public interface ILastSeen
    {
        /// <summary>
        /// Время последнего посещения, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        DateTime? Time { get; }

        /// <summary>
        /// Платформа, с помощью которой был осуществлен последний вход, если доступна,
        /// иначе <see langword="null"/>
        /// </summary>
        Platform? Platform { get; }
    }
}
