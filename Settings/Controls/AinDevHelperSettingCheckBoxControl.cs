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
    /// [RU] Класс описывает элемент управления в настройках плагина в виде флажка (чекбокса)<br/>
    /// [EN] The class describes a control element in the plugin settings in the form of checkbox
    /// </summary>
    [Serializable]
    public class AinDevHelperSettingCheckBoxControl : AinDevHelperSettingControlWithLabel {
        /// <summary>
        /// [RU] Свойство определяет, выбран или нет флажок в элементе управления<br/>
        /// [EN] Property determines whether a checkbox in a control is selected or not
        /// </summary>
        public bool Checked { get; set; }

        public AinDevHelperSettingCheckBoxControl() {
        }

        

        public AinDevHelperSettingCheckBoxControl(string name, string label) : base(name, label) {
        }
    }
}
