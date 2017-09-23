
namespace Vk.Api.Schema.Common
{
    /// <summary>
    /// Интерфейс, представляющий базовый ответ от API "ВКонтакте"
    /// </summary>
    /// <typeparam name="T">Объект API "ВКонтакте"</typeparam>
    public interface IResponse<out T>
    {
        /// <summary>
        /// Ошибка
        /// </summary>
        object Error { get; }

        /// <summary>
        /// Объект возвращенный API
        /// </summary>
        T Response { get; }
    }
}
