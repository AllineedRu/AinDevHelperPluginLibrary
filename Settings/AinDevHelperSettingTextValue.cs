using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary {
    public class AinDevHelperSettingTextValue : IAinDevHelperSettingControlValue {
        /// <summary>
        /// Содержит текстовое значение
        /// </summary>
        public string CurrentValue { get; set; }        

        public void AddValue(string value) {
            CurrentValue = value;
        }

        public AinDevHelperSettingTextValue() {
        }

        public AinDevHelperSettingTextValue(string textValue) {
            AddValue(textValue);
        }
    }
}
