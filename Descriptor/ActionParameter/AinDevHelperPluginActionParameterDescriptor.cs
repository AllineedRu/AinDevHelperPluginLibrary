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
using System.Xml.Serialization;
using AinDevHelperPluginLibrary.Language;

namespace AinDevHelperPluginLibrary.Descriptor.ActionParameter {
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

        public AinDevHelperPluginActionParameterDescriptor() {

        }

        public override string ToString() {
            return $"{{{Name}; {Label}}}";
        }
    }
}
