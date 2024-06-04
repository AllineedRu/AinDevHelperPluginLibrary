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
