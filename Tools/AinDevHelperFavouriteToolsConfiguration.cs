using System;
using System.Collections.Generic;

namespace AinDevHelperPluginLibrary.Tools {
    /// <summary>
    /// [RU] Класс описывает конфигурацию AinDevHelper со списком избранных инструментов разработчика<br/>
    /// [EN] The class describes the AinDevHelper configuration with a list of favourite developer tools
    /// </summary>
    [Serializable]
    public class AinDevHelperFavouriteToolsConfiguration {
        /// <summary>
        /// [RU] Список избранных инструментов разработчика<br/>
        /// [EN] List of favourite developer tools
        /// </summary>
        public List<AinDevHelperFavouriteTool> Tools { get; set; } = new List<AinDevHelperFavouriteTool>();

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperFavouriteToolsConfiguration() {

        }
    }
}
