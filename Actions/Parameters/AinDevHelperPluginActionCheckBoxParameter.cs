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
    /// [RU] Класс описывает параметр с типом "Флажок" для параметризованного действия плагина<br/>
    /// [EN] The class describes a parameter with type "Checkbox" for a parameterized plugin action
    /// </summary>
    public class AinDevHelperPluginActionCheckBoxParameter : AinDevHelperPluginActionParameter {
        /// <summary>
        /// [RU] Свойство возращает или задаёт значение флажка - отмечен он или нет<br/>
        /// [EN] The property returns or sets the value of the checkbox - whether it is checked or not
        /// </summary>
        public bool Checked { get; set; }

        public AinDevHelperPluginActionCheckBoxParameter(string name, string label) : this(name, label, "", false) {
        }

        public AinDevHelperPluginActionCheckBoxParameter(string name, string label, string description) : this(name, label, description, false) {
        }

        public AinDevHelperPluginActionCheckBoxParameter(string name, string label, string description, bool isInitiallyChecked) : base(name, label, description) {
            Checked = isInitiallyChecked;
        }
    }
}
