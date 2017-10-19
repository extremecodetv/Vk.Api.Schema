namespace Vk.Api.Schema.Parameters.Apps
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для apps.getScore <para/>
    /// Документация: <see href="https://vk.com/dev/apps.getScore"/>
    /// </summary>
    public interface IAppGetScoreParameters
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        /// <remarks>
        /// По умолчанию идентификатор текущего пользователя 
        /// Обязательный параметр
        /// </remarks>
        int? UserId { get; set; }
    }
}
