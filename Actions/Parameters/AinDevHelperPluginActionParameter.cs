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
