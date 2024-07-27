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

namespace AinDevHelperPluginLibrary.Settings.Controls {
    /// <summary>
    /// [RU] Класс описывает элемент управления в настройках плагина в виде выбора директории<br/>
    /// [EN] The class describes a control element in the plugin settings in the form of directory selection
    /// </summary>
    [Serializable]
    public class AinDevHelperSettingDirectorySelectionControl : AinDevHelperSettingControlWithLabel {
        //[XmlAttribute]
        /// <summary>
        /// [RU] Выбранная пользователем директория в элементе управления в настройках плагина<br/>
        /// [EN] User-selected directory in the control in the plugin settings
        /// </summary>
        public string SelectedDirectory { get; set; }

        /// <summary>
        /// [RU] Является ли текстовое поле, куда подставляется путь к выбранной директории, неизменяемым (только для чтения)<br/>
        /// [EN] Is the text field where the path to the selected directory is inserted immutable (read-only)
        /// </summary>
        public bool IsReadOnly { get; set; } = true;

        /// <summary>
        /// [RU] Название связанного текстового поля. Инициализируется AinDevHelper, не предполагается использование этого свойства плагином<br/>
        /// [EN] The name of the associated text field. Initialized by AinDevHelper, the plugin is not expected to use this property
        /// </summary>
        public string RelatedTextBoxName { get; set; }

        public AinDevHelperSettingDirectorySelectionControl(string name, string label) : this(name, label, null) {            
        }

        public AinDevHelperSettingDirectorySelectionControl(string name, string label, string selectedDirectory) : base(name, label) {
            SelectedDirectory = selectedDirectory;
        }

        public AinDevHelperSettingDirectorySelectionControl() {
        }
    }
}
