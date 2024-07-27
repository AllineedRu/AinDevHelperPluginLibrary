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
namespace AinDevHelperPluginLibrary.Actions.Parameters {
    /// <summary>
    /// [RU] Класс описывает параметр с типом "Выбор каталога" для параметризованного действия плагина<br/>
    /// [EN] The class describes a parameter with type "Select directory" for a parameterized plugin action
    /// </summary>
    public class AinDevHelperPluginActionDirectorySelectionParameter : AinDevHelperPluginActionParameter {
        /// <summary>
        /// [RU] Полный путь к выбранному каталогу<br/>
        /// [EN] Full path to the selected directory
        /// </summary>
        public string SelectedDirectory { get; set; }

        /// <summary>
        /// [RU] Название текстового поля, связанного с данным параметром. Свойство используется AinDevHelper и не предполагает использования на стороне плагина<br/>
        /// [EN] The name of the text field associated with this parameter. The property is used by AinDevHelper and is not intended to be used on the plugin side
        /// </summary>
        public string RelatedTextBoxName { get; set; }

        public AinDevHelperPluginActionDirectorySelectionParameter(string name, string label) : this(name, label, "") {
        }

        public AinDevHelperPluginActionDirectorySelectionParameter(string name, string label, string description) : this(name, label, description, "") {
        }

        public AinDevHelperPluginActionDirectorySelectionParameter(string name, string label, string description, string selectedDirectory) : base(name, label, description) {
            SelectedDirectory = selectedDirectory;
        }
    }
}
