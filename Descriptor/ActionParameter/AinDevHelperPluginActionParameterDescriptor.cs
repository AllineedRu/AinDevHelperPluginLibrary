using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using AinDevHelperPluginLibrary.Language;

namespace AinDevHelperPluginLibrary.Descriptor {
    /// <summary>
    /// [RU] Дескриптор для параметра действия плагина<br/>
    /// [EN] Descriptor for plugin action parameter
    /// </summary>
    [Serializable]
    public abstract class AinDevHelperPluginActionParameterDescriptor {
        /// <summary>
        /// [RU] Внутреннее имя параметра действия плагина. Используется в коде плагина для реализации работы действия плагина<br/>
        /// [EN] The internal name of the plugin action parameter. Used in the plugin code to implement the plugin action
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        /// [RU] Читаемый текст метки с названием параметра на форме в интерфейсе AinDevHelper<br/>
        /// [EN] Readable text of the label with the name of the parameter on the form in the AinDevHelper interface
        /// </summary>
        [XmlAttribute]
        public string Label { get; set; }

        /// <summary>
        /// [RU] Описание параметра в интерфейсе AinDevHelper<br/>
        /// [EN] Description of the parameter in the AinDevHelper interface
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// [RU] Локализованные тексты для метки плагина на форме<br/>
        /// [EN] Localized texts for the plugin label on the form
        /// </summary>
        public HashSet<AinDevHelperLocalizedMessage> LocalizedLabels { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();

        /// <summary>
        /// [RU] Локализованные описания для параметра плагина<br/>
        /// [EN] Localized descriptions for a plugin parameter
        /// </summary>
        public HashSet<AinDevHelperLocalizedMessage> LocalizedDescriptions { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();


        //[XmlAttribute]
        //public AinDevHelperActionParameterType Type { get; set; }

        public AinDevHelperPluginActionParameterDescriptor() {

        }
    }
}
