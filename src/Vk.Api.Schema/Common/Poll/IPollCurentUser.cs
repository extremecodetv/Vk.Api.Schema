namespace Vk.Api.Schema.Common.Poll
{
    /// <summary>
    /// Интерфейс для представления информации об ответах в опросе ВКонтакте для текущего пользователя <para/>
    /// Документация: <see href="https://vk.com/dev/objects/poll">objects.poll</see>
    /// </summary>
    public interface IPollCurentUser
    {
        /// <summary>
        /// Идентификатор ответа (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        int? AnswerId { get; set; }
    }
}
