using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary {
    //[XmlInclude(typeof(AinDevHelperSettingBaseControl))]
    //[XmlInclude(typeof(AinDevHelperSettingTextBoxControl))]
    //[XmlInclude(typeof(AinDevHelperSettingCheckBoxesControl))]
    //[XmlInclude(typeof(AinDevHelperSettingRadioButtonsControl))]
    public interface IAinDevHelperSettingControl {
        string Name { get; set; }

        //void SetValue(IAinDevHelperSettingControlValue value);
        //IAinDevHelperSettingControlValue GetValue();
    }
}
