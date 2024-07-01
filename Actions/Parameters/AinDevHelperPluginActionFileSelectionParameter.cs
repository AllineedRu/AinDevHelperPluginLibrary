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
    /// [RU] Класс описывает параметр с типом "Выбор файла" для параметризованного действия плагина<br/>
    /// [EN] The class describes a parameter with type "Select file" for a parameterized plugin action
    /// </summary>
    public class AinDevHelperPluginActionFileSelectionParameter : AinDevHelperPluginActionParameter {
        /// <summary>
        /// [RU] Полный путь к выбранному файлу<br/>
        /// [EN] Full path to the selected file
        /// </summary>
        public string SelectedFile { get; set; }

        /// <summary>
        /// [RU] Название текстового поля, связанного с данным параметром. Свойство используется AinDevHelper и не предполагает использования на стороне плагина<br/>
        /// [EN] The name of the text field associated with this parameter. The property is used by AinDevHelper and is not intended to be used on the plugin side
        /// </summary>
        public string RelatedTextBoxName { get; set; }

        public AinDevHelperPluginActionFileSelectionParameter(string name, string label) : this(name, label, "") {
        }

        public AinDevHelperPluginActionFileSelectionParameter(string name, string label, string description) : base(name, label, description) {
        }
    }
}
