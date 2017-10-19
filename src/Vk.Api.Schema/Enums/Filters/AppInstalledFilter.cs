using System.ComponentModel;

namespace Vk.Api.Schema.Enums.Filters
{
    /// <summary>
    /// Фильтр списка установленных приложений
    /// </summary>
    public enum AppInstalledFilter
    {
        /// <summary>
        /// Возвращает список установленных приложений (только для мобильных приложений)
        /// </summary>
        [Description("installed")]
        Installed,

        /// <summary>
        /// Возвращает список приложений, установленных в "Выбор редакции" 
        /// (только для мобильных приложений)
        /// </summary>
        [Description("featured")]
        Featured
    }
}