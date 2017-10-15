namespace Vk.Api.Schema.Common.Media.Geo
{
    /// <summary>
    /// Интерфейс, представляющий информацию о местоположении
    /// </summary>
    public interface IPlace : IPlaceCheckin
    {
        /// <summary>
        /// Идентификатор места
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Название места
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Географическая широта (в градусах)
        /// </summary>
        double Latitude { get; }

        /// <summary>
        /// Географическая долгота (в градусах)
        /// </summary>
        double Longitude { get; }

        /// <summary>
        /// Идентификатор страны
        /// </summary>
        int CountryId { get; }

        /// <summary>
        /// Идентификатор города
        /// </summary>
        int CityId { get; }

        
    }
}