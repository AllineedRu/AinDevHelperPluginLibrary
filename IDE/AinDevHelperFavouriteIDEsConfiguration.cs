using System;
using System.Collections.Generic;

namespace AinDevHelperPluginLibrary.IDE {
    /// <summary>
    /// [RU] Класс описывает конфигурацию AinDevHelper со списком избранных сред разработки<br/>
    /// [EN] The class describes the AinDevHelper configuration with a list of favourite development environments
    /// </summary>
    [Serializable]
    public class AinDevHelperFavouriteIDEsConfiguration {
        /// <summary>
        /// [RU] Список избранных сред разработки<br/>
        /// [EN] List of favourite integrates development environments (IDEs)
        /// </summary>
        public List<AinDevHelperFavouriteIDE> IDEs { get; set; } = new List<AinDevHelperFavouriteIDE>();

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperFavouriteIDEsConfiguration() {

        }
    }
}
