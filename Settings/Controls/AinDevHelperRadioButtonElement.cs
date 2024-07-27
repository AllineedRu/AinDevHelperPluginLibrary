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
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Settings.Controls {
    [Serializable]
    public class AinDevHelperRadioButtonElement : AinDevHelperSettingBaseControl {
        public string Title { get; set; }
        public string Value { get; set; }

        public HashSet<AinDevHelperLocalizedMessage> LocalizedTitles { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();

        public AinDevHelperRadioButtonElement() {

        }

        public AinDevHelperRadioButtonElement(string name, string title, string value) : this(name, title, value, null) {
        }

        public AinDevHelperRadioButtonElement(string name, string title, string value, params (string languageCode, string message)[] localizedTitles) : base(name) {
            Title = title;
            Value = value;
            if (localizedTitles != null && localizedTitles.Length > 0) {
                foreach ((string langCode, string msg) in localizedTitles) {
                    LocalizedTitles.Add(new AinDevHelperLocalizedMessage(langCode, msg));
                }
            }
        }

        public string GetLocalizedTitle(string currentLanguageCode) {
            if (LocalizedTitles != null && LocalizedTitles.Count > 0) {
                Func<AinDevHelperLocalizedMessage, bool> predicateLocalizedTitleFound =
                    localizedTitle => localizedTitle != null
                    && localizedTitle.LanguageCode != null
                    && localizedTitle.LanguageCode.Equals(currentLanguageCode);

                if (LocalizedTitles.Any(predicateLocalizedTitleFound)) {
                    return LocalizedTitles.First(predicateLocalizedTitleFound).Message;
                }
            }
            return Title;
        }


        public override bool Equals(object obj) {
            return obj is AinDevHelperRadioButtonElement element &&
                   Title == element.Title &&
                   EqualityComparer<HashSet<AinDevHelperLocalizedMessage>>.Default.Equals(LocalizedTitles, element.LocalizedTitles);
        }

        public override int GetHashCode() {
            int hashCode = 127567246;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<HashSet<AinDevHelperLocalizedMessage>>.Default.GetHashCode(LocalizedTitles);
            return hashCode;
        }
    }
}
