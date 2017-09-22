namespace Vk.Api.Schema.Enums.Group
{
    /// <summary>
    /// Статус участника пользователя в сообществе
    /// </summary>
    public enum MemberStatus
    {
        /// <summary>
        /// Не является участником
        /// </summary>
        NotAMember,
        /// <summary>
        /// Является участником
        /// </summary>
        Member,
        /// <summary>
        /// Не уверен, что посетит мероприятие
        /// </summary>
        NotSure,
        /// <summary>
        /// Отклонил приглашение
        /// </summary>
        DeclinedAnInvitation,
        /// <summary>
        /// Подал заявку на вступление
        /// </summary>
        SentRequest,
        /// <summary>
        /// Приглашен
        /// </summary>
        Invited
    }
}