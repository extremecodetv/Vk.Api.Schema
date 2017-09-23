using System.ComponentModel;

namespace Vk.Api.Schema.Enums.Filters
{
    /// <summary>
    /// Тип документа для запроса getMessagesUploadServer
    /// </summary>
    public enum DocumentUploadServerFilter
    {
        /// <summary>
        /// Обычный документ
        /// </summary>
        [Description("doc")]
        Document,
        /// <summary>
        /// Голосовое сообщение
        /// </summary>
        [Description("audio_message")]
        AudioMessage
    }
}