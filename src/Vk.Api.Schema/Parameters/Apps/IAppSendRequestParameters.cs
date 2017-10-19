using Vk.Api.Schema.Enums.App;

namespace Vk.Api.Schema.Parameters.Apps
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для apps.getScore <para/>
    /// Документация: <see href="https://vk.com/dev/apps.getScore"/>
    /// </summary>
    interface IAppSendRequestParameters
    {
        /// <summary>
        /// Идентификатор пользователя, которому следует отправить запрос
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int UserId{ get; set; }

        /// <summary>
        /// Текст запроса
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Тип запроса. invite – если запрос отправляется пользователю, не установившему приложение;
        /// request – если пользователь уже установил приложение
        /// </summary>
        /// <remarks>
        /// Для запросов с Type = invite действует ограничение — одному и тому же пользователю 
        /// нельзя отправить запрос чаще одного раза в неделю.
        /// По умолчанию request
        /// </remarks>
        AppInvite? Type { get; set; } // TODO: Смысл значений перечисления отличается от значений этого параметра, может стоит отдельное перечисление сделать?

        /// <summary>
        /// Уникальное в рамках приложения имя для каждого вида отправляемого запроса
        /// </summary>
        /// <remarks>
        /// Максимальная длина 128
        /// </remarks>
        string Name { get; set; }

        /// <summary>
        /// Строка, которая будет возвращена назад при переходе пользователя по запросу в приложение. 
        /// Может использоваться для подсчета конверсии.
        /// </summary>
        string Key { get; set; }

        /// <summary>
        /// Запрет на группировку запроса с другими, имеющими тот же Name
        /// </summary>
        /// <remarks>
        /// По умолчанию: 0
        /// </remarks>
        bool? IsSeparate { get; set; }
    }
}
