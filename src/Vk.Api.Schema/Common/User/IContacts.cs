
namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления контактных данных пользователя <see cref="IUser"/>
    /// </summary>
    public interface IContacts
    {
        /// <summary>
        /// Номер мобильного телефона, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        string MobilePhone { get; }

        /// <summary>
        /// Номер домашнего телефона, если доступен,
        /// иначе <see langword="null"/>
        /// </summary>
        string HomePhone { get; }
    }
}
