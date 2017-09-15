﻿using Vk.Api.Schema.Enums;

namespace Vk.Api.Schema.Parameters.User
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для users.report <para/>
    /// Документация: <see href="https://vk.com/dev/users.report"/>
    /// </summary>
    public interface IUserReportParameters
    {
        /// <summary>
        /// Идентификатор пользователя<para/>
        /// Обязательный параметр
        /// </summary>
        int UserId { get; set; }

        /// <summary>
        /// Тип жалобы<para/>
        /// Обязательный параметр
        /// </summary>
        ReportType Type { get; set; }

        /// <summary>
        /// Комментарий к жалобе
        /// </summary>
        string Comment { get; set; }
    }
}
