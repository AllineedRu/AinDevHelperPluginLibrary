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
