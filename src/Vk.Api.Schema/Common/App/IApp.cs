using Vk.Api.Schema.Enums.App;

namespace Vk.Api.Schema.Common.App
{
    /// <summary>
    /// Интерфейс для представления информации о приложении ВКонтакте<para/>
    /// Документация: <see href="https://vk.com/dev/objects/app">objects.app</see>
    /// </summary>
    public interface IApp : IAppCreatorData, IAppMedia,
        IAppMinimal, ICategorize
    {
        /// <summary>
        /// Количество участников приложения
        /// </summary>
        int MembersCount { get; set; }

        /// <summary>
        /// Описание приложения (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Тип турнирной таблицы
        /// </summary>
        AppLeaderBoardType LeaderBoardType { get; set; }

        /// <summary>
        /// Короткий адрес приложения
        /// </summary>
        /// <remarks>
        /// Если недоступен, то равен idxxxxxxxx
        /// </remarks>
        string ScreenName { get; set; }

        /// <summary>
        /// Определяет, содержит ли информация о приложении опциональные поля (если доступно),
        /// иначе <see langword="null"/>
        /// </summary>
        bool? Extended { get; set; }
    }
}
