namespace Vk.Api.Schema.Common.Poll
{
    /// <summary>
    /// Интерфейс для представления информации об ответах в опросе "ВКонтакте" для текущего пользователя <para/>
    /// Документация: <see href="https://vk.com/dev/objects/poll">objects.poll</see>
    /// </summary>
    public interface IPollCurrentUser
    {
        /// <summary>
        /// Идентификатор ответа, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        int? AnswerId { get; }
    }
}
