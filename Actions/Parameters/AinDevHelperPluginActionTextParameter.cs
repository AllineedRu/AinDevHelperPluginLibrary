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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Actions.Parameters {
    /// <summary>
    /// [RU] Класс описывает тип данных "Текстовое поле" для параметра действия плагина. Это текстовое поле, в которое пользователь AinDevHelper сможет ввести произвольный текст<br/>
    /// [EN] The class describes the "Text field" data type for the plugin action parameter. This is a text field in which the AinDevHelper user will be able to enter arbitrary text
    /// </summary>
    public class AinDevHelperPluginActionTextParameter : AinDevHelperPluginActionParameter {
        public string Text { get; set; }

        public AinDevHelperPluginActionTextParameter(string name, string label) : this(name, label, "", "") {
        }

        public AinDevHelperPluginActionTextParameter(string name, string label, string description) : this(name, label, description, "") {
        }

        public AinDevHelperPluginActionTextParameter(string name, string label, string description, string text) : base(name, label, description) {
            Text = text;
        }
    }
}
