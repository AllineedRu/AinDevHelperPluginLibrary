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
