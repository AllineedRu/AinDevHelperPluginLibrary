using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary {

    [Serializable]
    public class AinDevHelperSettingTextBoxControl : AinDevHelperSettingBaseControl {
        //protected IAinDevHelperSettingControlValue controlValue;
        public string Label { get; set; }
        public string Text { get; set; }

        public AinDevHelperSettingTextBoxControl() {
        }

        public AinDevHelperSettingTextBoxControl(string name, string label) : base(name) {
            //controlValue = new AinDevHelperSettingTextValue();
            Text = "";
            Label = label;
        }

        public AinDevHelperSettingTextBoxControl(string name, string label, string textValue) : base(name) {
            //controlValue = new AinDevHelperSettingTextValue(textValue);
            Text = textValue;
            Label = label;
        }        
        //public override IAinDevHelperSettingControlValue GetValue() {
        //    return controlValue;
        //}

        //public override void SetValue(IAinDevHelperSettingControlValue value) {
        //    controlValue = value;
        //}
    }
}
