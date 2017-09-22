using Vk.Api.Schema.Enums;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления основной информации о пользователе "ВКонтакте"<para/>
    /// Документация: <see href="https://vk.com/dev/objects/user">objects.user</see>
    /// </summary>
    public interface IUserMinimal
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        string FirstName { get; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        string LastName { get; }

        /// <summary>
        /// Статус аккаунта <see cref="AccountStatus"/>
        /// <para />
        /// Возвращает <see langword="null"/>, если странца активна
        /// </summary>
        /// <remarks>
        /// Параметр "deactivated"
        /// </remarks>
        BlockStatus? BlockStatus { get; }

        /// <summary>
        /// Видимость страницы. Возвращает <see langword="true"/>,
        /// если запрос выполнен без access_token и установлена опция 
        /// «Кому в интернете видна моя страница» — «Только пользователям "ВКонтакте"»
        /// <para />
        /// Возвращает <see langword="null"/>, если запрос был выполнен с access_token
        /// </summary>
        //TODO: Docs: cref для access_token
        bool? IsHidden { get; }
    }
}
