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

namespace AinDevHelperPluginLibrary.IDE {
    /// <summary>
    /// [RU] Класс описывает избранную среду разработки, которая может отображаться в меню AinDevHelper<br/>
    /// [EN] The class describes the favourite integrated development environment, which can be displayed in the AinDevHelper menu
    /// </summary>
    [Serializable]
    public class AinDevHelperFavouriteIDE {
        /// <summary>
        /// [RU] Название избранной среды разработки. Это название будет отображаться в главном меню "Среды разработки"<br/>
        /// [EN] The name of the favourite development environment. This name will be displayed in the main menu of "IDEs"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// [RU] Полный путь до исполняемого файла для избранной среды разработки. Этот путь включает в себя исполняемый файл избранной среды разработки и используется для его запуска из AinDevHelper<br/>
        /// [EN] Full path to the executable file for the favourite integrated development environment. This path includes the executable file of the chosen development environment and is used to launch it from AinDevHelper
        /// </summary>
        public string ExecutablePath { get; set; }

        public AinDevHelperFavouriteIDE(string name, string executablePath) {
            Name = name;
            ExecutablePath = executablePath;
        }

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperFavouriteIDE() {

        }

        public override string ToString() {
            return $"{Name} - [{ExecutablePath}]";
        }

        public override bool Equals(object obj) {
            return obj is AinDevHelperFavouriteIDE iDE &&
                   Name == iDE.Name &&
                   ExecutablePath == iDE.ExecutablePath;
        }

        public override int GetHashCode() {
            int hashCode = 1719144644;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ExecutablePath);
            return hashCode;
        }
    }
}
