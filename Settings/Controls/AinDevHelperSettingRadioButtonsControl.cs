using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary {
    [Serializable]
    public class AinDevHelperSettingRadioButtonsControl : AinDevHelperSettingBaseControl {
        //protected IAinDevHelperSettingControlValue radioButtonGroup;
        public AinDevHelperSettingRadioButtonGroup RadioButtonGroup { get; set; }

        public AinDevHelperSettingRadioButtonsControl() {

        }

        public AinDevHelperSettingRadioButtonsControl(string name) : base(name) {             
            RadioButtonGroup = new AinDevHelperSettingRadioButtonGroup();
        }

        public AinDevHelperSettingRadioButtonsControl(string name, AinDevHelperSettingRadioButtonGroup radioButtonGroup) : base(name) {
            RadioButtonGroup = radioButtonGroup;
        }

        public AinDevHelperSettingRadioButtonGroup GetRadioButtonGroup() {
            return RadioButtonGroup;
        }

        public void SetRadioButtonGroup(AinDevHelperSettingRadioButtonGroup radioButtonGroup) {
            RadioButtonGroup = radioButtonGroup;
        }

        //public override IAinDevHelperSettingControlValue GetValue() {
        //    return radioButtonGroup;
        //}

        public string SelectedRadioButtonName { 
            get => RadioButtonGroup != null ? RadioButtonGroup.CurrentValue : string.Empty;            
        }

        public bool Add(string radioButtonName) {
            if (RadioButtonGroup != null) {
                RadioButtonGroup.AddValue(radioButtonName);
                return true;
            }
            return false;
        }

        //public override void SetValue(IAinDevHelperSettingControlValue value) {
        //    radioButtonGroup = value;
        //}
    }
}
