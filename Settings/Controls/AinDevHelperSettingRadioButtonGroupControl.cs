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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Settings.Controls {
    [Serializable]
    public class AinDevHelperSettingRadioButtonGroupControl : AinDevHelperSettingBaseControl {
        public string GroupHeaderTitle { get; set; }

        public string SelectedValue { get; set; }

        public HashSet<AinDevHelperLocalizedMessage> LocalizedGroupHeaderTitles { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();

        public HashSet<AinDevHelperRadioButtonElement> RadioButtonElements { get; set; } = new HashSet<AinDevHelperRadioButtonElement>();

        public AinDevHelperSettingRadioButtonGroupControl() {

        }

        public AinDevHelperSettingRadioButtonGroupControl(string name, string groupHeaderTitle, string selectedValue) : this(name, groupHeaderTitle, selectedValue, null) {
        }

        public AinDevHelperSettingRadioButtonGroupControl(string name, string groupHeaderTitle, string selectedValue, params (string languageCode, string message)[] localizedGroupHeaderTitles) : base(name) {
            GroupHeaderTitle = groupHeaderTitle;
            SelectedValue = selectedValue;
            if (localizedGroupHeaderTitles != null && localizedGroupHeaderTitles.Length > 0) {
                foreach ((string langCode, string msg) in localizedGroupHeaderTitles) {
                    LocalizedGroupHeaderTitles.Add(new AinDevHelperLocalizedMessage(langCode, msg));
                }
            }
        }


        public void AddRadioButtonElement(AinDevHelperRadioButtonElement radioButtonElement) {
            RadioButtonElements.Add(radioButtonElement);
        }

        public void AddRadioButtonElement(string name,string title, string value, params (string languageCode, string message)[] localizedTitles) {
            RadioButtonElements.Add(new AinDevHelperRadioButtonElement(name,title, value, localizedTitles));
        }

        public string GetLocalizedGroupHeaderTitle(string currentLanguageCode) {
            if (LocalizedGroupHeaderTitles != null && LocalizedGroupHeaderTitles.Count > 0) {
                Func<AinDevHelperLocalizedMessage, bool> predicateLocalizedGroupHeaderTitleFound = 
                    localizedGroupHeaderTitle => localizedGroupHeaderTitle != null 
                    && localizedGroupHeaderTitle.LanguageCode != null 
                    && localizedGroupHeaderTitle.LanguageCode.Equals(currentLanguageCode);

                if (LocalizedGroupHeaderTitles.Any(predicateLocalizedGroupHeaderTitleFound)) {
                    return LocalizedGroupHeaderTitles.First(predicateLocalizedGroupHeaderTitleFound).Message;
                }
            }
            return GroupHeaderTitle;
        }

    }
}
