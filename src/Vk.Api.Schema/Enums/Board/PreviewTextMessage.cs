namespace Vk.Api.Schema.Enums.Board
{
    /// <summary>
    /// Набор флагов, определяющий, необходимо ли вернуть вместе с информацией о темах текст первых и последних сообщений в них
    /// </summary>
    public enum PreviewTextMessage
    {
        /// <summary>
        /// Не возвращать текст сообщений
        /// </summary>
        NotReceiveMessage,

        /// <summary>
        /// Вернуть первое сообщение в каждой теме (поле first_comment)
        /// </summary>
        ReturnFirstMessage,

        /// <summary>
        /// Вернуть последнее сообщение в каждой теме (поле last_comment)
        /// </summary>
        ReturnLastMessage
    }
}