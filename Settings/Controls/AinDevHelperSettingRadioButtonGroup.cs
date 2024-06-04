using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary {
    [Serializable]
    public class AinDevHelperSettingRadioButtonGroup : IAinDevHelperSettingControlValue {
        /// <summary>
        /// Содержит имена всех радиокнопок в группе
        /// </summary>
        [XmlArray("RadioButtonNames"), XmlArrayItem(typeof(string), ElementName = "string")]
        public List<string> RadioButtonNames { get; set; } = new List<string>();
        
        /// <summary>
        /// Содержит имя выбранной радиокнопки
        /// </summary>
        public string CurrentValue { get; set; }

        /// <summary>
        /// Добавляет имя радиокнопки к текущей группе
        /// </summary>
        /// <param name="value"></param>
        public void AddValue(string value) {
            RadioButtonNames.Add(value);
        }
    }
}
