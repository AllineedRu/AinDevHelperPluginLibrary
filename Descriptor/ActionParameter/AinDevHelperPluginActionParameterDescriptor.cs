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
