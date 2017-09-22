using System;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Интерфейс, представляющий информацию о ссылке
    /// </summary>
    public interface ILink
    {
        /// <summary>
        /// Идентификатор ссылки
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Url 
        /// </summary>
        Uri Url { get; }

        /// <summary>
        /// Название ссылки
        /// </summary>
        string Name { get; }

        //TODO: Implement can_edit

        /// <summary>
        /// Описание ссылки
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Url изображения превью шириной 50px
        /// </summary>
        Uri Photo50 { get; }

        /// <summary>
        /// Url изображения превью шириной 100px
        /// </summary>
        Uri Photo100 { get; }
    }
}