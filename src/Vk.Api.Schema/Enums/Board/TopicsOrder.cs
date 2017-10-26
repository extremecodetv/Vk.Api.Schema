namespace Vk.Api.Schema.Enums.Board
{
    /// <summary>
    /// Порядок, в котором необходимо вернуть список тем
    /// </summary>
    public enum TopicsOrder
    {
        /// <summary>
        /// По убыванию даты обновления
        /// </summary>
        DescendingUpdateDate = 1,

        /// <summary>
        /// По убыванию даты создания
        /// </summary>
        DescendingCreationDate = 2,

        /// <summary>
        /// По возрастанию даты обновления
        /// </summary>
        AscendingUpdateDate = -1,

        /// <summary>
        /// По возрастанию даты создания
        /// </summary>
        AscendingCreationDate = -2
    }
}