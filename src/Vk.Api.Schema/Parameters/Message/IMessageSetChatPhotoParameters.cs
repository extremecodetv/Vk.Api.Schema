namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.setChatPhoto <para/>
    /// Документация: <see href="https://vk.com/dev/messages.setChatPhoto"/>
    /// </summary>
    public interface IMessageSetChatPhotoParameters
    {
        /// <summary>
        /// Содержимое поля response из ответа специального upload сервера, 
        /// полученного в результате загрузки изображения на адрес, 
        /// полученный методом photos.getChatUploadServer
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        string File { get; set; }
    }
}
