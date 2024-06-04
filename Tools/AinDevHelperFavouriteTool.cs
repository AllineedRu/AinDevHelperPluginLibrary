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

namespace AinDevHelperPluginLibrary.Tools {
    /// <summary>
    /// [RU] Класс описывает избранный инструмент разработчика. Это может быть какое-то внешнее приложение или системное приложение,
    /// которое необходимо периодически запускать.<br/>
    /// [EN] The class describes the developer's favourite tool. 
    /// This could be some external application or a system application that needs to be launched periodically.
    /// </summary>
    [Serializable]
    public class AinDevHelperFavouriteTool {
        /// <summary>
        /// [RU] Название избранного инструмента разработчика. Это название будет отображаться в главном меню "Инструменты"<br/>
        /// [EN] The name of the favourite developer tool. This name will be displayed in the main menu "Tools"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// [RU] Полный путь до исполняемого файла для избранного инструмента. Этот путь включает в себя исполняемый файл избранного инструмента и используется для его запуска из AinDevHelper<br/>
        /// [EN] The full path to the executable file for the favourite tool. This path includes the executable file of the favourite tool and is used to launch it from AinDevHelper
        /// </summary>
        public string ExecutablePath { get; set; }

        /// <summary>
        /// [RU] Конструктор с параметрами<br/>
        /// [EN] Constructor with parameters
        /// </summary>
        /// <param name="name">[RU] название избранного инструмента разработчика;<br/>[EN] name of favourite developer tool</param>
        /// <param name="executablePath">[RU] полный путь до исполняемого файла для избранного инструмента;<br/>[EN] full path to the executable file for the favourite tool</param>
        public AinDevHelperFavouriteTool(string name, string executablePath) { 
            Name = name;
            ExecutablePath = executablePath;        
        }

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperFavouriteTool() {

        }

        public override string ToString() {
            return $"{Name} - [{ExecutablePath}]";
        }

        public override bool Equals(object obj) {
            return obj is AinDevHelperFavouriteTool tool &&
                   Name == tool.Name &&
                   ExecutablePath == tool.ExecutablePath;
        }

        public override int GetHashCode() {
            int hashCode = 1719144644;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ExecutablePath);
            return hashCode;
        }
    }
}
