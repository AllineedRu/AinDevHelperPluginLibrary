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
using System.IO;
using System.Xml.Serialization;
using AinDevHelperPluginLibrary.Global;

namespace AinDevHelperPluginLibrary.Tools {
    /// <summary>
    /// [RU] Класс описывает менеджер избранных инструментов разработчика со служебными методами по загрузке и сохранению конфигурации избранных инструментов<br/>
    /// [EN] The class describes a manager of favorite developer tools with utility methods for loading and saving the configuration of favorite tools
    /// </summary>
    public sealed class AinDevHelperFavouriteToolsManager {
        private const string FAVOURITE_TOOLS_CONFIG_FILE = "favourite_tools.xml";
        private static readonly object _lock = new object();
        private static AinDevHelperFavouriteToolsManager instance = null;
        private AinDevHelperGlobalConfig GlobalConfig { get; set; }
        public AinDevHelperFavouriteToolsConfiguration FavouriteToolsConfiguration { get; set; }

        private AinDevHelperFavouriteToolsManager() {
            GlobalConfig = AinDevHelperGlobalConfig.Instance;
        }

        /// <summary>
        /// [RU] Возвращает ссылку на экземпляр менеджера избранных инструментов разработчика<br/>
        /// [EN] Returns a reference to an instance of the favourite developer tools manager
        /// </summary>
        public static AinDevHelperFavouriteToolsManager Instance {
            get {
                lock (_lock) {
                    if (instance == null) {
                        instance = new AinDevHelperFavouriteToolsManager();
                    }
                    return instance;
                }
            }
        }

        /// <summary>
        /// [RU] Возвращает список избранных инструментов разработчика из конфигурации или пустой список, если конфигурация ещё не была инициализирована<br/>
        /// [EN] Returns a list of favourite developer tools from the configuration, or an empty list if the configuration has not yet been initialized
        /// </summary>
        public List<AinDevHelperFavouriteTool> Tools { 
            get {
                return FavouriteToolsConfiguration != null ? FavouriteToolsConfiguration.Tools : new List<AinDevHelperFavouriteTool>();
            } 
        }

        /// <summary>
        /// [RU] Добавить указанный избранный инструмент разработчика в конфигурацию<br/>
        /// [EN] Add the specified favourite developer tool to the configuration
        /// </summary>
        /// <param name="favouriteTool">[RU] Ссылка на экземпляр избранного инструмента разработчика;<br/>[EN] Link to an instance of the favourite developer tool</param>
        /// <returns>[RU] true, если добавление в конфигурацию успешно, в противном случае false;<br/>[EN] true if adding to the configuration is successful, otherwise false</returns>
        public bool AddFavouriteTool(AinDevHelperFavouriteTool favouriteTool) {
            if (FavouriteToolsConfiguration == null) {
                return false;
            }
            FavouriteToolsConfiguration.Tools.Add(favouriteTool);
            return true;
        }

        /// <summary>
        /// [RU] Удалить указанный избранный инструмент разработичка из конфигурации<br/>
        /// [EN] Remove the specified favourite developer tool from the configuration
        /// </summary>
        /// <param name="favouriteTool">[RU] Ссылка на экземпляр избранного инструмента разработчика;<br/>[EN] Link to an instance of the favourite developer tool</param>
        /// <returns>[RU] true, если удаление прошло успешно, в противном случае false;<br/>[EN] true if the deletion was successful, otherwise false</returns>
        public bool RemoveFavouriteTool(AinDevHelperFavouriteTool favouriteTool) {
            if (FavouriteToolsConfiguration == null) {
                return false;
            }
            return FavouriteToolsConfiguration.Tools.Remove(favouriteTool);
        }

        /// <summary>
        /// [RU] Сохранить текущую конфигурацию избранных инструментов разработчика на диск в виде XML-файла<br/>
        /// [EN] Save the current configuration of favourite developer tools to disk as an XML file
        /// </summary>
        /// <returns>[RU] true, если сохранение в файл успешно, в противном случае false;<br/>[EN] true if saving to file is successful, otherwise false</returns>
        public bool SaveFavouriteToolsConfiguration() {
            if (FavouriteToolsConfiguration == null) {
                return false;
            }
            try {
                string favouriteToolsConfigFile = GlobalConfig.AppStartupPath + Path.DirectorySeparatorChar + FAVOURITE_TOOLS_CONFIG_FILE;
                var xmlSerializer = new XmlSerializer(FavouriteToolsConfiguration.GetType());

                using var fileStream = new FileStream(favouriteToolsConfigFile, FileMode.Create, FileAccess.Write);
                xmlSerializer.Serialize(fileStream, FavouriteToolsConfiguration);
                fileStream.Close();
                return true;
            } catch (Exception) {
                return false;
            }
        }

        /// <summary>
        /// [RU] Загрузить из XML-файла конфигурацию избранных инструментов разработчика<br/>
        /// [EN] Loads the configuration of favourite developer tools from an XML file
        /// </summary>
        /// <returns>true, если загрузка из файла успешна, в противном случае false;<br/>[EN] true if loading from file is successful, otherwise false</returns>
        public bool LoadFavouriteToolsConfiguration() {
            try {
                string favouriteToolsConfigFile = GlobalConfig.AppStartupPath + Path.DirectorySeparatorChar + FAVOURITE_TOOLS_CONFIG_FILE;
                if (!File.Exists(favouriteToolsConfigFile)) {
                    FavouriteToolsConfiguration = new AinDevHelperFavouriteToolsConfiguration();
                    return false;
                } else {
                    var xmlSerializer = new XmlSerializer(typeof(AinDevHelperFavouriteToolsConfiguration));
                    using var fileStream = new FileStream(favouriteToolsConfigFile, FileMode.Open);
                    FavouriteToolsConfiguration = (AinDevHelperFavouriteToolsConfiguration)xmlSerializer.Deserialize(fileStream);
                    return true;
                }
            } catch (Exception) {
                return false;
            }
        }
    }
}
