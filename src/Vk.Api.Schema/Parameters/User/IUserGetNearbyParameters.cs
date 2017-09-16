using Vk.Api.Schema.Enums;
using Vk.Api.Schema.Enums.Filters;

namespace Vk.Api.Schema.Parameters.User
{
    /// <summary>
    /// Интерфейс, представляющий параметры запроса для users.getNearby <para/>
    /// Документация: <see href="https://vk.com/dev/users.getNearby"/>
    /// </summary>
    public interface IUserGetNearbyParameters
    {
        /// <summary>
        /// Географическая широта точки, в которой в данный момент находится пользователь, заданная в градусах (от -90 до 90). <para/>
        /// Обязательный параметр
        /// </summary>
        double Latitude { get; set; }

        /// <summary>
        /// Географическая долгота точки, в которой в данный момент находится пользователь, заданная в градусах (от -180 до 180). <para/>
        /// Обязательный параметр
        /// </summary>
        double Longitude { get; set; }

        /// <summary>
        /// Точность текущего местоположения пользователя в метрах
        /// </summary>
        int? Accuracy { get; set; }

        /// <summary>
        /// Время в секундах через которое пользователь должен перестать находиться через поиск по местоположению. 
        /// </summary>
        int? Timeout { get; set; }

        /// <summary>
        /// Радиус зоны поиска
        /// </summary>
        RadiusType? Radius { get; set; }

        /// <summary>
        /// Дополнительные поля профиля для получения
        /// </summary>
        UserField Fields { get; set; }

        /// <summary>
        /// Падеж для склонения имени пользователя
        /// </summary>
        NameCaseType? NameCase { get; set; }
    }
}
