using System.IO;
using System.Collections.Generic;
using AinDevHelperPluginLibrary.Language;
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
