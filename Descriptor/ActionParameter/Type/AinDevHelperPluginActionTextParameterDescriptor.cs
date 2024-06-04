using System;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Descriptor {
    /// <summary>
    /// [RU] Класс описывает дескриптор параметра с типом "text" для действия плагина.
    /// [EN] The class represents a "text" type parameter descriptor for the plugin action.
    /// </summary>
    [Serializable]
    public class AinDevHelperPluginActionTextParameterDescriptor : AinDevHelperPluginActionParameterDescriptor {
        /// <summary>
        /// [RU] Значение текста в текстовом поле для параметра плагина
        /// [EN] Text value in the text field for a plugin parameter
        /// </summary>
        [XmlAttribute]
        public string Text { get; set; }

        public AinDevHelperPluginActionTextParameterDescriptor() {

        }

        public override string ToString() {
            return $"{{Имя:{Name}, Метка:{Label}, Текст: {Text}}}";
        }
    }
}
