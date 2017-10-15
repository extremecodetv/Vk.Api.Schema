using System.Collections.Generic;
using Vk.Api.Schema.Enums.Filters;

namespace Vk.Api.Schema.Parameters.Market
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для market.getComments <para/>
    /// Документация: <see href="https://vk.com/dev/market.getComments"/>
    /// </summary>
    public interface IMarketGetCommentsParameters
    {
        /// <summary>
        /// Идентификатор владельца товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор товара
        /// </summary>
        /// <remarks>
        /// обязательный параметр
        /// </remarks>
        int ItemId { get; set; }

        /// <summary>
        /// Нужна ли информация о лайках
        /// </summary>
        bool? NeedLikes { get; set; }

        /// <summary>
        /// Идентификатор комментария, начиная с которого нужно вернуть список 
        /// </summary>
        /// <remarks>
        /// Если был передан параметр start_comment_id, будет найдена позиция комментария в списке (или ближайший к нему более ранний).
        /// Начиная с этой позиции будет возвращено count комментариев. 
        /// Смещение offset в этом случае будет отсчитываться от этой позиции (оно может быть отрицательным)
        /// </remarks>
        int? StartCommentId { get; set; }

        /// <summary>
        /// Сдвиг
        /// </summary>
        /// <remarks>
        /// По умолчанию 0
        /// </remarks>
        int? Offset { get; set; }

        /// <summary>
        /// Порядок сортировки комментариев
        /// </summary>
        /// <remarks>
        /// Строка, по умолчанию <see langword="false"/> = asc(asc — от старых к новым, desc - от новых к старым)
        /// </remarks>
        bool? IsDescending{ get; set; }

        /// <summary>
        /// Будут ли возвращены дополнительные поля
        /// </summary>
        /// <remarks>
        /// Если <see langword="true"/> дополнительно будут возвращены списки объектов profiles, groups
        /// </remarks>
        bool? Extended { get; set; }

        /// <summary>
        /// Список дополнительных полей профилей, которые необходимо вернуть
        /// </summary>
        IEnumerable<UserField> Fields { get; set; }
    }
}
