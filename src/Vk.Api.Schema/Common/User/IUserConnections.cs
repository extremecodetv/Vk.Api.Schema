
namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления информации о контактах 
    /// внешних сервисов, указанных в профиле пользователя
    /// </summary>
    public interface IUserConnections
    {

        string Skype { get; }

        string Instagram { get; }


    }
}
