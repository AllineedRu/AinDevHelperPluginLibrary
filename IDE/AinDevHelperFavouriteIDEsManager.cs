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
using AinDevHelperPluginLibrary.Global;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.IDE {
    public class AinDevHelperFavouriteIDEsManager {
        private const string FAVOURITE_IDE_CONFIG_FILE = "favourite_ide.xml";
        private static readonly object _lock = new object();
        private static AinDevHelperFavouriteIDEsManager instance = null;
        private AinDevHelperGlobalConfig GlobalConfig { get; set; }
        public AinDevHelperFavouriteIDEsConfiguration FavouriteIDEsConfiguration { get; set; }

        private AinDevHelperFavouriteIDEsManager() {
            GlobalConfig = AinDevHelperGlobalConfig.Instance;
        }

        /// <summary>
        /// [RU] Возвращает ссылку на экземпляр менеджера избранных сред разработки<br/>
        /// [EN] Returns a reference to an instance of the favourite IDEs manager
        /// </summary>
        public static AinDevHelperFavouriteIDEsManager Instance {
            get {
                lock (_lock) {
                    if (instance == null) {
                        instance = new AinDevHelperFavouriteIDEsManager();
                    }
                    return instance;
                }
            }
        }

        /// <summary>
        /// [RU] Свойство возвращает список избранных сред разработки<br/>
        /// [EN] The property returns a list of favourite IDEs
        /// </summary>
        public List<AinDevHelperFavouriteIDE> IDEs {
            get {
                return FavouriteIDEsConfiguration != null ? FavouriteIDEsConfiguration.IDEs : new List<AinDevHelperFavouriteIDE>();
            }
        }

        /// <summary>
        /// [RU] Добавить указанную избранную среду разработки в конфигурацию<br/>
        /// [EN] Add the specified favourite IDE to the configuration
        /// </summary>
        /// <param name="favouriteIDE">[RU] Ссылка на экземпляр избранной среды разработки;<br/>[EN] Link to an instance of the favourite IDE</param>
        /// <returns>[RU] true, если добавление в конфигурацию успешно, в противном случае false;<br/>[EN] true if adding to the configuration is successful, otherwise false</returns>
        public bool AddFavouriteIDE(AinDevHelperFavouriteIDE favouriteIDE) {
            if (FavouriteIDEsConfiguration == null) {
                return false;
            }
            FavouriteIDEsConfiguration.IDEs.Add(favouriteIDE);
            return true;
        }

        /// <summary>
        /// [RU] Удалить указанную избранную среду разработки из конфигурации<br/>
        /// [EN] Remove the specified favourite IDE from the configuration
        /// </summary>
        /// <param name="favouriteIDE">[RU] Ссылка на экземпляр избранной среды разработки;<br/>[EN] Link to an instance of the favourite IDE</param>
        /// <returns>[RU] true, если удаление прошло успешно, в противном случае false;<br/>[EN] true if the deletion was successful, otherwise false</returns>
        public bool RemoveFavouriteIDE(AinDevHelperFavouriteIDE favouriteIDE) {
            if (FavouriteIDEsConfiguration == null) {
                return false;
            }
            return FavouriteIDEsConfiguration.IDEs.Remove(favouriteIDE);
        }

        /// <summary>
        /// [RU] Сохранить текущую конфигурацию избранных сред разработки на диск в виде XML-файла<br/>
        /// [EN] Save the current configuration of favourite IDEs to disk as an XML file
        /// </summary>
        /// <returns>[RU] true, если сохранение в файл успешно, в противном случае false;<br/>[EN] true if saving to file is successful, otherwise false</returns>
        public bool SaveFavouriteIDEsConfiguration() {
            if (FavouriteIDEsConfiguration == null) {
                return false;
            }
            try {
                string favouriteIDEsConfigFile = GlobalConfig.AppStartupPath + Path.DirectorySeparatorChar + FAVOURITE_IDE_CONFIG_FILE;
                var xmlSerializer = new XmlSerializer(FavouriteIDEsConfiguration.GetType());

                using var fileStream = new FileStream(favouriteIDEsConfigFile, FileMode.Create, FileAccess.Write);
                xmlSerializer.Serialize(fileStream, FavouriteIDEsConfiguration);
                fileStream.Close();
                return true;
            } catch (Exception) {
                return false;
            }
        }

        /// <summary>
        /// [RU] Загрузить из XML-файла конфигурацию избранных сред разработки<br/>
        /// [EN] Loads the configuration of favourite IDEs from an XML file
        /// </summary>
        /// <returns>true, если загрузка из файла успешна, в противном случае false;<br/>[EN] true if loading from file is successful, otherwise false</returns>
        public bool LoadFavouriteIDEsConfiguration() {
            try {
                string favouriteIDEsConfigFile = GlobalConfig.AppStartupPath + Path.DirectorySeparatorChar + FAVOURITE_IDE_CONFIG_FILE;
                if (!File.Exists(favouriteIDEsConfigFile)) {
                    FavouriteIDEsConfiguration = new AinDevHelperFavouriteIDEsConfiguration();
                    return false;
                } else {
                    var xmlSerializer = new XmlSerializer(typeof(AinDevHelperFavouriteIDEsConfiguration));
                    using var fileStream = new FileStream(favouriteIDEsConfigFile, FileMode.Open);
                    FavouriteIDEsConfiguration = (AinDevHelperFavouriteIDEsConfiguration)xmlSerializer.Deserialize(fileStream);
                    return true;
                }
            } catch (Exception) {
                return false;
            }
        }
    }
}
