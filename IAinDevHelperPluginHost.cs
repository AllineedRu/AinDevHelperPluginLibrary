using AinDevHelperPluginLibrary.Language;

namespace AinDevHelperPluginLibrary {
    /// <summary>
    /// [RU] Интерфейс описывает хост (главное приложение AinDevHelper) для плагинов, поддерживаемых AinDevHelper
    /// [EN] The interface describes the host (the main AinDevHelper application) for the plugins supported by AinDevHelper
    /// </summary>
    public interface IAinDevHelperPluginHost {
        /// <summary>
        /// [RU] Метод должен быть вызван на стороне плагина. Регистрирует плагин для процесса AinDevHelper, когда приложение загружается<br/>
        /// [EN] The method must be called on the plugin side. Registers a plugin for the AinDevHelper process when the application is loaded
        /// </summary>
        /// <param name="plugin">[RU] Инициализированный экземпляр плагина для регистрации в AinDevHelper;<br/>[EN] An initialized plugin instance for registering with AinDevHelper</param>
        /// <returns>[RU] true в случае успешной регистрации плагина, иначе false;<br/>[EN] true if the plugin registration was successful, otherwise false</returns>
        bool RegisterPlugin(IAinDevHelperPlugin plugin);

        /// <summary>
        /// [RU] Возвращает рабочий каталог запущенного приложения AinDevHelper<br/>
        /// [EN] Returns the working directory of the running AinDevHelper application
        /// </summary>
        /// <returns>[RU] строка, содержащая полный путь к каталогу с исполняемым файлом AinDevHelper;<br/>[EN] a string containing the full path to the directory containing the AinDevHelper executable file</returns>
        string GetAppStartupPath();

        /// <summary>
        /// [RU] Возвращает код текущего языка, используемого в интерфейсе AinDevHelper<br/>
        /// [EN] Returns the code of the current language used in the AinDevHelper interface
        /// </summary>
        /// <returns>[RU] строка, содержащая код текущего используемого языка;<br/>[EN] a string containing the code for the currently used language</returns>
        string GetCurrentLanguageCode();

        /// <summary>
        /// [RU] Возвращает экземпляр текущего языка, используемого в интерфейсе AinDevHelper<br/>
        /// [EN] Returns an instance of the current language used in the AinDevHelper interface
        /// </summary>
        /// <returns>[RU] экземпляр текущего используемого в программе языка;<br/>[EN] an instance of the current language used in the program</returns>
        AinDevHelperLanguage GetCurrentLanguage();
    }
}
