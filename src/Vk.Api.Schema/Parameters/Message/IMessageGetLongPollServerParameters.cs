namespace Vk.Api.Schema.Parameters.Message
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для messages.getLongPollServer <para/>
    /// Документация: <see href="https://vk.com/dev/messages.getLongPollServer"/>
    /// </summary>
    public interface IMessageGetLongPollServerParameters
    {
        /// <summary>
        /// Возвращать поле pts, необходимое для работы метода messages.getLongPollHistory 
        /// </summary>
        bool? NeedPts { get; set; }

        /// <summary>
        /// Версия для подключения к Long Poll серверу <para/>
        /// Информация об изменениях в версиях Long Poll: <see href="https://vk.com/dev/using_longpoll"/>
        /// </summary>
        /// <remarks>
        /// По умолчанию 0, доступен начиная с версии 5.65
        /// </remarks>
        int? LpVersion { get; set; }
    }
}
