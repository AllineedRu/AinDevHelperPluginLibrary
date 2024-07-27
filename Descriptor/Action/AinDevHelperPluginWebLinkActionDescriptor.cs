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
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Descriptor {
    /// <summary>
    /// [RU] Описывает дескриптор действия с типом "Веб-ссылка" для плагина
    /// [EN] Describes the action handle of type "Web Link" for the plugin
    /// </summary>
    [Serializable]
    public class AinDevHelperPluginWebLinkActionDescriptor : AinDevHelperPluginActionDescriptor {
        /// <summary>
        /// [RU] Адрес Веб-ссылки (URL), по которой можно перейти при выполнении действия<br/>
        /// [EN] The address of the web link (URL) that can be followed when performing the action
        /// </summary>
        [XmlAttribute]
        public string WebLink { get; set; }

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperPluginWebLinkActionDescriptor() {

        }
    }
}
