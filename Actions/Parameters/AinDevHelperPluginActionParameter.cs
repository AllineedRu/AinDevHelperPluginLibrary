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
using System.Linq;
using AinDevHelperPluginLibrary.Language;

namespace AinDevHelperPluginLibrary.Actions.Parameters {
    /// <summary>
    /// [RU] Представляет собой базовый класс для параметров, используемых в параметризированных действиях плагина<br/>
    /// [EN] Represents the base class for parameters used in parameterized plugin actions
    /// </summary>
    public abstract class AinDevHelperPluginActionParameter {
        /// <summary>
        /// [RU] Имя параметра. Это внутреннее имя параметра, который плагин будет использоваться в своей реализации<br/>
        /// [EN] Parameter name. This is the internal name of the parameter that the plugin will use in its implementation
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// [RU] Метка для параметра (выводится на форме для параметра при вызове действия)<br/>
        /// [EN] Label for the parameter (displayed on the form for the parameter when the action is called)
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// [RU] Описание параметра<br/>
        /// [EN] Parameter description
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

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperPluginActionParameter() {

        }

        public AinDevHelperPluginActionParameter(string name, string label) : this(name, label, "") {            
        }

        public AinDevHelperPluginActionParameter(string name, string label, string description) {
            Name = name;
            Label = label;
            Description = description;
        }

        /// <summary>
        /// [RU] Получает локализованное описание для данного экземпляра параметра действия плагина<br/>
        /// [EN] Gets a localized description for a given plugin action parameter instance
        /// </summary>
        /// <param name="currentLanguageCode">[RU] код языка, для которого требуется получить локализованное описание параметра;<br/>[EN] language code for which you want to get a localized description of the parameter</param>
        /// <returns>[RU] возвращает локализованное описание для указанного кода языка, если оно установлено для данного экземпляра параметра, в противном случае возвращает нелокализованное описание параметра;<br/>
        /// [EN] returns a localized description for the specified language code if one is set for this parameter instance, otherwise returns a non-localized description of the parameter</returns>
        public string GetLocalizedDescription(string currentLanguageCode) {
            if (LocalizedDescriptions != null && LocalizedDescriptions.Count > 0) {
                Func<AinDevHelperLocalizedMessage, bool> predicateLocalizedDescriptionFound = localizedDescription => localizedDescription != null && localizedDescription.LanguageCode != null && localizedDescription.LanguageCode.Equals(currentLanguageCode);
                if (LocalizedDescriptions.Any(predicateLocalizedDescriptionFound)) {
                    return LocalizedDescriptions.First(predicateLocalizedDescriptionFound).Message;
                }
            }
            return Description;
        }

        /// <summary>
        /// [RU] Получает локализованную метку для данного экземпляра параметра действия плагина<br/>
        /// [EN] Gets the localized label for a given plugin action parameter instance
        /// </summary>
        /// <param name="currentLanguageCode">[RU] код языка, для которого требуется получить локализованную метку для параметра;<br/>[EN] code of the language for which you want to get the localized label for the parameter</param>
        /// <returns>[RU] возвращает локализованную метку для указанного кода языка, если она установлена для данного экземпляра параметра, в противном случае возвращает нелокализованную метку для параметра;<br/>
        /// [EN] returns the localized label for the specified language code if one is set for this parameter instance, otherwise returns the non-localized label for the parameter</returns>
        public string GetLocalizedLabel(string currentLanguageCode) {
            if (LocalizedLabels != null && LocalizedLabels.Count > 0) {
                Func<AinDevHelperLocalizedMessage, bool> predicateLocalizedLabelFound = localizedLabel => localizedLabel != null && localizedLabel.LanguageCode != null && localizedLabel.LanguageCode.Equals(currentLanguageCode);
                if (LocalizedLabels.Any(predicateLocalizedLabelFound)) {
                    return LocalizedLabels.First(predicateLocalizedLabelFound).Message;
                }
            }
            return Label;
        }
    }
}
