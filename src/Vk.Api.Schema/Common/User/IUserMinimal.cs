using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Common.User
{
    /// <summary>
    /// Интерфейс для представления основной информации о пользователе ВКонтакте<para/>
    /// Документация: <see href="https://vk.com/dev/objects/user">objects.user</see>
    /// </summary>
    public interface IUserMinimal
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Статус аккаунта <see cref="AccountStatus"/>
        /// <para />
        /// Возвращает <see langword="null"/> если странца активна
        /// </summary>
        /// <remarks>
        /// Параметр deactivated
        /// </remarks>
        AccountStatus? AccountStatus { get; set; }

        /// <summary>
        /// Видимость страницы. Возвращает <see langword="true"/>,
        /// если запрос выполнен без access_token и установлена опция 
        /// «Кому в интернете видна моя страница» — «Только пользователям ВКонтакте»
        /// <para />
        /// Возвращает <see langword="null"/> если запрос был выполнен с access_token
        /// </summary>
        //TODO: Docs: cref для access_token
        bool? IsHidden { get; set; }
    }
}
