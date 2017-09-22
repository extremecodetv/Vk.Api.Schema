
namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// Интерфейс, представляющий контактную информацию из блока "Контакты" сообщества
    /// </summary>
    public interface IContact
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        int UserId { get; }

        /// <summary>
        /// Должность, если доступно,
        /// иначе <see langword="null"/> или <see cref="string.Empty"/>
        /// </summary>
        string Position { get; }

        /// <summary>
        /// Номер телефона, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Phone { get; }

        /// <summary>
        /// E-Mail адрес, если доступно,
        /// иначе <see langword="null"/>
        /// </summary>
        string Email { get; }
    }
}
