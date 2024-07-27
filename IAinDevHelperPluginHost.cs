/*
   Copyright 2024 Allineed.Ru, Max Damascus

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
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
