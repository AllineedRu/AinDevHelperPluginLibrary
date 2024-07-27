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
