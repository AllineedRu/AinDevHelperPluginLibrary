using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary {
    [Serializable]
    public abstract class AinDevHelperSettingBaseControl : IAinDevHelperSettingControl {
        public string Name { get; set; }

        public int OffsetLeft { get; set; }
        public int OffsetTop { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public AinDevHelperSettingBaseControl() {
        }

        public AinDevHelperSettingBaseControl(string name) { 
            Name = name;
        }

        //public abstract IAinDevHelperSettingControlValue GetValue();
        //public abstract void SetValue(IAinDevHelperSettingControlValue value);
    }
}
