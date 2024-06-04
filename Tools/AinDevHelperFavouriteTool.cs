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
