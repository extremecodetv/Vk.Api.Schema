using System.ComponentModel;

namespace Vk.Api.Schema.Enums
{
    /// <summary>
    /// Тип радиуса зоны поиска пользователя
    /// </summary>
    public enum RadiusType
    {
        /// <summary>
        /// 300 метров
        /// </summary>
        [Description("1")]
        ThreeHundredMeters = 1,
        /// <summary>
        /// 2400 метров
        /// </summary>
        [Description("2")]
        TwoThousandFourHundredMeters,
        /// <summary>
        /// 18 километров
        /// </summary>
        [Description("3")]
        EightTeenKilometers,
        /// <summary>
        /// 150 километров
        /// </summary>
        [Description("4")]
        OneHundredAndFiftyKilometers
    }
}
