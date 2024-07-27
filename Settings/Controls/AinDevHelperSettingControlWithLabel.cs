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
using System.Linq;

namespace AinDevHelperPluginLibrary.Settings.Controls {
    /// <summary>
    /// [RU] Класс описывает элемент управления для настроек плагина, сопровождаемый читаемой меткой<br/>
    /// [EN] The class describes a control for plugin settings, accompanied by a readable label
    /// </summary>
    [Serializable]
    public abstract class AinDevHelperSettingControlWithLabel : AinDevHelperSettingBaseControl {
        /// <summary>
        /// [RU] Метка на форме для элемента управления<br/>
        /// [EN] Label on the form for the control
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// [RU] Набор локализованных меток для элемента управления<br/>
        /// [EN] A set of localized labels for a control
        /// </summary>
        public HashSet<AinDevHelperLocalizedMessage> LocalizedLabels { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();

        public AinDevHelperSettingControlWithLabel(string name) : base(name) {

        }

        public AinDevHelperSettingControlWithLabel(string name, string label) : base(name) {
            Label = label;
        }

        public AinDevHelperSettingControlWithLabel() {

        }
        
        /// <summary>
        /// [RU] Получает локализованную метку для данного экземпляра элемента управления настроек плагина<br/>
        /// [EN] Gets the localized label for a given plugin settings control instance
        /// </summary>
        /// <param name="currentLanguageCode">[RU] код языка, для которого требуется получить локализованную метку;<br/>[EN] code of the language for which you want to get the localized label</param>
        /// <returns>[RU] возвращает локализованную метку для указанного кода языка, если она установлена для данного экземпляра, в противном случае возвращает нелокализованную метку;<br/>
        /// [EN] returns the localized label for the specified language code if one is set for this instance, otherwise returns the non-localized label</returns>
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
