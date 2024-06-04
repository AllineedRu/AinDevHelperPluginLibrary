using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary {
    public interface IAinDevHelperSettingControlValue {
        public string CurrentValue { get; set; }

        public void AddValue(string value);
    }
}
