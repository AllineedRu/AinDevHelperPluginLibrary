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
    /// [RU] Класс описывает элемент управления в виде текстового поля<br/>
    /// [EN] The class describes a control as a text field
    /// </summary>
    [Serializable]
    public class AinDevHelperSettingTextBoxControl : AinDevHelperSettingControlWithLabel {
        /// <summary>
        /// [RU] Текст в текстовом поле<br/>
        /// [EN] Text in a text box
        /// </summary>
        public string Text { get; set; }

        public AinDevHelperSettingTextBoxControl() {
        }

        public AinDevHelperSettingTextBoxControl(string name, string label) : base(name) {
            Text = "";
            Label = label;
        }

        public AinDevHelperSettingTextBoxControl(string name, string label, string textValue) : base(name) {
            Text = textValue;
            Label = label;
        }
    }
}
