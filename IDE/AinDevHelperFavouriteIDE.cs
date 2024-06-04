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
