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
