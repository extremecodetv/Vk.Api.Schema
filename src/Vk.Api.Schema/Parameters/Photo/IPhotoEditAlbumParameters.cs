using System;
using System.Collections.Generic;
using System.Text;

namespace Vk.Api.Schema.Parameters.Photo
{
    public interface IPhotoEditAlbumParameters
    {
        /// <summary>
        /// Идентификатор альбома
        /// </summary>
        /// 
        int AlbumId { get; set; }

        /// <summary>
        /// Идентификатор владельца альбома
        /// </summary>
        int? OwnerId { get; set; }

        /// <summary>
        /// Название альбома
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Описание альбома
        /// </summary>
        string Description { get; set; }

        //TODO: Privacy view

        //TODO: Privacy comment

        /// <summary>
        /// Кто может загружать фотографии в альбом. Если <see langword="true"/>, 
        /// то только администраторы и редакторы сообщества
        /// </summary>
        /// <remarks>
        /// Только для альбомов сообществ
        /// </remarks>
        bool? UploadByAdminsOnly { get; set; }

        /// <summary>
        /// Доступно ли комментирование альбома. Если <see langword="true"/>,
        /// то никто не сможет комментировать
        /// </summary>
        /// <remarks>
        /// Только для альбомов сообществ
        /// </remarks>
        bool? CommentsDisabled { get; set; }
    }
}
