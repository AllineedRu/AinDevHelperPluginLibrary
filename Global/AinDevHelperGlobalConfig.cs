/*
Copyright 2024 Allineed.Ru, Max Damascus

Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
and associated documentation files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, 
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System.IO;
using System.Collections.Generic;
using static AinDevHelperPluginLibrary.Language.AinDevHelperLanguageCodeConstants;

namespace AinDevHelperPluginLibrary.Global {
    /// <summary>
    /// [RU] Класс описывает глобальную конфигурацию приложения AinDevHelper<br/>
    /// [EN] The class describes the global configuration of the AinDevHelper application
    /// </summary>
    public sealed class AinDevHelperGlobalConfig {
        private static readonly object _lock = new object();
        private static AinDevHelperGlobalConfig instance = null;
        private string appStartupPath;

        /// <summary>
        /// [RU] Словарь, содержащий название типа версии AinDevHelper<br/>
        /// [EN] A dictionary containing the version type name of AinDevHelper
        /// </summary>
        public Dictionary<string, string> VersionTypeNameDict { get; } = new Dictionary<string, string>() {
            { RU, "Pre-Alpha" },
            { EN, "Pre-Alpha" },
            { DE, "Pre-Alpha" }
        };


        /// <summary>
        /// [RU] Каталог запуска приложения AinDevHelper<br/>
        /// [EN] AinDevHelper application startup directory
        /// </summary>
        public string AppStartupPath { 
            get => appStartupPath; 
            set {
                appStartupPath = value;
                PluginsDirectoryFullPath = Path.Combine(appStartupPath, PluginsDirectoryName);
            } 
        }

        /// <summary>
        /// [RU] Название директории для плагинов
        /// [EN] Directory name for plugins
        /// </summary>
        public string PluginsDirectoryName { get; set; } = "plugins";

        /// <summary>
        /// [RU] Полный путь к директории для плагинов
        /// [EN] Full path to the plugin directory
        /// </summary>
        public string PluginsDirectoryFullPath { get; set; }

        /// <summary>
        /// [RU] Закрытый конструктор класса без параметров
        /// [EN] Private class constructor without parameters
        /// </summary>
        private AinDevHelperGlobalConfig() { }

        /// <summary>
        /// [RU] Единый экземпляр глобальной конфигурации приложения
        /// [EN] Single instance of global application configuration
        /// </summary>
        public static AinDevHelperGlobalConfig Instance {
            get {
                lock (_lock) {
                    if (instance == null) {
                        instance = new AinDevHelperGlobalConfig();
                    }
                    return instance;
                }
            }
        }
    }
}
