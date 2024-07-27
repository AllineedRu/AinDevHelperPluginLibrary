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
using AinDevHelperPluginLibrary.Language;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Descriptor {
    /// <summary>
    /// [RU] Описывает абстрактный дескриптор действия для плагина
    /// [EN] Describes an abstract action descriptor for a plugin
    /// </summary>
    [Serializable]
    public abstract class AinDevHelperPluginActionDescriptor {
        /// <summary>
        /// [RU] Читаемое название действия для плагина
        /// [EN] Readable action name for the plugin
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        /// [RU] Внутренний идентификатор действия для плагина
        /// [EN] Internal action ID for the plugin
        /// </summary>
        [XmlAttribute]
        public string ID { get; set; }

        /// <summary>
        /// [RU] Список строк, каждая из которых представляет собой тег для действия плагина. Теги могут использоваться для быстрого поиска действия плагина<br/>
        /// [EN] A list of strings, each representing a tag for a plugin action. Tags can be used to quickly find a plugin action
        /// </summary>
        public List<string> Tags { get; set; } = new List<string>();

        /// <summary>
        /// [RU] Набор (множество) локализованных сообщений, описывающих название действия на поддерживаемых AinDevHelper языках<br/>
        /// [EN] A set of localized messages describing the name of the action in languages supported by AinDevHelper
        /// </summary>
        public HashSet<AinDevHelperLocalizedMessage> LocalizedNames { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();

        /// <summary>
        /// [RU] Сообщение об успешном выполнении действия плагина
        /// [EN] Plugin action success message
        /// </summary>
        public AinDevHelperPluginActionResultMessageDescriptor SuccessMessage { get; set; }

        /// <summary>
        /// [RU] Сообщение об ошибочном выполнении действия плагина
        /// [EN] Message about error execution of plugin action
        /// </summary>
        public AinDevHelperPluginActionResultMessageDescriptor ErrorMessage { get; set; }

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperPluginActionDescriptor() {
        }

        public void AddLocalizedName(string languageCode, string localizedActionName) {
            LocalizedNames.Add(new AinDevHelperLocalizedMessage(languageCode, localizedActionName));
        }
    }
}
