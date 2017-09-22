namespace Vk.Api.Schema.Enums.Page
{
    /// <summary>
    /// Указывает кто может что-нибудь сделать с вики-страницей
    /// </summary>
    public enum WhoCanType //TODO: Имя получше? :D
    {
        /// <summary>
        /// Руководители 
        /// </summary>
        CommunityManagers,
        /// <summary>
        /// Участники
        /// </summary>
        CommunityMembers,
        /// <summary>
        /// Все пользователи
        /// </summary>
        AllUsers
    }
}