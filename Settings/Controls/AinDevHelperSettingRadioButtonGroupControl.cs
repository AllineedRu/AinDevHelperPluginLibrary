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
